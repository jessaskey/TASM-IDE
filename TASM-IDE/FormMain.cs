using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
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
        public string OpenArgs = null;

        private string _currentProjectFilename = null;
        private Project _currentProject = null;
        private List<CompileOutputItem> _compilerOutputItems = new List<CompileOutputItem>();

        public FormMain()
        {
            InitializeComponent();
            olvCompileItemColumnImage.ImageGetter = CompileItemImageGetter;
            LoadRecentFiles();
            ResetSettingsToDefault();
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
                    _currentProject.IsDirty = true;
                }
            }
        }

        private void toolStripButtonRemoveProjectFile_Click(object sender, EventArgs e)
        {
            if (_currentProject != null && File.Exists(_currentProjectFilename))
            {
                if (objectListViewFiles.SelectedItem != null)
                {
                    int currentIndex = objectListViewFiles.SelectedIndex;

                    ProjectFile p = objectListViewFiles.SelectedItem.RowObject as ProjectFile;
                    _currentProject.Files.Remove(p);
                    objectListViewFiles.SetObjects(_currentProject.Files);
                    _currentProject.IsDirty = true;
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
            SaveProject();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "TASM Project File | *.tasmp";

            DialogResult dr = sd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ApplySettingsToProject(_currentProject);
                SaveProject(sd.FileName, _currentProject);
                _currentProject.IsDirty = false;
                _currentProjectFilename = sd.FileName;
                LoadProject(_currentProjectFilename);
                AddRecentfile(_currentProjectFilename);
            }

        }

        private void SaveProject()
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

                    _currentProject.IsDirty = false;
                    LoadProject(_currentProjectFilename);
                }
            }
            else
            {
                ApplySettingsToProject(_currentProject);
                SaveProject(_currentProjectFilename, _currentProject);
                _currentProject.IsDirty = false;
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

                //do some fixes here for conversion
                if (_currentProject.Configurations.Count == 0)
                {
                    //if there are no configurations, we need to have at least two
                    Configuration configurationDebug = new Configuration();
                    configurationDebug.Id = Guid.NewGuid();
                    configurationDebug.Name = "Debug";
                    if (!String.IsNullOrWhiteSpace(_currentProject.RunDebugCommand))
                    {
                        configurationDebug.RunCommand = _currentProject.RunDebugCommand;
                    }
                    _currentProject.Configurations.Add(configurationDebug);

                    Configuration configurationRelease = new Configuration();
                    configurationRelease.Id = Guid.NewGuid();
                    configurationRelease.Name = "Release";
                    if (!String.IsNullOrWhiteSpace(_currentProject.RunCommand))
                    {
                        configurationRelease.RunCommand = _currentProject.RunCommand;
                    }
                    _currentProject.Configurations.Add(configurationRelease);

                    _currentProject.ActiveConfiguration = configurationDebug.Id;
                }

                this.Text = "TASM-IDE - " + currentProjectFilename;
                LoadSettingsFromProject(_currentProject);
                LoadConfigurationsFromProject(_currentProject);
                AddRecentfile(currentProjectFilename);
                _currentProject.IsDirty = false;
            }
        }

        private void LoadConfigurationsFromProject(Project project)
        {
            object oldValue = toolStripComboBoxBuild.ComboBox.SelectedValue;
            toolStripComboBoxBuild.ComboBox.BindingContext = this.BindingContext;
            toolStripComboBoxBuild.ComboBox.DisplayMember = "Name";
            toolStripComboBoxBuild.ComboBox.ValueMember = "Id";
            toolStripComboBoxBuild.ComboBox.DataSource = project.Configurations;

            if (oldValue != null)
            {
                toolStripComboBoxBuild.ComboBox.SelectedValue = oldValue;
            }
            else if (project.ActiveConfiguration != Guid.Empty)
            {
                toolStripComboBoxBuild.ComboBox.SelectedValue = project.ActiveConfiguration;
            }

            //update the UI list
            objectListViewConfigurations.SetObjects(_currentProject.Configurations);
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenProject();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProject();
        }

        private void OpenProject()
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

            textBoxTASMExecutable.Text = "tasmx.exe";
            textBoxCompilerTableParameter.Text = "-65";
            textBoxPreBuildCommand.Text = "";
            textBoxPostBuildCommand.Text = "";
            checkBoxTimer.Checked = true;
            numericUpDownObjFill.Value = 0;

            checkBoxExpEnable.Checked = true;
            checkBoxLstEnable.Checked = true;
            checkBoxSymEnable.Checked = true;
            checkBoxExpandSource.Checked = false;
            checkBoxIgnoreCase.Checked = false;
            checkBoxContiguousBlockOutput.Checked = true;
            comboBoxBuildsToRun.SelectedIndex = 0;
            toolStripComboBoxBuild.SelectedIndex = 0;
        }

        private void comboBoxSymNaming_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSymNaming.SelectedIndex == 0)
            {
                textBoxSymManualFilename.BackColor = Color.LightGray;
                textBoxSymManualFilename.Enabled = false;
            }
            else
            {
                textBoxSymManualFilename.BackColor = Color.White;
                textBoxSymManualFilename.Enabled = true;
            }

            if (_currentProject != null)
            {
                _currentProject.IsDirty = true;
            }
        }

        private void comboBoxExpNaming_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxExpNaming.SelectedIndex == 0)
            {
                textBoxExpManualFilename.BackColor = Color.LightGray;
                textBoxExpManualFilename.Enabled = false;
            }
            else
            {
                textBoxExpManualFilename.BackColor = Color.White;
                textBoxExpManualFilename.Enabled = true;
            }

            if (_currentProject != null)
            {
                _currentProject.IsDirty = true;
            }
        }

        private void comboBoxLstNaming_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLstNaming.SelectedIndex == 0)
            {
                textBoxLstManualFilename.BackColor = Color.LightGray;
                textBoxLstManualFilename.Enabled = false;
            }
            else
            {
                textBoxLstManualFilename.BackColor = Color.White;
                textBoxLstManualFilename.Enabled = true;
            }

            if (_currentProject != null)
            {
                _currentProject.IsDirty = true;
            }
        }

        private void comboBoxObjNaming_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxObjNaming.SelectedIndex == 0)
            {
                textBoxObjManualFilename.BackColor = Color.LightGray;
                textBoxObjManualFilename.Enabled = false;
            }
            else
            {
                textBoxObjManualFilename.BackColor = Color.White;
                textBoxObjManualFilename.Enabled = true;
            }

            if (_currentProject != null)
            {
                _currentProject.IsDirty = true;
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

            project.Executable = textBoxTASMExecutable.Text;
            project.TableParameter = textBoxCompilerTableParameter.Text;
            project.ObjectFileFormat = (ObjectFileFormat)comboBoxObjFormat.SelectedIndex;
            project.TimeAssembly = checkBoxTimer.Checked;
            project.ExpandSourceInListing = checkBoxExpandSource.Checked;
            project.ContiguousBlockOutput = checkBoxContiguousBlockOutput.Checked;
            project.IgnoreCaseInLabels = checkBoxIgnoreCase.Checked;
            project.PreBuildCommand = textBoxPreBuildCommand.Text;
            project.PostBuildCommand = textBoxPostBuildCommand.Text;
            //project.RunCommand = textBoxRunReleaseCommand.Text;
            //project.RunDebugCommand = textBoxRunDebugCommand.Text;
            project.ObjectFillValue = (int)numericUpDownObjFill.Value;

            project.ExportFileEnabled = checkBoxExpEnable.Checked;
            project.ListingFileEnabled = checkBoxLstEnable.Checked;
            project.SymbolFileEnabled = checkBoxSymEnable.Checked;
            project.BuildsToRun = int.Parse(comboBoxBuildsToRun.SelectedItem.ToString());
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

            textBoxTASMExecutable.Text = project.Executable;
            textBoxCompilerTableParameter.Text = project.TableParameter;
            textBoxPreBuildCommand.Text = project.PreBuildCommand;
            textBoxPostBuildCommand.Text = project.PostBuildCommand;
            //textBoxRunReleaseCommand.Text = project.RunCommand;
            //textBoxRunDebugCommand.Text = project.RunDebugCommand;
            checkBoxTimer.Checked = project.TimeAssembly;
            checkBoxExpandSource.Checked = project.ExpandSourceInListing;
            checkBoxIgnoreCase.Checked = project.IgnoreCaseInLabels;
            checkBoxContiguousBlockOutput.Checked = project.ContiguousBlockOutput;

            checkBoxExpEnable.Checked = project.ExportFileEnabled;
            checkBoxLstEnable.Checked = project.ListingFileEnabled;
            checkBoxSymEnable.Checked = project.SymbolFileEnabled;

            comboBoxBuildsToRun.SelectedIndex = 0;
            if (project.BuildsToRun > 0)
            {
                comboBoxBuildsToRun.SelectedIndex = comboBoxBuildsToRun.FindStringExact(project.BuildsToRun.ToString());
            }
        }

        private void toolStripButtonBuild_Click(object sender, EventArgs e)
        {
            BuildCurrentProject(String.Empty);
        }

        private void BuildCurrentProject(string forcedBuildName)
        {
            if (_currentProject != null)
            {
                BuildProject(_currentProject, _currentProjectFilename, forcedBuildName);
                UpdateOBJDetails();
            }
            else
            {
                MessageBox.Show("No Project Loaded.", "Build Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool BuildProject(Project project, string projectFileName, string forcedBuildName)
        {
            Cursor.Current = Cursors.WaitCursor;

            toolStripStatusLabel.Text = "Starting Build...";
            Application.DoEvents();

            string executable = project.Executable;
            string currentDirectory = Path.GetDirectoryName(projectFileName);
            string fullPathExecutable = Path.Combine(currentDirectory, executable);

            //make sure any output directories exist
            EnsureDirectoryExists(currentDirectory, textBoxExpDirectory.Text);
            EnsureDirectoryExists(currentDirectory, textBoxLstDirectory.Text);
            EnsureDirectoryExists(currentDirectory, textBoxObjDirectory.Text);
            EnsureDirectoryExists(currentDirectory, textBoxSymDirectory.Text);

            textBoxCompileOutputRaw.Text = "";
            _compilerOutputItems.Clear();
            listViewLSTDetails.Items.Clear();
            objectListViewCompileFormatted.SetObjects(_compilerOutputItems);

            //test for executable exists first
            if (!File.Exists(fullPathExecutable))
            {
                _compilerOutputItems.Add(new CompileOutputItem() { OutputType = CompileOutputType.Error, FileName = executable, Description = "compiler executable was not found.", LineNumber = 0 });
            }
            else
            {
                //Pre-Build Command
                if (!String.IsNullOrEmpty(textBoxPreBuildCommand.Text))
                {
                    toolStripStatusLabel.Text = "Executing Pre-Build...";
                    Application.DoEvents();
                    string preBuildCommand = Path.Combine(currentDirectory, textBoxPreBuildCommand.Text);
                    if (File.Exists(preBuildCommand))
                    {
                        textBoxCompileOutputRaw.Text += "Executing Pre-Build Command: " + preBuildCommand + "\r\n";
                        string preBuildOutput = Execute(Path.Combine(currentDirectory, preBuildCommand), "", "", currentDirectory, true, true);
                        textBoxCompileOutputRaw.Text += preBuildOutput.Replace("\r\n\r\n", "\r\n") + "\r\n";
                    }
                    else
                    {
                        CompileOutputItem preBuildErrorItem = new CompileOutputItem();
                        preBuildErrorItem.Description = "Pre-Build Command '" + preBuildCommand + "', does not exist.";
                        preBuildErrorItem.OutputType = CompileOutputType.Error;
                        _compilerOutputItems.Add(preBuildErrorItem);
                    }
                }

                Dictionary<string, int> labelUsage = new Dictionary<string, int>();
                Dictionary<string, List<string>> labelLocations = new Dictionary<string, List<string>>();

                foreach (ProjectFile file in project.Files)
                {
                    toolStripStatusLabel.Text = forcedBuildName + "Building " + file.Filename + "...";
                    Application.DoEvents();

                    string arguments = BuildCommand(file);
                    textBoxCompileOutputRaw.Text += ("Running: " + executable + " " + arguments + "\r\n");

                    string fileOutput = Execute(fullPathExecutable, file.Filename, arguments, currentDirectory, true, true);
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

                    //check for the listing file...

                    StringBuilder lb = new StringBuilder();
                    lb.Append(textBoxLstDirectory.Text);
                    lb.Append("\\");
                    if (comboBoxLstNaming.SelectedIndex == 0)
                    {
                        lb.Append(GetFileName(file, ".lst"));
                    }
                    else
                    {
                        lb.Append(textBoxLstManualFilename);
                    }

                    string listFile = currentDirectory + lb.ToString().TrimStart(new char[] { '.' });
                    if (File.Exists(listFile))
                    {
                        List<string> lines = new List<string>();
                        ReadFile(listFile, lines);
                        //string[] lines = File.ReadAllLines(listFile);
                        bool isTable = false;
                        foreach (string line in lines)
                        {
                            if (!isTable)
                            {
                                if (line == "-----    ----    ------    ------------------------------")
                                {
                                    isTable = true;
                                }
                            }
                            else
                            {
                                if (line == "")
                                {
                                    isTable = false;
                                    break;
                                }
                                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                int numParts = parts.Length;
                                string label = parts[numParts - 1].ToLower();
                                int usageCount = int.Parse(parts[numParts - 2]);
                                if (labelUsage.ContainsKey(label))
                                {
                                    labelUsage[label] += usageCount;
                                }
                                else
                                {
                                    labelUsage.Add(label, usageCount);
                                }
                                //locations
                                if (labelLocations.ContainsKey(label))
                                {
                                    labelLocations[label].Add(file.Filename);
                                }
                                else
                                {
                                    labelLocations.Add(label, new List<string>() { file.Filename });
                                }
                            }
                        }
                    }
                }

                toolStripLabelCount.Text = labelUsage.Count().ToString() + " labels generated";
                foreach (KeyValuePair<string, int> kvp in labelUsage.OrderBy(v => v.Value))
                {
                    ListViewItem lvi = new ListViewItem(kvp.Key);
                    lvi.SubItems.Add(kvp.Value.ToString());
                    if (labelLocations.ContainsKey(kvp.Key) && kvp.Value > 0)
                    {
                        lvi.SubItems.Add(String.Join(",", labelLocations[kvp.Key].OrderBy(s => s).ToArray()));
                    }
                    listViewLSTDetails.Items.Add(lvi);
                }

                //Post-Build Command
                if (!String.IsNullOrEmpty(textBoxPostBuildCommand.Text))
                {
                    toolStripStatusLabel.Text = forcedBuildName + "Executing Post-Build...";
                    Application.DoEvents();
                    string postBuildCommand = Path.Combine(currentDirectory, textBoxPostBuildCommand.Text);
                    if (File.Exists(postBuildCommand))
                    {
                        textBoxCompileOutputRaw.Text += "Executing Post-Build Command: " + postBuildCommand + "\r\n";
                        string postBuildOutput = Execute(Path.Combine(currentDirectory, postBuildCommand), "", "", currentDirectory, true, true);
                        textBoxCompileOutputRaw.Text += postBuildOutput.Replace("\r\n\r\n", "\r\n") + "\r\n";
                    }
                }

                textBoxCompileOutputRaw.Text += "Compile Complete.";
            }

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

            Cursor.Current = Cursors.Default;

            return true;
            
        }

        private void ReadFile(string filename, List<string> outputLines)
        {
            using (FileStream logFileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader logFileReader = new StreamReader(logFileStream))
                {
                    while (!logFileReader.EndOfStream)
                    {
                        outputLines.Add(logFileReader.ReadLine());
                    }
                }
            }
        }

        private string Execute(string executable, string targetfile, string arguments, string workingDirectory, bool hide, bool wait)
        {
            if (!File.Exists(executable))
            {
                return "ERROR: " + Path.GetFileName(executable) + " line 0000: program executable not found at '" + executable + "'";
            }

            StringBuilder sb = new StringBuilder();

            using (Process p = new Process())
            {
                // Redirect the output stream of the child process.
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = executable;
                p.StartInfo.Arguments = arguments;
                if (!String.IsNullOrEmpty(workingDirectory))
                {
                    p.StartInfo.WorkingDirectory = workingDirectory;
                }
                if (hide)
                {
                    p.StartInfo.CreateNoWindow = true;
                }

                if (!wait)
                {
                    p.Start();
                }
                else
                {
                    //must wait for exit then
                    int timeout = 30 * 1000;
                    p.Start();

                    using (StreamReader reader = p.StandardOutput)
                    {
                        sb.AppendLine(reader.ReadToEnd());
                    }

                    using (StreamReader reader = p.StandardError)
                    {
                        sb.AppendLine(reader.ReadToEnd());
                    }

                    if (p.WaitForExit(timeout)) 
                    {
                        if (p.ExitCode < 0)
                        {
                            sb.AppendLine("ERROR: " + targetfile + " line 0000: tasm: Program terminated unexpectedly with Exception '" + p.ExitCode.ToString() + "'. There may be more details in the output listing.");
                        }
                        else if (p.ExitCode >= 2)
                        {
                            string currentError = sb.ToString().Replace("\r\n", "");
                            if (p.ExitCode == 2)
                            {
                                sb.AppendLine("ERROR: " + targetfile + " line 0000: tasm: Insufficient Memory Error:'" + currentError + "'");
                            }
                            if (p.ExitCode == 3)
                            {
                                sb.AppendLine("ERROR: " + targetfile + " line 0000: tasm: File Not found or not accessible: " + currentError + "'");
                            }
                            if (p.ExitCode == 4)
                            {
                                sb.AppendLine("ERROR: " + targetfile + " line 0000: tasm: Program terminated unexpectedly with a General error: '" + currentError + "'");
                            }
                        }
                    }
                    else
                    {
                        // Timed out.
                        sb.AppendLine("ERROR: " + targetfile + " - Program timed out!");
                    } 
                }
            }

            return sb.ToString();
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

            sb.Append(textBoxCompilerTableParameter.Text);
            sb.Append(" ");

            //object file output, index based upon the combo
            sb.Append("-g");
            sb.Append(comboBoxObjFormat.SelectedIndex.ToString());
            sb.Append(" ");

            //contiguous block output
            if (checkBoxContiguousBlockOutput.Checked)
            {
                sb.Append("-c ");
            }

            //fill values
            sb.Append("-f");
            sb.Append(((short)numericUpDownObjFill.Value).ToString("x2"));
            sb.Append(" ");

            //disable the listing file - quiet mode
            if (!checkBoxLstEnable.Checked)
            {
                sb.Append("-q ");
            }

            //enable the symbol file
            if (checkBoxSymEnable.Checked)
            {
                sb.Append("-s ");
            }

            //Expand source flag
            if (checkBoxExpandSource.Checked)
            {
                sb.Append("-e ");
            }

            //Ignore Case flag
            if (checkBoxIgnoreCase.Checked)
            {
                sb.Append("-i ");
            }

            sb.Append("-ll ");

            //timing
            if (checkBoxTimer.Checked)
            {
                sb.Append("-y ");
            }

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
            DialogResult dr = SaveCurrentProject();
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                SaveRecentFiles();
            }

        }

        private DialogResult SaveCurrentProject()
        {
            DialogResult dr = DialogResult.OK;
            if (_currentProject != null)
            {
                if (_currentProject.IsDirty)
                {
                    //ask about saving
                    dr = MessageBox.Show("Do you want to save this project before closing?", "Save Project", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (File.Exists(_currentProjectFilename))
                        {
                            SaveProject(_currentProjectFilename, _currentProject);
                            dr = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Project file could not be found. Close aborted.", "Project Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            return dr;
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
            if (e.KeyCode == Keys.F6)
            {
                BuildCurrentProject(String.Empty);
            }
            else if (e.KeyCode == Keys.F5)
            {
                RunCurrentProject();
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
            RunCurrentProject();
        }

        private void RunCurrentProject()
        {
            if (_currentProject != null)
            {
                BuildCurrentProject(String.Empty);

                if (_compilerOutputItems.Where(i => i.OutputType == CompileOutputType.Error).Count() == 0)
                {
                    for(int i = 1; i < _currentProject.BuildsToRun; i++)
                    {
                        //build each time...
                        BuildCurrentProject("FORCED BUILD #" + i.ToString() + ": ");
                    }
                    if (_currentProject != null)
                    {
                        Configuration currentConfiguration = _currentProject.Configurations.Where(c => c.Id == _currentProject.ActiveConfiguration).FirstOrDefault();
                        if (currentConfiguration != null)
                        {
                            string currentDirectory = Path.GetDirectoryName(_currentProjectFilename);
                            string runCommand = Path.Combine(currentDirectory, currentConfiguration.RunCommand);
                            if (File.Exists(runCommand))
                            {
                                textBoxCompileOutputRaw.Text += "Running Configuration '" + currentConfiguration.Name + "': " + runCommand + " " + currentConfiguration.Arguments;
                                string runCommandOutput = Execute(runCommand, "", currentConfiguration.Arguments, currentDirectory, false, false);
                                textBoxCompileOutputRaw.Text += runCommandOutput.Replace("\r\n\r\n", "\r\n") + "\r\n";
                            }
                            else
                            {
                                MessageBox.Show("The Configuration Run command was not found: '" + runCommand + "'", "Run Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewProject();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            CreateNewProject();
        }


        private void CreateNewProject()
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
                        }
                    }
                }
            }
            ResetSettingsToDefault();

        }


        private void CompilationOptions_OnChanged(object sender, EventArgs e)
        {
            if (_currentProject != null)
            {
                _currentProject.IsDirty = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TASM-IDE\r\nJess M. Askey\r\njess@askey.org", "About TASM-IDE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildCurrentProject(String.Empty);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunCurrentProject();
        }


        #region RecentItemsMenu

        private void AddRecentfile(string fileName)
        {
            //get the recent files already here...take them out
            RemoveRecentItem(fileName);
            //put it back, on top tho
            ToolStripMenuItem newItem = new ToolStripMenuItem();
            newItem.Text = fileName;
            recentProjectsToolStripMenuItem.DropDownItems.Insert(0, newItem);


        }


        private void LoadRecentFiles()
        {
            recentProjectsToolStripMenuItem.DropDownItems.Clear();

            string[] files = Properties.Settings.Default.RecentFileList.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string file in files)
            {
                string fileName = file;
                if (!File.Exists(fileName))
                {
                    fileName = file + "(Not Found)";
                }
                ToolStripMenuItem item = new ToolStripMenuItem(fileName);
                item.Click += recentItem_Click;
                recentProjectsToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        /// <summary>
        /// Saves the current recent files Menu Items into the application settings
        /// </summary>
        private void SaveRecentFiles()
        {
            Properties.Settings.Default.RecentFileList = String.Join(";", recentProjectsToolStripMenuItem.DropDownItems.Cast<ToolStripMenuItem>().Select(i => i.Text).ToArray());
            Properties.Settings.Default.Save();
        }

        private void RemoveRecentItem(string fileName)
        {
            for (int i = recentProjectsToolStripMenuItem.DropDownItems.Count - 1; i >= 0; i--)
            {
                ToolStripMenuItem item = recentProjectsToolStripMenuItem.DropDownItems[i] as ToolStripMenuItem;
                if (item != null)
                {
                    if (fileName.ToLower() == item.Text.ToLower())
                    {
                        recentProjectsToolStripMenuItem.DropDownItems.Remove(item);
                    }
                }
            }
        }

        private void recentItem_Click(object sender, EventArgs e)
        {
            //a recent item was checked here... open it 
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                if (File.Exists(item.Text))
                {
                    switch (Path.GetExtension(item.Text).ToLower())
                    {
                        case ".tasmp":
                            {
                                DialogResult dr = SaveCurrentProject();
                                if (dr == DialogResult.Cancel)
                                {
                                    return;
                                }
                                LoadProject(item.Text);
                                AddRecentfile(item.Text);
                            }
                            break;
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("File no longer exists in the location or cannot be opened. Would you like to remove this from the Recent File list?", "Missing File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        RemoveRecentItem(item.Text);
                    }
                }
            }

        }


        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            string passedFilename = "";
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                passedFilename = args[0];
            }
            else
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    if (AppDomain.CurrentDomain != null)
                    {
                        if (AppDomain.CurrentDomain.SetupInformation != null)
                        {
                            if (AppDomain.CurrentDomain.SetupInformation.ActivationArguments != null)
                            {
                                if (AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData != null)
                                {
                                    if (AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData.Length > 0)
                                    {
                                        Uri uri = new Uri(AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData[0]);
                                        passedFilename = uri.LocalPath.ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //check for passed args
            if (passedFilename != null)
            {
                //MessageBox.Show(arg, "Open");
                if (File.Exists(passedFilename))
                {
                    //MessageBox.Show(arg, "Exists");
                    if (OpenArgs.ToLower().EndsWith(".tasmp"))
                    {
                        //MessageBox.Show(arg, "Project");
                        LoadProject(OpenArgs);
                    }
                }           
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialogs.ProgramSettings ps = new Dialogs.ProgramSettings();
            ps.EditorExecutable = Properties.Settings.Default.DefaultEditor;
            DialogResult dr = ps.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Properties.Settings.Default.DefaultEditor = ps.EditorExecutable;
                Properties.Settings.Default.Save();
            }
        }

        private void objectListViewCompileFormatted_CellToolTipShowing(object sender, BrightIdeasSoftware.ToolTipShowingEventArgs e)
        {
            // Show a long tooltip over cells only when the control key is down
            if (Control.ModifierKeys == Keys.Control)
            {
                CompileOutputItem i = (CompileOutputItem)e.Item.RowObject;
                e.Text = i.Description;
            }
        }

        private void objectListViewCompileFormatted_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBoxBuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentProject != null)
            {
                if (toolStripComboBoxBuild.ComboBox.SelectedValue != null)
                {
                    _currentProject.ActiveConfiguration = (Guid)toolStripComboBoxBuild.ComboBox.SelectedValue;
                }
            }
        }


        private void UpdateOBJDetails()
        {
            listViewObjDetails.Items.Clear();

            string objDirectory = Path.Combine(Path.GetDirectoryName(Path.GetFullPath(_currentProjectFilename)), textBoxObjDirectory.Text.Replace(".\\",""));
            if (Directory.Exists(objDirectory))
            {
                foreach (string file in Directory.GetFiles(objDirectory))
                {
                    ListViewItem i = new ListViewItem();
                    i.Text = Path.GetFileName(file);

                    FileInfo fi = new FileInfo(file);
                    i.SubItems.Add(fi.Length.ToString());

                    int unusedBytes = GetUnusedBytes(file);
                    int usedBytes = ((int)fi.Length) - unusedBytes;
                    if (fi.Length == 0)
                    {
                        i.SubItems.Add("ZERO LENGTH");
                    }
                    else
                    {
                        decimal percentUsed = ((decimal)usedBytes) / ((decimal)fi.Length);
                        i.SubItems.Add(percentUsed.ToString("P"));
                        i.SubItems.Add(GetChecksum(file));
                    }

                    listViewObjDetails.Items.Add(i);

                }
            }
        }

        private string GetChecksum(string filename)
        {
            string csumString = "ERROR";
            if (File.Exists(filename))
            {
                int csum = 0;
                byte[] bytes = File.ReadAllBytes(filename);
                foreach (byte b in bytes)
                {
                    csum += b;
                }
                csumString = (csum & 0xFFFF).ToString("X4");
            }
            return csumString;
        }

        private int GetUnusedBytes(string file)
        {
            byte emptyValue = (byte)numericUpDownObjFill.Value;
            int unusedBytes = 0;
            int checksum = 0;

            //File.ReadAllBytes(file);
            using (FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] bytes = new byte[fileStream.Length];
                int numBytesToRead = (int)fileStream.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    // Read may return anything from 0 to numBytesToRead.
                    int n = fileStream.Read(bytes, numBytesRead, numBytesToRead);

                    // Break when the end of the file is reached.
                    if (n == 0)
                        break;

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = bytes.Length;

                for (int i = 0; i < bytes.Length; i++)
                {
                    checksum += bytes[i];
                    if (bytes[i] == emptyValue && i < bytes.Length - 1 && bytes[i + 1] == emptyValue)
                    {
                        unusedBytes++;
                    }
                }
            }



            return unusedBytes;
        }

        private void ObjectListViewConfigurations_DoubleClick(object sender, EventArgs e)
        {
            if (objectListViewConfigurations.SelectedItem != null)
            {
                Configuration configuration = objectListViewConfigurations.SelectedItem.RowObject as Configuration;
                if (configuration != null)
                {
                    Dialogs.ConfigurationEditor ed = new Dialogs.ConfigurationEditor();
                    ed.Name = configuration.Name;
                    ed.RunCommand = configuration.RunCommand;
                    ed.Arguments = configuration.Arguments;
                    DialogResult dr = ed.ShowDialog();
                    if (dr == System.Windows.Forms.DialogResult.OK)
                    {
                        configuration.Name = ed.Name;
                        configuration.RunCommand = ed.RunCommand;
                        configuration.Arguments = ed.Arguments;
                        LoadConfigurationsFromProject(_currentProject);
                        objectListViewConfigurations.RefreshObject(configuration);
                    }
                }
            }
        }

        private void ToolStripButtonNewConfiguration_Click(object sender, EventArgs e)
        {
            Dialogs.ConfigurationEditor ed = new Dialogs.ConfigurationEditor();
            DialogResult dr = ed.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Configuration configuration = new Configuration();
                configuration.Id = Guid.NewGuid();
                configuration.Name = ed.Name;
                configuration.RunCommand = ed.RunCommand;
                configuration.Arguments = ed.Arguments;
                _currentProject.Configurations.Add(configuration);
                LoadConfigurationsFromProject(_currentProject);
                _currentProject.IsDirty = true;
            }
        }

        private void ToolStripButtonDeleteConfiguration_Click(object sender, EventArgs e)
        {
            if (_currentProject != null && File.Exists(_currentProjectFilename))
            {
                if (objectListViewConfigurations.SelectedItem != null)
                {
                    int currentIndex = objectListViewConfigurations.SelectedIndex;

                    Configuration p = objectListViewConfigurations.SelectedItem.RowObject as Configuration;
                    _currentProject.Configurations.Remove(p);
                    objectListViewConfigurations.SetObjects(_currentProject.Configurations);
                    _currentProject.IsDirty = true;
                }
            }
        }
    }
}
