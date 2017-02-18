using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using TASM_IDE.Containers;

namespace TASM_IDE
{
    public partial class FormMain : Form
    {
        private string _currentProjectFilename = null;
        private Project _currentProject = null;
        private List<CompileOutputItem> _compilerOutputItems = new List<CompileOutputItem>();

        public FormMain()
        {
            InitializeComponent();
            ResetSettingsToDefault();

            //objectListViewCompileFormatted.

            olvCompileItemColumnImage.ImageGetter = CompileItemImageGetter;
        }

        public object CompileItemImageGetter(object rowObject) {
            return ((CompileOutputItem)rowObject).CompileOutputTypeAsInt;
        }

        private void toolStripButtonAddProjectFile_Click(object sender, EventArgs e)
        {
            VerifyProjectSaved();

            if (_currentProject != null && File.Exists(_currentProjectFilename))
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Multiselect = true;
                od.InitialDirectory = Path.GetDirectoryName(_currentProjectFilename);
                DialogResult dr = od.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string fileName in od.FileNames)
                    {
                        string relativePath = GetRelativePath(fileName, Path.GetDirectoryName(Path.GetFullPath(_currentProjectFilename)));
                        _currentProject.Files.Add(new ProjectFile(relativePath));
                    }
                    objectListViewFiles.SetObjects(_currentProject.Files);
                }
            }
        }

        public void VerifyProjectSaved()
        {
            if (_currentProject == null || !File.Exists(_currentProjectFilename))
            {
                MessageBox.Show("Save project to file before adding files.", "Project Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        string GetRelativePath(string filespec, string folder)
        {
            Uri pathUri = new Uri(filespec);
            // Folders must end in a slash
            if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                folder += Path.DirectorySeparatorChar;
            }
            Uri folderUri = new Uri(folder);
            return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString().Replace('/', Path.DirectorySeparatorChar));
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {


            if (_currentProject == null || String.IsNullOrEmpty(_currentProjectFilename))
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "TASM Project File | *.tasmp";

                DialogResult dr = sd.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    ResetSettingsToDefault();

                    _currentProject = new Project();
                    _currentProject.IsDirty = false;
                    _currentProjectFilename = sd.FileName;

                    ApplySettingsToProject(_currentProject);

                    System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Project));
                    System.IO.FileStream file = System.IO.File.Create(sd.FileName);
                    writer.Serialize(file, _currentProject);
                    file.Close();

                    LoadProject(_currentProjectFilename);
                }
            }
            else
            {
                ApplySettingsToProject(_currentProject);
                SaveProject(_currentProjectFilename, _currentProject);
                LoadProject(_currentProjectFilename);
            }
        }

        private void SaveProject(string fileName, Project project)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Project));
            System.IO.FileStream file = System.IO.File.Create(fileName);
            writer.Serialize(file, project);
            file.Close();
        }

        private void LoadProject(string currentProjectFilename)
        {
            if (File.Exists(currentProjectFilename))
            {
                // Now we can read the serialized book ...  
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Project));
                System.IO.StreamReader file = new System.IO.StreamReader(currentProjectFilename);
                _currentProject = (Project)reader.Deserialize(file);
                _currentProjectFilename = currentProjectFilename;
                file.Close();  

                this.Text = "TASM-IDE - " + Path.GetFileName(currentProjectFilename);
                LoadSettingsFromProject(_currentProject);
            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "TASM Project File | *.tasmp";
            od.Multiselect = false;
            od.CheckFileExists = true;

            DialogResult dr = od.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                LoadProject(od.FileName);
            }
        }

        public void ResetSettingsToDefault()
        {
            //put the UI back to 'defaults'
            textBoxExpDirectory.Text = ".\\exp";
            textBoxLstDirectory.Text = ".\\lst";
            textBoxObjDirectory.Text = ".\\obj";
            textBoxSymDirectory.Text = ".\\sym";

            comboBoxExpNaming.SelectedIndex = 0;
            comboBoxLstNaming.SelectedIndex = 0;
            comboBoxObjNaming.SelectedIndex = 0;
            comboBoxSymNaming.SelectedIndex = 0;

            comboBoxObjFormat.SelectedIndex = (int)ObjectFileFormat.Binary;

            textBoxExpManualFilename.Text = "";
            textBoxLstManualFilename.Text = "";
            textBoxObjManualFilename.Text = "";
            textBoxSymManualFilename.Text = "";

            textBoxPreBuildCommand.Text = "";
            textBoxPostBuildCommand.Text = "";
            textBoxRunCommand.Text = "";
            checkBoxTimer.Checked = true;
            numericUpDownObjFill.Value = 0;

            checkBoxExpEnable.Checked = true;
            checkBoxLstEnable.Checked = true;
            checkBoxSymEnable.Checked = true;
        }

        private void comboBoxSymNaming_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSymNaming.SelectedIndex == 0)
            {
                textBoxSymManualFilename.BackColor = Color.Gray;
                textBoxSymManualFilename.Enabled = false;
            }
            else
            {
                textBoxSymManualFilename.BackColor = Color.White;
                textBoxSymManualFilename.Enabled = true;
            }
        }

        private void comboBoxExpNaming_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxExpNaming.SelectedIndex == 0)
            {
                textBoxExpManualFilename.BackColor = Color.Gray;
                textBoxExpManualFilename.Enabled = false;
            }
            else
            {
                textBoxExpManualFilename.BackColor = Color.White;
                textBoxExpManualFilename.Enabled = true;
            }
        }

        private void comboBoxLstNaming_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLstNaming.SelectedIndex == 0)
            {
                textBoxLstManualFilename.BackColor = Color.Gray;
                textBoxLstManualFilename.Enabled = false;
            }
            else
            {
                textBoxLstManualFilename.BackColor = Color.White;
                textBoxLstManualFilename.Enabled = true;
            }
        }

        private void comboBoxObjNaming_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxObjNaming.SelectedIndex == 0)
            {
                textBoxObjManualFilename.BackColor = Color.Gray;
                textBoxObjManualFilename.Enabled = false;
            }
            else
            {
                textBoxObjManualFilename.BackColor = Color.White;
                textBoxObjManualFilename.Enabled = true;
            }
        }

        private void ApplySettingsToProject(Project project)
        {
            project.ExportFileOptions.AutoNameFile = (comboBoxExpNaming.SelectedIndex == 0);
            project.ExportFileOptions.ManualFilename = textBoxExpManualFilename.Text;
            project.ExportFileOptions.OutputDirectory = textBoxExpDirectory.Text;

            project.ListingFileOptions.AutoNameFile = (comboBoxLstNaming.SelectedIndex == 0);
            project.ListingFileOptions.ManualFilename = textBoxLstManualFilename.Text;
            project.ListingFileOptions.OutputDirectory = textBoxLstDirectory.Text;

            project.ObjectFileOptions.AutoNameFile = (comboBoxObjNaming.SelectedIndex == 0);
            project.ObjectFileOptions.ManualFilename = textBoxObjManualFilename.Text;
            project.ObjectFileOptions.OutputDirectory = textBoxObjDirectory.Text;

            project.SymbolFileOptions.AutoNameFile = (comboBoxSymNaming.SelectedIndex == 0);
            project.SymbolFileOptions.ManualFilename = textBoxSymManualFilename.Text;
            project.SymbolFileOptions.OutputDirectory = textBoxSymDirectory.Text;

            project.ObjectFileFormat = (ObjectFileFormat)comboBoxObjFormat.SelectedIndex;
            project.TimeAssembly = checkBoxTimer.Checked;
            project.PreBuildCommand = textBoxPreBuildCommand.Text;
            project.PostBuildCommand = textBoxPostBuildCommand.Text;
            project.RunCommand = textBoxRunCommand.Text;
            project.ObjectFillValue = (int)numericUpDownObjFill.Value;

            project.ExportFileEnabled = checkBoxExpEnable.Checked;
            project.ListingFileEnabled = checkBoxLstEnable.Checked;
            project.SymbolFileEnabled = checkBoxSymEnable.Checked;
        }

        public void LoadSettingsFromProject(Project project)
        {
          
            objectListViewFiles.SetObjects(project.Files);

            if (project.ExportFileOptions.AutoNameFile)
            {
                comboBoxExpNaming.SelectedIndex = 0;
            }
            else
            {
                comboBoxExpNaming.SelectedIndex = 1;
            }
            textBoxExpManualFilename.Text = project.ExportFileOptions.ManualFilename;
            textBoxExpDirectory.Text = project.ExportFileOptions.OutputDirectory;

            if (project.ListingFileOptions.AutoNameFile)
            {
                comboBoxLstNaming.SelectedIndex = 0;
            }
            else
            {
                comboBoxLstNaming.SelectedIndex = 1;
            }
            textBoxLstManualFilename.Text = project.ListingFileOptions.ManualFilename;
            textBoxLstDirectory.Text = project.ListingFileOptions.OutputDirectory;

            if (project.ObjectFileOptions.AutoNameFile)
            {
                comboBoxObjNaming.SelectedIndex = 0;
            }
            else
            {
                comboBoxObjNaming.SelectedIndex = 1;
            }
            textBoxObjManualFilename.Text = project.ObjectFileOptions.ManualFilename;
            textBoxObjDirectory.Text = project.ObjectFileOptions.OutputDirectory;
            comboBoxObjFormat.SelectedIndex = (int)project.ObjectFileFormat;
            numericUpDownObjFill.Value = project.ObjectFillValue;

            if (project.SymbolFileOptions.AutoNameFile)
            {
                comboBoxSymNaming.SelectedIndex = 0;
            }
            else
            {
                comboBoxSymNaming.SelectedIndex = 1;
            }
            textBoxSymManualFilename.Text = project.SymbolFileOptions.ManualFilename;
            textBoxSymDirectory.Text = project.SymbolFileOptions.OutputDirectory;

            textBoxPreBuildCommand.Text = project.PreBuildCommand;
            textBoxPostBuildCommand.Text = project.PostBuildCommand;
            textBoxRunCommand.Text = project.RunCommand;
            checkBoxTimer.Checked = project.TimeAssembly;

            checkBoxExpEnable.Checked = project.ExportFileEnabled;
            checkBoxLstEnable.Checked = project.ListingFileEnabled;
            checkBoxSymEnable.Checked = project.SymbolFileEnabled;
        }

        private void toolStripButtonBuild_Click(object sender, EventArgs e)
        {
            BuildCurrentProject();
        }

        private void BuildCurrentProject()
        {
            if (_currentProject != null)
            {
                BuildProject(_currentProject, _currentProjectFilename);
            }
            else
            {
                MessageBox.Show("No Project Loaded.", "Build Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool BuildProject(Project project, string projectFileName)
        {

            toolStripStatusLabel.Text = "Starting Build...";
            Application.DoEvents();

            string executable = Properties.Settings.Default.ExecutableFilename;
            string currentDirectory = Path.GetDirectoryName(projectFileName);

            //make sure any output directories exist
            EnsureDirectoryExists(currentDirectory, textBoxExpDirectory.Text);
            EnsureDirectoryExists(currentDirectory, textBoxLstDirectory.Text);
            EnsureDirectoryExists(currentDirectory, textBoxObjDirectory.Text);
            EnsureDirectoryExists(currentDirectory, textBoxSymDirectory.Text);

            textBoxCompileOutputRaw.Text = "";
            _compilerOutputItems.Clear();
            objectListViewCompileFormatted.SetObjects(_compilerOutputItems);

            //Pre-Build Command
            if (!String.IsNullOrEmpty(textBoxPreBuildCommand.Text))
            {
                string preBuildCommand = Path.Combine(currentDirectory, textBoxPreBuildCommand.Text);
                if (File.Exists(preBuildCommand))
                {
                    textBoxCompileOutputRaw.Text += "Executing Pre-Build Command: " + preBuildCommand + "\r\n";
                    string preBuildOutput = Execute(preBuildCommand, "", currentDirectory, true);
                }
                else
                {
                    CompileOutputItem preBuildErrorItem = new CompileOutputItem();
                    preBuildErrorItem.Description = "Pre-Build Command '" + preBuildCommand + "', does not exist.";
                    preBuildErrorItem.OutputType = CompileOutputType.Error;
                    _compilerOutputItems.Add(preBuildErrorItem);
                }
            }

            foreach (ProjectFile file in project.Files)
            {
                string arguments = BuildCommand(file);

                textBoxCompileOutputRaw.Text += ("Running: " + executable + " " + arguments + "\r\n");

                string fileOutput = Execute(executable, arguments, currentDirectory, true);
                string[] outputLines = fileOutput.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in outputLines)
                {
                    if (line.StartsWith("ERROR"))
                    {
                        CompileOutputItem i = new CompileOutputItem();
                        //ERROR: mh_alpha.asm line 0028: tasm: source file open error on ./exp/auxpgm_4.exp
                        string fileRegex = @"ERROR:\s(\S+)\s";
                        Match fileMatch = Regex.Match(line, fileRegex);
                        if (fileMatch.Groups.Count > 1 && fileMatch.Groups[1].Success)
                        {
                            i.FileName = fileMatch.Groups[1].Value.TrimStart(new char[] { '.', '/' });
                        }

                        string lineRegex = @"line ([0-9]+):";
                        Match lineMatch = Regex.Match(line, lineRegex);
                        if (lineMatch.Success)
                        {
                            string lineString = lineMatch.Groups[1].Value;
                            i.LineNumber = int.Parse(lineString);
                        }

                        string descRegex = @"tasm:\s(.+)$";
                        Match descMatch = Regex.Match(line, descRegex);
                        if (descMatch.Success)
                        {
                            i.Description = descMatch.Groups[1].Value;
                        }
                        else
                        {
                            //"ERROR: ./tw_main.asm line 0528: Label not found: (mgamov)"
                            string altDescRegex = i.LineNumber.ToString("0000") + @":\s(.+)$";
                            Match altDescMatch = Regex.Match(line, altDescRegex);
                            if (altDescMatch.Success)
                            {
                                i.Description = altDescMatch.Groups[1].Value;
                            }
                        }

                        i.OutputType = CompileOutputType.Error;

                        _compilerOutputItems.Add(i);
                    }
                }

                objectListViewCompileFormatted.SetObjects(_compilerOutputItems);
                textBoxCompileOutputRaw.Text += fileOutput;
                textBoxCompileOutputRaw.Text += "\r\n";
                Application.DoEvents();
            }

            //Post-Build Command
            if (!String.IsNullOrEmpty(textBoxPostBuildCommand.Text))
            {
                string postBuildCommand = Path.Combine(currentDirectory, textBoxPostBuildCommand.Text);
                if (File.Exists(postBuildCommand))
                {
                    textBoxCompileOutputRaw.Text += "Executing Post-Build Command: " + postBuildCommand + "\r\n";
                    string postBuildOutput = Execute(postBuildCommand, "", currentDirectory, true);
                }
                else
                {
                    CompileOutputItem postBuildErrorItem = new CompileOutputItem();
                    postBuildErrorItem.Description = "Post-Build Command '" + postBuildCommand + "', does not exist.";
                    postBuildErrorItem.OutputType = CompileOutputType.Error;
                    _compilerOutputItems.Add(postBuildErrorItem);
                }
            }

            textBoxCompileOutputRaw.Text += "Compile Complete.";
            objectListViewCompileFormatted.SetObjects(_compilerOutputItems);

            int errorCount = _compilerOutputItems.Where(i => i.OutputType == CompileOutputType.Error).Count();
            if (errorCount > 0)
            {
                //change focus
                tabControlMain.SelectedIndex = (int)MainTab.Output;
                tabControlCompileOutput.SelectedIndex = (int)OutputTab.Formatted;

                toolStripStatusLabel.Text = "There were " + errorCount.ToString() + " errors";

                return false;
            }
            else
            {
                toolStripStatusLabel.Text = "Build Sucessful.";
            }

            return true;
            
        }

        private string Execute(string executable, string arguments, string workingDirectory, bool hide)
        {
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = Path.Combine(workingDirectory, executable);
            p.StartInfo.Arguments = arguments;
            p.StartInfo.WorkingDirectory = workingDirectory;
            if (hide)
            {
                p.StartInfo.CreateNoWindow = true;
            }
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }

        private void EnsureDirectoryExists(string rootDirectory, string accessoryDirectory)
        {
            if (rootDirectory != null && accessoryDirectory != null)
            {
                string fullDirectory = Path.Combine(rootDirectory, accessoryDirectory);
                if (!Directory.Exists(fullDirectory))
                {
                    Directory.CreateDirectory(fullDirectory);
                }
            }
        }

        private string BuildCommand(ProjectFile file)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Properties.Settings.Default.ExecutableTableParameter);
            sb.Append(" ");
            sb.Append("-f");
            sb.Append(((short)numericUpDownObjFill.Value).ToString("X2"));
            sb.Append(" ");

            if (!String.IsNullOrEmpty(file.Args))
            {
                sb.Append(file.Args);
                sb.Append(" ");
            }

            //source file is first
            sb.Append(file.Filename);
            sb.Append(" ");

            //Object File is next
            sb.Append(textBoxObjDirectory.Text);
            sb.Append("\\");
            if (comboBoxObjNaming.SelectedIndex == 0)
            {
                sb.Append(GetFileName(file, ".obj"));
            }
            else
            {
                sb.Append(textBoxObjManualFilename);
            }
            sb.Append(" ");

            //Listing File is next
            sb.Append(textBoxLstDirectory.Text);
            sb.Append("\\");
            if (comboBoxLstNaming.SelectedIndex == 0)
            {
                sb.Append(GetFileName(file, ".lst"));
            }
            else
            {
                sb.Append(textBoxLstManualFilename);
            }
            sb.Append(" ");

            //Export
            sb.Append(textBoxExpDirectory.Text);
            sb.Append("\\");
            if (comboBoxExpNaming.SelectedIndex == 0)
            {
                sb.Append(GetFileName(file, ".exp"));
            }
            else
            {
                sb.Append(textBoxExpManualFilename);
            }
            sb.Append(" ");

            //Symbol
            sb.Append(textBoxSymDirectory.Text);
            sb.Append("\\");
            if (comboBoxSymNaming.SelectedIndex == 0)
            {
                sb.Append(GetFileName(file, ".sym"));
            }
            else
            {
                sb.Append(textBoxSymManualFilename);
            }
            sb.Append(" ");

            return sb.ToString();
        }

        private string GetFileName(ProjectFile file, string newExtension)
        {
            string noExtension = Path.GetFileNameWithoutExtension(file.Filename);
            return noExtension + newExtension;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_currentProject != null)
            {
                if (_currentProject.IsDirty)
                {
                    //ask about saving
                    DialogResult dr = MessageBox.Show("Do you want to save this project before closing?", "Save Project", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (File.Exists(_currentProjectFilename))
                        {
                            SaveProject(_currentProjectFilename, _currentProject);
                        }
                        else
                        {
                            MessageBox.Show("Project file could not be found. Close aborted.", "Project Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                    }
                    else if (dr == System.Windows.Forms.DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void objectListViewCompileFormatted_DoubleClick(object sender, EventArgs e)
        {
            
            if (objectListViewCompileFormatted.SelectedItem != null)
            {
                string fileName = ((CompileOutputItem)objectListViewCompileFormatted.SelectedItem.RowObject).FileName;
                int lineNumber = ((CompileOutputItem)objectListViewCompileFormatted.SelectedItem.RowObject).LineNumber;

                string args = Path.Combine(Path.GetDirectoryName(_currentProjectFilename), fileName);

                string defaultEditor = "notepad.exe";
                if (!String.IsNullOrEmpty(Properties.Settings.Default.DefaultEditor))
                {
                    if (File.Exists(Properties.Settings.Default.DefaultEditor))
                    {
                        defaultEditor = Properties.Settings.Default.DefaultEditor;
                    }
                    else
                    {
                        MessageBox.Show("The default editor specified in settings does not exist or is not accessible.", "Editor Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (defaultEditor.Contains("notepad++") && lineNumber > 0)
                {
                    args += " -n" + lineNumber.ToString();
                }
                Process.Start(defaultEditor, args);
            }
        }

        private void textBoxPreBuildCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.B)
            {
                BuildCurrentProject();
            }
        }

        private void toolStripButtonMoveUp_Click(object sender, EventArgs e)
        {
            if (_currentProject != null)
            {
                if (objectListViewFiles.SelectedItem != null)
                {
                    int currentIndex = objectListViewFiles.SelectedIndex;
                    if (currentIndex > 0)
                    {
                        ProjectFile p = objectListViewFiles.SelectedItem.RowObject as ProjectFile;
                        _currentProject.Files.Remove(p);
                        _currentProject.Files.Insert(currentIndex - 1, p);
                        objectListViewFiles.SetObjects(_currentProject.Files);
                        objectListViewFiles.SelectedIndex = currentIndex + -1;
                    }
                }
            }
        }

        private void toolStripButtonMoveDown_Click(object sender, EventArgs e)
        {
            if (_currentProject != null)
            {
                if (objectListViewFiles.SelectedItem != null)
                {
                    int currentIndex = objectListViewFiles.SelectedIndex;
                    if (currentIndex < objectListViewFiles.Items.Count - 1)
                    {
                        ProjectFile p = objectListViewFiles.SelectedItem.RowObject as ProjectFile;
                        _currentProject.Files.Remove(p);
                        _currentProject.Files.Insert(currentIndex + 1, p);
                        objectListViewFiles.SetObjects(_currentProject.Files);
                        objectListViewFiles.SelectedIndex = currentIndex + 1;
                    }
                }
            }
        }

        private void objectListViewFiles_DoubleClick(object sender, EventArgs e)
        {
            if (objectListViewFiles.SelectedItem != null)
            {
                ProjectFile pf = objectListViewFiles.SelectedItem.RowObject as ProjectFile;
                if (pf != null)
                {
                    Dialogs.ProjectFileEditor ed = new Dialogs.ProjectFileEditor();
                    ed.FileName = pf.Filename;
                    ed.Args = pf.Args;
                    DialogResult dr = ed.ShowDialog();
                    if (dr == System.Windows.Forms.DialogResult.OK)
                    {
                        pf.Filename = ed.FileName;
                        pf.Args = ed.Args;
                        objectListViewFiles.SetObjects(_currentProject.Files);
                    }
                }
            }
        }

        private void toolStripButtonRun_Click(object sender, EventArgs e)
        {
            BuildCurrentProject();

            if (_compilerOutputItems.Where(i => i.OutputType == CompileOutputType.Error).Count() == 0)
            {
                if (_currentProject != null && !String.IsNullOrEmpty(_currentProject.RunCommand))
                {
                    Execute(_currentProject.RunCommand, "", Path.GetDirectoryName(_currentProjectFilename), false);
                }
            }
        }
    }
}
