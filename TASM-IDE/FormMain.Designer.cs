namespace TASM_IDE
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.objectListViewFiles = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddProjectFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveProjectFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMoveUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveDown = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxCompilerTableParameter = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxTASMExecutable = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBoxIgnoreCase = new System.Windows.Forms.CheckBox();
            this.checkBoxExpandSource = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxPostBuildCommand = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPreBuildCommand = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxRunDebugCommand = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxLstEnable = new System.Windows.Forms.CheckBox();
            this.textBoxLstManualFilename = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxLstNaming = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxLstDirectory = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxTimer = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxExpEnable = new System.Windows.Forms.CheckBox();
            this.textBoxExpManualFilename = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxExpNaming = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxExpDirectory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxSymEnable = new System.Windows.Forms.CheckBox();
            this.textBoxSymManualFilename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSymNaming = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSymDirectory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxContiguousBlockOutput = new System.Windows.Forms.CheckBox();
            this.numericUpDownObjFill = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxObjManualFilename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxObjNaming = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxObjDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxObjFormat = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControlCompileOutput = new System.Windows.Forms.TabControl();
            this.tabPageCompileOutputFormatted = new System.Windows.Forms.TabPage();
            this.objectListViewCompileFormatted = new BrightIdeasSoftware.ObjectListView();
            this.olvCompileItemColumnImage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFile = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLine = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListCompileOutputs = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tabPageCompileOutputRaw = new System.Windows.Forms.TabPage();
            this.textBoxCompileOutputRaw = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBuild = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxBuild = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxRunReleaseCommand = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewFiles)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjFill)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControlCompileOutput.SuspendLayout();
            this.tabPageCompileOutputFormatted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCompileFormatted)).BeginInit();
            this.tabPageCompileOutputRaw.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 56);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(777, 575);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.objectListViewFiles);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(769, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Project Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // objectListViewFiles
            // 
            this.objectListViewFiles.AllColumns.Add(this.olvColumn1);
            this.objectListViewFiles.AllColumns.Add(this.olvColumn2);
            this.objectListViewFiles.CellEditUseWholeCell = false;
            this.objectListViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.objectListViewFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewFiles.FullRowSelect = true;
            this.objectListViewFiles.Location = new System.Drawing.Point(4, 31);
            this.objectListViewFiles.Margin = new System.Windows.Forms.Padding(4);
            this.objectListViewFiles.Name = "objectListViewFiles";
            this.objectListViewFiles.ShowGroups = false;
            this.objectListViewFiles.Size = new System.Drawing.Size(761, 511);
            this.objectListViewFiles.TabIndex = 1;
            this.objectListViewFiles.UseCompatibleStateImageBehavior = false;
            this.objectListViewFiles.View = System.Windows.Forms.View.Details;
            this.objectListViewFiles.DoubleClick += new System.EventHandler(this.objectListViewFiles_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Filename";
            this.olvColumn1.Text = "Filename";
            this.olvColumn1.Width = 164;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Args";
            this.olvColumn2.FillsFreeSpace = true;
            this.olvColumn2.Text = "Custom Arguments";
            this.olvColumn2.Width = 159;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddProjectFile,
            this.toolStripButtonRemoveProjectFile,
            this.toolStripSeparator2,
            this.toolStripButtonMoveUp,
            this.toolStripButtonMoveDown});
            this.toolStrip1.Location = new System.Drawing.Point(4, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(761, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddProjectFile
            // 
            this.toolStripButtonAddProjectFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddProjectFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddProjectFile.Image")));
            this.toolStripButtonAddProjectFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddProjectFile.Name = "toolStripButtonAddProjectFile";
            this.toolStripButtonAddProjectFile.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddProjectFile.Text = "Add File";
            this.toolStripButtonAddProjectFile.Click += new System.EventHandler(this.toolStripButtonAddProjectFile_Click);
            // 
            // toolStripButtonRemoveProjectFile
            // 
            this.toolStripButtonRemoveProjectFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveProjectFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveProjectFile.Image")));
            this.toolStripButtonRemoveProjectFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveProjectFile.Name = "toolStripButtonRemoveProjectFile";
            this.toolStripButtonRemoveProjectFile.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRemoveProjectFile.Text = "Remove Selected File";
            this.toolStripButtonRemoveProjectFile.Click += new System.EventHandler(this.toolStripButtonRemoveProjectFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonMoveUp
            // 
            this.toolStripButtonMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveUp.Image")));
            this.toolStripButtonMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveUp.Name = "toolStripButtonMoveUp";
            this.toolStripButtonMoveUp.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonMoveUp.Text = "Move Selected File Up";
            this.toolStripButtonMoveUp.Click += new System.EventHandler(this.toolStripButtonMoveUp_Click);
            // 
            // toolStripButtonMoveDown
            // 
            this.toolStripButtonMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveDown.Image")));
            this.toolStripButtonMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveDown.Name = "toolStripButtonMoveDown";
            this.toolStripButtonMoveDown.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonMoveDown.Text = "Move Selected File Down";
            this.toolStripButtonMoveDown.Click += new System.EventHandler(this.toolStripButtonMoveDown_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxCompilerTableParameter);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.textBoxTASMExecutable);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.checkBoxIgnoreCase);
            this.tabPage2.Controls.Add(this.checkBoxExpandSource);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.checkBoxTimer);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(769, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compile Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxCompilerTableParameter
            // 
            this.textBoxCompilerTableParameter.Location = new System.Drawing.Point(544, 12);
            this.textBoxCompilerTableParameter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCompilerTableParameter.Name = "textBoxCompilerTableParameter";
            this.textBoxCompilerTableParameter.Size = new System.Drawing.Size(192, 22);
            this.textBoxCompilerTableParameter.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(392, 16);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 17);
            this.label19.TabIndex = 14;
            this.label19.Text = "Table Parameter:";
            // 
            // textBoxTASMExecutable
            // 
            this.textBoxTASMExecutable.Location = new System.Drawing.Point(167, 12);
            this.textBoxTASMExecutable.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTASMExecutable.Name = "textBoxTASMExecutable";
            this.textBoxTASMExecutable.Size = new System.Drawing.Size(192, 22);
            this.textBoxTASMExecutable.TabIndex = 10;
            this.textBoxTASMExecutable.Text = "tasmx.exe";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 16);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 17);
            this.label18.TabIndex = 10;
            this.label18.Text = "TASM Executable:";
            // 
            // checkBoxIgnoreCase
            // 
            this.checkBoxIgnoreCase.AutoSize = true;
            this.checkBoxIgnoreCase.Location = new System.Drawing.Point(404, 502);
            this.checkBoxIgnoreCase.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxIgnoreCase.Name = "checkBoxIgnoreCase";
            this.checkBoxIgnoreCase.Size = new System.Drawing.Size(172, 21);
            this.checkBoxIgnoreCase.TabIndex = 12;
            this.checkBoxIgnoreCase.Text = "Ignore Case on Labels";
            this.checkBoxIgnoreCase.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreCase.CheckedChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // checkBoxExpandSource
            // 
            this.checkBoxExpandSource.AutoSize = true;
            this.checkBoxExpandSource.Location = new System.Drawing.Point(404, 478);
            this.checkBoxExpandSource.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxExpandSource.Name = "checkBoxExpandSource";
            this.checkBoxExpandSource.Size = new System.Drawing.Size(229, 21);
            this.checkBoxExpandSource.TabIndex = 11;
            this.checkBoxExpandSource.Text = "Expand Macro Source in Listing";
            this.checkBoxExpandSource.UseVisualStyleBackColor = true;
            this.checkBoxExpandSource.CheckedChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxRunReleaseCommand);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.textBoxPostBuildCommand);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.textBoxPreBuildCommand);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.textBoxRunDebugCommand);
            this.groupBox5.Location = new System.Drawing.Point(385, 281);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(367, 167);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Other Processing:";
            // 
            // textBoxPostBuildCommand
            // 
            this.textBoxPostBuildCommand.Location = new System.Drawing.Point(118, 63);
            this.textBoxPostBuildCommand.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostBuildCommand.Name = "textBoxPostBuildCommand";
            this.textBoxPostBuildCommand.Size = new System.Drawing.Size(239, 22);
            this.textBoxPostBuildCommand.TabIndex = 5;
            this.textBoxPostBuildCommand.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 100);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "Run (Debug):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 66);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Post-Build:";
            // 
            // textBoxPreBuildCommand
            // 
            this.textBoxPreBuildCommand.Location = new System.Drawing.Point(118, 30);
            this.textBoxPreBuildCommand.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPreBuildCommand.Name = "textBoxPreBuildCommand";
            this.textBoxPreBuildCommand.Size = new System.Drawing.Size(239, 22);
            this.textBoxPreBuildCommand.TabIndex = 2;
            this.textBoxPreBuildCommand.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            this.textBoxPreBuildCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPreBuildCommand_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 33);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Pre-Build:";
            // 
            // textBoxRunDebugCommand
            // 
            this.textBoxRunDebugCommand.Location = new System.Drawing.Point(118, 96);
            this.textBoxRunDebugCommand.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRunDebugCommand.Name = "textBoxRunDebugCommand";
            this.textBoxRunDebugCommand.Size = new System.Drawing.Size(239, 22);
            this.textBoxRunDebugCommand.TabIndex = 0;
            this.textBoxRunDebugCommand.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxLstEnable);
            this.groupBox2.Controls.Add(this.textBoxLstManualFilename);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBoxLstNaming);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxLstDirectory);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(11, 362);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(367, 149);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listing File Options:";
            // 
            // checkBoxLstEnable
            // 
            this.checkBoxLstEnable.AutoSize = true;
            this.checkBoxLstEnable.Checked = true;
            this.checkBoxLstEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLstEnable.Location = new System.Drawing.Point(156, 18);
            this.checkBoxLstEnable.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLstEnable.Name = "checkBoxLstEnable";
            this.checkBoxLstEnable.Size = new System.Drawing.Size(145, 21);
            this.checkBoxLstEnable.TabIndex = 10;
            this.checkBoxLstEnable.Text = "Enable Listing File";
            this.checkBoxLstEnable.UseVisualStyleBackColor = true;
            this.checkBoxLstEnable.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // textBoxLstManualFilename
            // 
            this.textBoxLstManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxLstManualFilename.Enabled = false;
            this.textBoxLstManualFilename.Location = new System.Drawing.Point(156, 113);
            this.textBoxLstManualFilename.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLstManualFilename.Name = "textBoxLstManualFilename";
            this.textBoxLstManualFilename.Size = new System.Drawing.Size(192, 22);
            this.textBoxLstManualFilename.TabIndex = 7;
            this.textBoxLstManualFilename.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Manual Filename:";
            // 
            // comboBoxLstNaming
            // 
            this.comboBoxLstNaming.FormattingEnabled = true;
            this.comboBoxLstNaming.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.comboBoxLstNaming.Location = new System.Drawing.Point(156, 80);
            this.comboBoxLstNaming.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLstNaming.Name = "comboBoxLstNaming";
            this.comboBoxLstNaming.Size = new System.Drawing.Size(192, 24);
            this.comboBoxLstNaming.TabIndex = 5;
            this.comboBoxLstNaming.SelectedIndexChanged += new System.EventHandler(this.comboBoxLstNaming_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 84);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "File Naming:";
            // 
            // textBoxLstDirectory
            // 
            this.textBoxLstDirectory.Location = new System.Drawing.Point(156, 47);
            this.textBoxLstDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLstDirectory.Name = "textBoxLstDirectory";
            this.textBoxLstDirectory.Size = new System.Drawing.Size(192, 22);
            this.textBoxLstDirectory.TabIndex = 3;
            this.textBoxLstDirectory.Text = "./lst";
            this.textBoxLstDirectory.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Output Directory:";
            // 
            // checkBoxTimer
            // 
            this.checkBoxTimer.AutoSize = true;
            this.checkBoxTimer.Location = new System.Drawing.Point(404, 456);
            this.checkBoxTimer.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(160, 21);
            this.checkBoxTimer.TabIndex = 0;
            this.checkBoxTimer.Text = "Time each Assembly";
            this.checkBoxTimer.UseVisualStyleBackColor = true;
            this.checkBoxTimer.CheckedChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxExpEnable);
            this.groupBox4.Controls.Add(this.textBoxExpManualFilename);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.comboBoxExpNaming);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBoxExpDirectory);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(11, 204);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(367, 150);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Export File Options:";
            // 
            // checkBoxExpEnable
            // 
            this.checkBoxExpEnable.AutoSize = true;
            this.checkBoxExpEnable.Checked = true;
            this.checkBoxExpEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExpEnable.Location = new System.Drawing.Point(156, 18);
            this.checkBoxExpEnable.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxExpEnable.Name = "checkBoxExpEnable";
            this.checkBoxExpEnable.Size = new System.Drawing.Size(144, 21);
            this.checkBoxExpEnable.TabIndex = 8;
            this.checkBoxExpEnable.Text = "Enable Export File";
            this.checkBoxExpEnable.UseVisualStyleBackColor = true;
            this.checkBoxExpEnable.CheckedChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // textBoxExpManualFilename
            // 
            this.textBoxExpManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxExpManualFilename.Enabled = false;
            this.textBoxExpManualFilename.Location = new System.Drawing.Point(156, 113);
            this.textBoxExpManualFilename.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExpManualFilename.Name = "textBoxExpManualFilename";
            this.textBoxExpManualFilename.Size = new System.Drawing.Size(192, 22);
            this.textBoxExpManualFilename.TabIndex = 7;
            this.textBoxExpManualFilename.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Manual Filename:";
            // 
            // comboBoxExpNaming
            // 
            this.comboBoxExpNaming.FormattingEnabled = true;
            this.comboBoxExpNaming.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.comboBoxExpNaming.Location = new System.Drawing.Point(156, 80);
            this.comboBoxExpNaming.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxExpNaming.Name = "comboBoxExpNaming";
            this.comboBoxExpNaming.Size = new System.Drawing.Size(192, 24);
            this.comboBoxExpNaming.TabIndex = 5;
            this.comboBoxExpNaming.SelectedIndexChanged += new System.EventHandler(this.comboBoxExpNaming_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "File Naming:";
            // 
            // textBoxExpDirectory
            // 
            this.textBoxExpDirectory.Location = new System.Drawing.Point(156, 47);
            this.textBoxExpDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExpDirectory.Name = "textBoxExpDirectory";
            this.textBoxExpDirectory.Size = new System.Drawing.Size(192, 22);
            this.textBoxExpDirectory.TabIndex = 3;
            this.textBoxExpDirectory.Text = "./exp";
            this.textBoxExpDirectory.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Output Directory:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxSymEnable);
            this.groupBox3.Controls.Add(this.textBoxSymManualFilename);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxSymNaming);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxSymDirectory);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(11, 50);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(367, 149);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symbol File Options:";
            // 
            // checkBoxSymEnable
            // 
            this.checkBoxSymEnable.AutoSize = true;
            this.checkBoxSymEnable.Checked = true;
            this.checkBoxSymEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSymEnable.Location = new System.Drawing.Point(156, 18);
            this.checkBoxSymEnable.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSymEnable.Name = "checkBoxSymEnable";
            this.checkBoxSymEnable.Size = new System.Drawing.Size(150, 21);
            this.checkBoxSymEnable.TabIndex = 9;
            this.checkBoxSymEnable.Text = "Enable Symbol File";
            this.checkBoxSymEnable.UseVisualStyleBackColor = true;
            this.checkBoxSymEnable.CheckedChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // textBoxSymManualFilename
            // 
            this.textBoxSymManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxSymManualFilename.Enabled = false;
            this.textBoxSymManualFilename.Location = new System.Drawing.Point(156, 113);
            this.textBoxSymManualFilename.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSymManualFilename.Name = "textBoxSymManualFilename";
            this.textBoxSymManualFilename.Size = new System.Drawing.Size(192, 22);
            this.textBoxSymManualFilename.TabIndex = 7;
            this.textBoxSymManualFilename.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manual Filename:";
            // 
            // comboBoxSymNaming
            // 
            this.comboBoxSymNaming.FormattingEnabled = true;
            this.comboBoxSymNaming.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.comboBoxSymNaming.Location = new System.Drawing.Point(156, 80);
            this.comboBoxSymNaming.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSymNaming.Name = "comboBoxSymNaming";
            this.comboBoxSymNaming.Size = new System.Drawing.Size(192, 24);
            this.comboBoxSymNaming.TabIndex = 5;
            this.comboBoxSymNaming.SelectedIndexChanged += new System.EventHandler(this.comboBoxSymNaming_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "File Naming:";
            // 
            // textBoxSymDirectory
            // 
            this.textBoxSymDirectory.Location = new System.Drawing.Point(156, 47);
            this.textBoxSymDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSymDirectory.Name = "textBoxSymDirectory";
            this.textBoxSymDirectory.Size = new System.Drawing.Size(192, 22);
            this.textBoxSymDirectory.TabIndex = 3;
            this.textBoxSymDirectory.Text = "./sym";
            this.textBoxSymDirectory.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Output Directory:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxContiguousBlockOutput);
            this.groupBox1.Controls.Add(this.numericUpDownObjFill);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxObjManualFilename);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxObjNaming);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxObjDirectory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxObjFormat);
            this.groupBox1.Location = new System.Drawing.Point(385, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(367, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object File Options:";
            // 
            // checkBoxContiguousBlockOutput
            // 
            this.checkBoxContiguousBlockOutput.AutoSize = true;
            this.checkBoxContiguousBlockOutput.Location = new System.Drawing.Point(24, 194);
            this.checkBoxContiguousBlockOutput.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxContiguousBlockOutput.Name = "checkBoxContiguousBlockOutput";
            this.checkBoxContiguousBlockOutput.Size = new System.Drawing.Size(186, 21);
            this.checkBoxContiguousBlockOutput.TabIndex = 15;
            this.checkBoxContiguousBlockOutput.Text = "Contiguous Block Output";
            this.checkBoxContiguousBlockOutput.UseVisualStyleBackColor = true;
            // 
            // numericUpDownObjFill
            // 
            this.numericUpDownObjFill.Hexadecimal = true;
            this.numericUpDownObjFill.Location = new System.Drawing.Point(159, 162);
            this.numericUpDownObjFill.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownObjFill.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownObjFill.Name = "numericUpDownObjFill";
            this.numericUpDownObjFill.Size = new System.Drawing.Size(77, 22);
            this.numericUpDownObjFill.TabIndex = 9;
            this.numericUpDownObjFill.ValueChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 165);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Fill Value:";
            // 
            // textBoxObjManualFilename
            // 
            this.textBoxObjManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxObjManualFilename.Enabled = false;
            this.textBoxObjManualFilename.Location = new System.Drawing.Point(160, 127);
            this.textBoxObjManualFilename.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxObjManualFilename.Name = "textBoxObjManualFilename";
            this.textBoxObjManualFilename.Size = new System.Drawing.Size(192, 22);
            this.textBoxObjManualFilename.TabIndex = 7;
            this.textBoxObjManualFilename.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manual Filename:";
            // 
            // comboBoxObjNaming
            // 
            this.comboBoxObjNaming.FormattingEnabled = true;
            this.comboBoxObjNaming.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.comboBoxObjNaming.Location = new System.Drawing.Point(160, 94);
            this.comboBoxObjNaming.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxObjNaming.Name = "comboBoxObjNaming";
            this.comboBoxObjNaming.Size = new System.Drawing.Size(192, 24);
            this.comboBoxObjNaming.TabIndex = 5;
            this.comboBoxObjNaming.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjNaming_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Naming:";
            // 
            // textBoxObjDirectory
            // 
            this.textBoxObjDirectory.Location = new System.Drawing.Point(160, 59);
            this.textBoxObjDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxObjDirectory.Name = "textBoxObjDirectory";
            this.textBoxObjDirectory.Size = new System.Drawing.Size(192, 22);
            this.textBoxObjDirectory.TabIndex = 3;
            this.textBoxObjDirectory.Text = "./obj";
            this.textBoxObjDirectory.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output Format:";
            // 
            // comboBoxObjFormat
            // 
            this.comboBoxObjFormat.FormattingEnabled = true;
            this.comboBoxObjFormat.Items.AddRange(new object[] {
            "Intel Hex (-g0)",
            "MOS Technology Hex (-g1)",
            "Motorola Hex (-g2)",
            "Binary (-g3)",
            "Intel Hex with Word Addresses (-g4)"});
            this.comboBoxObjFormat.Location = new System.Drawing.Point(160, 25);
            this.comboBoxObjFormat.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxObjFormat.Name = "comboBoxObjFormat";
            this.comboBoxObjFormat.Size = new System.Drawing.Size(192, 24);
            this.comboBoxObjFormat.TabIndex = 0;
            this.comboBoxObjFormat.SelectedIndexChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControlCompileOutput);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(769, 546);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compile Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControlCompileOutput
            // 
            this.tabControlCompileOutput.Controls.Add(this.tabPageCompileOutputFormatted);
            this.tabControlCompileOutput.Controls.Add(this.tabPageCompileOutputRaw);
            this.tabControlCompileOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCompileOutput.Location = new System.Drawing.Point(0, 0);
            this.tabControlCompileOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlCompileOutput.Name = "tabControlCompileOutput";
            this.tabControlCompileOutput.SelectedIndex = 0;
            this.tabControlCompileOutput.Size = new System.Drawing.Size(769, 546);
            this.tabControlCompileOutput.TabIndex = 0;
            // 
            // tabPageCompileOutputFormatted
            // 
            this.tabPageCompileOutputFormatted.Controls.Add(this.objectListViewCompileFormatted);
            this.tabPageCompileOutputFormatted.Controls.Add(this.toolStrip3);
            this.tabPageCompileOutputFormatted.Location = new System.Drawing.Point(4, 25);
            this.tabPageCompileOutputFormatted.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCompileOutputFormatted.Name = "tabPageCompileOutputFormatted";
            this.tabPageCompileOutputFormatted.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCompileOutputFormatted.Size = new System.Drawing.Size(761, 517);
            this.tabPageCompileOutputFormatted.TabIndex = 1;
            this.tabPageCompileOutputFormatted.Text = "Formatted";
            this.tabPageCompileOutputFormatted.UseVisualStyleBackColor = true;
            // 
            // objectListViewCompileFormatted
            // 
            this.objectListViewCompileFormatted.AllColumns.Add(this.olvCompileItemColumnImage);
            this.objectListViewCompileFormatted.AllColumns.Add(this.olvColumnDescription);
            this.objectListViewCompileFormatted.AllColumns.Add(this.olvColumnFile);
            this.objectListViewCompileFormatted.AllColumns.Add(this.olvColumnLine);
            this.objectListViewCompileFormatted.CellEditUseWholeCell = false;
            this.objectListViewCompileFormatted.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvCompileItemColumnImage,
            this.olvColumnDescription,
            this.olvColumnFile,
            this.olvColumnLine});
            this.objectListViewCompileFormatted.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewCompileFormatted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewCompileFormatted.FullRowSelect = true;
            this.objectListViewCompileFormatted.HasCollapsibleGroups = false;
            this.objectListViewCompileFormatted.HideSelection = false;
            this.objectListViewCompileFormatted.Location = new System.Drawing.Point(4, 29);
            this.objectListViewCompileFormatted.Margin = new System.Windows.Forms.Padding(4);
            this.objectListViewCompileFormatted.MultiSelect = false;
            this.objectListViewCompileFormatted.Name = "objectListViewCompileFormatted";
            this.objectListViewCompileFormatted.ShowGroups = false;
            this.objectListViewCompileFormatted.Size = new System.Drawing.Size(753, 484);
            this.objectListViewCompileFormatted.SmallImageList = this.imageListCompileOutputs;
            this.objectListViewCompileFormatted.TabIndex = 1;
            this.objectListViewCompileFormatted.UseCompatibleStateImageBehavior = false;
            this.objectListViewCompileFormatted.View = System.Windows.Forms.View.Details;
            this.objectListViewCompileFormatted.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.objectListViewCompileFormatted_CellToolTipShowing);
            this.objectListViewCompileFormatted.SelectedIndexChanged += new System.EventHandler(this.objectListViewCompileFormatted_SelectedIndexChanged);
            this.objectListViewCompileFormatted.DoubleClick += new System.EventHandler(this.objectListViewCompileFormatted_DoubleClick);
            // 
            // olvCompileItemColumnImage
            // 
            this.olvCompileItemColumnImage.AspectName = "CompileOutputTypeAsInt";
            this.olvCompileItemColumnImage.Text = "";
            this.olvCompileItemColumnImage.Width = 22;
            // 
            // olvColumnDescription
            // 
            this.olvColumnDescription.AspectName = "Description";
            this.olvColumnDescription.FillsFreeSpace = true;
            this.olvColumnDescription.Groupable = false;
            this.olvColumnDescription.Text = "Description";
            this.olvColumnDescription.Width = 328;
            // 
            // olvColumnFile
            // 
            this.olvColumnFile.AspectName = "FileName";
            this.olvColumnFile.Text = "File";
            this.olvColumnFile.Width = 99;
            // 
            // olvColumnLine
            // 
            this.olvColumnLine.AspectName = "LineNumber";
            this.olvColumnLine.Text = "Line";
            // 
            // imageListCompileOutputs
            // 
            this.imageListCompileOutputs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCompileOutputs.ImageStream")));
            this.imageListCompileOutputs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCompileOutputs.Images.SetKeyName(0, "109_AllAnnotations_Help_16x16_72.png");
            this.imageListCompileOutputs.Images.SetKeyName(1, "WarningHS.png");
            this.imageListCompileOutputs.Images.SetKeyName(2, "error.png");
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Location = new System.Drawing.Point(4, 4);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(753, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tabPageCompileOutputRaw
            // 
            this.tabPageCompileOutputRaw.Controls.Add(this.textBoxCompileOutputRaw);
            this.tabPageCompileOutputRaw.Location = new System.Drawing.Point(4, 25);
            this.tabPageCompileOutputRaw.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCompileOutputRaw.Name = "tabPageCompileOutputRaw";
            this.tabPageCompileOutputRaw.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCompileOutputRaw.Size = new System.Drawing.Size(761, 517);
            this.tabPageCompileOutputRaw.TabIndex = 0;
            this.tabPageCompileOutputRaw.Text = "Raw";
            this.tabPageCompileOutputRaw.UseVisualStyleBackColor = true;
            // 
            // textBoxCompileOutputRaw
            // 
            this.textBoxCompileOutputRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCompileOutputRaw.Location = new System.Drawing.Point(4, 4);
            this.textBoxCompileOutputRaw.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCompileOutputRaw.Multiline = true;
            this.textBoxCompileOutputRaw.Name = "textBoxCompileOutputRaw";
            this.textBoxCompileOutputRaw.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCompileOutputRaw.Size = new System.Drawing.Size(753, 509);
            this.textBoxCompileOutputRaw.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonBuild,
            this.toolStripButtonRun,
            this.toolStripComboBoxBuild});
            this.toolStrip2.Location = new System.Drawing.Point(0, 28);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(777, 28);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonNew.Text = "Create New TASM Project";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonOpen.Text = "Open TASM Project";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonSave.Text = "Save Project";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonBuild
            // 
            this.toolStripButtonBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBuild.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBuild.Image")));
            this.toolStripButtonBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBuild.Name = "toolStripButtonBuild";
            this.toolStripButtonBuild.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonBuild.Text = "Build Current Project";
            this.toolStripButtonBuild.Click += new System.EventHandler(this.toolStripButtonBuild_Click);
            // 
            // toolStripButtonRun
            // 
            this.toolStripButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRun.Image")));
            this.toolStripButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRun.Name = "toolStripButtonRun";
            this.toolStripButtonRun.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonRun.Text = "Run Current Project";
            this.toolStripButtonRun.Click += new System.EventHandler(this.toolStripButtonRun_Click);
            // 
            // toolStripComboBoxBuild
            // 
            this.toolStripComboBoxBuild.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxBuild.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStripComboBoxBuild.Items.AddRange(new object[] {
            "Debug",
            "Release"});
            this.toolStripComboBoxBuild.Name = "toolStripComboBoxBuild";
            this.toolStripComboBoxBuild.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBoxBuild.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxBuild_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(777, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(757, 20);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Ready...";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(777, 28);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.recentProjectsToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // recentProjectsToolStripMenuItem
            // 
            this.recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
            this.recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.recentProjectsToolStripMenuItem.Text = "Recent Projects..";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(188, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem,
            this.runToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.buildToolStripMenuItem.Text = "Build";
            this.buildToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 133);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 17);
            this.label20.TabIndex = 7;
            this.label20.Text = "Run (Release):";
            // 
            // textBoxRunReleaseCommand
            // 
            this.textBoxRunReleaseCommand.Location = new System.Drawing.Point(118, 129);
            this.textBoxRunReleaseCommand.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRunReleaseCommand.Name = "textBoxRunReleaseCommand";
            this.textBoxRunReleaseCommand.Size = new System.Drawing.Size(239, 22);
            this.textBoxRunReleaseCommand.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 656);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TASM-IDE - New Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewFiles)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjFill)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControlCompileOutput.ResumeLayout(false);
            this.tabPageCompileOutputFormatted.ResumeLayout(false);
            this.tabPageCompileOutputFormatted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCompileFormatted)).EndInit();
            this.tabPageCompileOutputRaw.ResumeLayout(false);
            this.tabPageCompileOutputRaw.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddProjectFile;
        private BrightIdeasSoftware.ObjectListView objectListViewFiles;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRun;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveProjectFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox checkBoxTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxObjManualFilename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxObjNaming;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxObjDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxObjFormat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSymManualFilename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSymNaming;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSymDirectory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxExpManualFilename;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxExpNaming;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxExpDirectory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxLstManualFilename;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxLstNaming;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxLstDirectory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxRunDebugCommand;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripButton toolStripButtonBuild;
        private System.Windows.Forms.TabControl tabControlCompileOutput;
        private System.Windows.Forms.TabPage tabPageCompileOutputRaw;
        private System.Windows.Forms.TextBox textBoxCompileOutputRaw;
        private System.Windows.Forms.TabPage tabPageCompileOutputFormatted;
        private BrightIdeasSoftware.ObjectListView objectListViewCompileFormatted;
        private BrightIdeasSoftware.OLVColumn olvCompileItemColumnImage;
        private BrightIdeasSoftware.OLVColumn olvColumnDescription;
        private BrightIdeasSoftware.OLVColumn olvColumnFile;
        private BrightIdeasSoftware.OLVColumn olvColumnLine;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.NumericUpDown numericUpDownObjFill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxLstEnable;
        private System.Windows.Forms.CheckBox checkBoxExpEnable;
        private System.Windows.Forms.CheckBox checkBoxSymEnable;
        private System.Windows.Forms.ImageList imageListCompileOutputs;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TextBox textBoxPostBuildCommand;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPreBuildCommand;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveUp;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveDown;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.CheckBox checkBoxExpandSource;
        private System.Windows.Forms.CheckBox checkBoxIgnoreCase;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxCompilerTableParameter;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxTASMExecutable;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBoxContiguousBlockOutput;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxBuild;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxRunReleaseCommand;
    }
}

