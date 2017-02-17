using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TASM_IDE.Containers;

namespace TASM_IDE
{
    public partial class FormMain : Form
    {
        private string _currentProjectFilename = null;
        private Project _currentProject = null;

        public FormMain()
        {
            InitializeComponent();
            ResetSettingsToDefault();  
        }

        private void toolStripButtonAddProjectFile_Click(object sender, EventArgs e)
        {
            VerifyProjectSaved();

            if (_currentProject != null && File.Exists(_currentProjectFilename))
            {
                OpenFileDialog od = new OpenFileDialog();
                od.InitialDirectory = Path.GetDirectoryName(_currentProjectFilename);
                DialogResult dr = od.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    string relativePath = GetRelativePath(od.FileName, Path.GetDirectoryName(Path.GetFullPath(_currentProjectFilename)));
                    _currentProject.Files.Add(new ProjectFile(relativePath));

                    objectListViewFiles.RefreshObject(_currentProject.Files);
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
                file.Close();  

                this.Text = "TASM-IDE - " + Path.GetFileName(currentProjectFilename);
                objectListViewFiles.SetObjects(_currentProject.Files);
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

            textBoxRunCommand.Text = "";
            checkBoxTimer.Checked = true;
            numericUpDownObjFill.Value = 0;
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
            project.RunCommand = textBoxRunCommand.Text;
            project.ObjectFillValue = (int)numericUpDownObjFill.Value;
        }

        public void LoadSettingsFromProject(Project project)
        {
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

            textBoxRunCommand.Text = project.RunCommand;
            checkBoxTimer.Checked = project.TimeAssembly;
        }

        private void toolStripButtonBuild_Click(object sender, EventArgs e)
        {
            foreach (ProjectFile file in _currentProject.Files)
            {
                string fileCommand = BuildCommand(file);
            }
        }

        private string BuildCommand(ProjectFile file)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Properties.Settings.Default.ExecutableFilename);
            sb.Append(" ");
            sb.Append(Properties.Settings.Default.ExecutableTableParameter);
            sb.Append(" ");
            sb.Append("-f");
            sb.Append(numericUpDownObjFill.Value.ToString("X2"));



            return sb.ToString();
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
    }
}
