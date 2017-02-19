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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddProjectFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveProjectFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMoveUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveDown = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxPostBuildCommand = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPreBuildCommand = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxRunCommand = new System.Windows.Forms.TextBox();
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
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBuild = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRun = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.checkBoxExpandSource = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnoreCase = new System.Windows.Forms.CheckBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabControlMain.Location = new System.Drawing.Point(0, 49);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(583, 421);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.objectListViewFiles);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 372);
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
            this.objectListViewFiles.Location = new System.Drawing.Point(3, 28);
            this.objectListViewFiles.Name = "objectListViewFiles";
            this.objectListViewFiles.ShowGroups = false;
            this.objectListViewFiles.Size = new System.Drawing.Size(569, 341);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddProjectFile,
            this.toolStripButtonRemoveProjectFile,
            this.toolStripSeparator2,
            this.toolStripButtonMoveUp,
            this.toolStripButtonMoveDown});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(569, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddProjectFile
            // 
            this.toolStripButtonAddProjectFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddProjectFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddProjectFile.Image")));
            this.toolStripButtonAddProjectFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddProjectFile.Name = "toolStripButtonAddProjectFile";
            this.toolStripButtonAddProjectFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddProjectFile.Text = "Add File";
            this.toolStripButtonAddProjectFile.Click += new System.EventHandler(this.toolStripButtonAddProjectFile_Click);
            // 
            // toolStripButtonRemoveProjectFile
            // 
            this.toolStripButtonRemoveProjectFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveProjectFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveProjectFile.Image")));
            this.toolStripButtonRemoveProjectFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveProjectFile.Name = "toolStripButtonRemoveProjectFile";
            this.toolStripButtonRemoveProjectFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRemoveProjectFile.Text = "Remove Selected File";
            this.toolStripButtonRemoveProjectFile.Click += new System.EventHandler(this.toolStripButtonRemoveProjectFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonMoveUp
            // 
            this.toolStripButtonMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveUp.Image")));
            this.toolStripButtonMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveUp.Name = "toolStripButtonMoveUp";
            this.toolStripButtonMoveUp.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveUp.Text = "Move Selected File Up";
            this.toolStripButtonMoveUp.Click += new System.EventHandler(this.toolStripButtonMoveUp_Click);
            // 
            // toolStripButtonMoveDown
            // 
            this.toolStripButtonMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveDown.Image")));
            this.toolStripButtonMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveDown.Name = "toolStripButtonMoveDown";
            this.toolStripButtonMoveDown.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveDown.Text = "Move Selected File Down";
            this.toolStripButtonMoveDown.Click += new System.EventHandler(this.toolStripButtonMoveDown_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxIgnoreCase);
            this.tabPage2.Controls.Add(this.checkBoxExpandSource);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.checkBoxTimer);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compile Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxPostBuildCommand);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.textBoxPreBuildCommand);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.textBoxRunCommand);
            this.groupBox5.Location = new System.Drawing.Point(289, 198);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(275, 109);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Other Processing:";
            // 
            // textBoxPostBuildCommand
            // 
            this.textBoxPostBuildCommand.Location = new System.Drawing.Point(75, 51);
            this.textBoxPostBuildCommand.Name = "textBoxPostBuildCommand";
            this.textBoxPostBuildCommand.Size = new System.Drawing.Size(194, 20);
            this.textBoxPostBuildCommand.TabIndex = 5;
            this.textBoxPostBuildCommand.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Run:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Post-Build:";
            // 
            // textBoxPreBuildCommand
            // 
            this.textBoxPreBuildCommand.Location = new System.Drawing.Point(75, 24);
            this.textBoxPreBuildCommand.Name = "textBoxPreBuildCommand";
            this.textBoxPreBuildCommand.Size = new System.Drawing.Size(194, 20);
            this.textBoxPreBuildCommand.TabIndex = 2;
            this.textBoxPreBuildCommand.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            this.textBoxPreBuildCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPreBuildCommand_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Pre-Build:";
            // 
            // textBoxRunCommand
            // 
            this.textBoxRunCommand.Location = new System.Drawing.Point(75, 78);
            this.textBoxRunCommand.Name = "textBoxRunCommand";
            this.textBoxRunCommand.Size = new System.Drawing.Size(194, 20);
            this.textBoxRunCommand.TabIndex = 0;
            this.textBoxRunCommand.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
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
            this.groupBox2.Location = new System.Drawing.Point(8, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 121);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listing File Options:";
            // 
            // checkBoxLstEnable
            // 
            this.checkBoxLstEnable.AutoSize = true;
            this.checkBoxLstEnable.Checked = true;
            this.checkBoxLstEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLstEnable.Location = new System.Drawing.Point(111, 15);
            this.checkBoxLstEnable.Name = "checkBoxLstEnable";
            this.checkBoxLstEnable.Size = new System.Drawing.Size(111, 17);
            this.checkBoxLstEnable.TabIndex = 10;
            this.checkBoxLstEnable.Text = "Enable Listing File";
            this.checkBoxLstEnable.UseVisualStyleBackColor = true;
            this.checkBoxLstEnable.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // textBoxLstManualFilename
            // 
            this.textBoxLstManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxLstManualFilename.Enabled = false;
            this.textBoxLstManualFilename.Location = new System.Drawing.Point(111, 92);
            this.textBoxLstManualFilename.Name = "textBoxLstManualFilename";
            this.textBoxLstManualFilename.Size = new System.Drawing.Size(145, 20);
            this.textBoxLstManualFilename.TabIndex = 7;
            this.textBoxLstManualFilename.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Manual Filename:";
            // 
            // comboBoxLstNaming
            // 
            this.comboBoxLstNaming.FormattingEnabled = true;
            this.comboBoxLstNaming.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.comboBoxLstNaming.Location = new System.Drawing.Point(111, 65);
            this.comboBoxLstNaming.Name = "comboBoxLstNaming";
            this.comboBoxLstNaming.Size = new System.Drawing.Size(145, 21);
            this.comboBoxLstNaming.TabIndex = 5;
            this.comboBoxLstNaming.SelectedIndexChanged += new System.EventHandler(this.comboBoxLstNaming_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "File Naming:";
            // 
            // textBoxLstDirectory
            // 
            this.textBoxLstDirectory.Location = new System.Drawing.Point(111, 38);
            this.textBoxLstDirectory.Name = "textBoxLstDirectory";
            this.textBoxLstDirectory.Size = new System.Drawing.Size(145, 20);
            this.textBoxLstDirectory.TabIndex = 3;
            this.textBoxLstDirectory.Text = "./lst";
            this.textBoxLstDirectory.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Output Directory:";
            // 
            // checkBoxTimer
            // 
            this.checkBoxTimer.AutoSize = true;
            this.checkBoxTimer.Location = new System.Drawing.Point(304, 313);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(123, 17);
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
            this.groupBox4.Location = new System.Drawing.Point(8, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 122);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Export File Options:";
            // 
            // checkBoxExpEnable
            // 
            this.checkBoxExpEnable.AutoSize = true;
            this.checkBoxExpEnable.Checked = true;
            this.checkBoxExpEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExpEnable.Location = new System.Drawing.Point(111, 15);
            this.checkBoxExpEnable.Name = "checkBoxExpEnable";
            this.checkBoxExpEnable.Size = new System.Drawing.Size(111, 17);
            this.checkBoxExpEnable.TabIndex = 8;
            this.checkBoxExpEnable.Text = "Enable Export File";
            this.checkBoxExpEnable.UseVisualStyleBackColor = true;
            this.checkBoxExpEnable.CheckedChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // textBoxExpManualFilename
            // 
            this.textBoxExpManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxExpManualFilename.Enabled = false;
            this.textBoxExpManualFilename.Location = new System.Drawing.Point(111, 92);
            this.textBoxExpManualFilename.Name = "textBoxExpManualFilename";
            this.textBoxExpManualFilename.Size = new System.Drawing.Size(145, 20);
            this.textBoxExpManualFilename.TabIndex = 7;
            this.textBoxExpManualFilename.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Manual Filename:";
            // 
            // comboBoxExpNaming
            // 
            this.comboBoxExpNaming.FormattingEnabled = true;
            this.comboBoxExpNaming.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.comboBoxExpNaming.Location = new System.Drawing.Point(111, 65);
            this.comboBoxExpNaming.Name = "comboBoxExpNaming";
            this.comboBoxExpNaming.Size = new System.Drawing.Size(145, 21);
            this.comboBoxExpNaming.TabIndex = 5;
            this.comboBoxExpNaming.SelectedIndexChanged += new System.EventHandler(this.comboBoxExpNaming_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "File Naming:";
            // 
            // textBoxExpDirectory
            // 
            this.textBoxExpDirectory.Location = new System.Drawing.Point(111, 38);
            this.textBoxExpDirectory.Name = "textBoxExpDirectory";
            this.textBoxExpDirectory.Size = new System.Drawing.Size(145, 20);
            this.textBoxExpDirectory.TabIndex = 3;
            this.textBoxExpDirectory.Text = "./exp";
            this.textBoxExpDirectory.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
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
            this.groupBox3.Location = new System.Drawing.Point(8, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 121);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symbol File Options:";
            // 
            // checkBoxSymEnable
            // 
            this.checkBoxSymEnable.AutoSize = true;
            this.checkBoxSymEnable.Checked = true;
            this.checkBoxSymEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSymEnable.Location = new System.Drawing.Point(111, 15);
            this.checkBoxSymEnable.Name = "checkBoxSymEnable";
            this.checkBoxSymEnable.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSymEnable.TabIndex = 9;
            this.checkBoxSymEnable.Text = "Enable Symbol File";
            this.checkBoxSymEnable.UseVisualStyleBackColor = true;
            this.checkBoxSymEnable.CheckedChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // textBoxSymManualFilename
            // 
            this.textBoxSymManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxSymManualFilename.Enabled = false;
            this.textBoxSymManualFilename.Location = new System.Drawing.Point(111, 92);
            this.textBoxSymManualFilename.Name = "textBoxSymManualFilename";
            this.textBoxSymManualFilename.Size = new System.Drawing.Size(145, 20);
            this.textBoxSymManualFilename.TabIndex = 7;
            this.textBoxSymManualFilename.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manual Filename:";
            // 
            // comboBoxSymNaming
            // 
            this.comboBoxSymNaming.FormattingEnabled = true;
            this.comboBoxSymNaming.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.comboBoxSymNaming.Location = new System.Drawing.Point(111, 65);
            this.comboBoxSymNaming.Name = "comboBoxSymNaming";
            this.comboBoxSymNaming.Size = new System.Drawing.Size(145, 21);
            this.comboBoxSymNaming.TabIndex = 5;
            this.comboBoxSymNaming.SelectedIndexChanged += new System.EventHandler(this.comboBoxSymNaming_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "File Naming:";
            // 
            // textBoxSymDirectory
            // 
            this.textBoxSymDirectory.Location = new System.Drawing.Point(111, 38);
            this.textBoxSymDirectory.Name = "textBoxSymDirectory";
            this.textBoxSymDirectory.Size = new System.Drawing.Size(145, 20);
            this.textBoxSymDirectory.TabIndex = 3;
            this.textBoxSymDirectory.Text = "./sym";
            this.textBoxSymDirectory.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Output Directory:";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(289, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object File Options:";
            // 
            // numericUpDownObjFill
            // 
            this.numericUpDownObjFill.Hexadecimal = true;
            this.numericUpDownObjFill.Location = new System.Drawing.Point(111, 132);
            this.numericUpDownObjFill.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownObjFill.Name = "numericUpDownObjFill";
            this.numericUpDownObjFill.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownObjFill.TabIndex = 9;
            this.numericUpDownObjFill.ValueChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Fill Value:";
            // 
            // textBoxObjManualFilename
            // 
            this.textBoxObjManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxObjManualFilename.Enabled = false;
            this.textBoxObjManualFilename.Location = new System.Drawing.Point(112, 103);
            this.textBoxObjManualFilename.Name = "textBoxObjManualFilename";
            this.textBoxObjManualFilename.Size = new System.Drawing.Size(145, 20);
            this.textBoxObjManualFilename.TabIndex = 7;
            this.textBoxObjManualFilename.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manual Filename:";
            // 
            // comboBoxObjNaming
            // 
            this.comboBoxObjNaming.FormattingEnabled = true;
            this.comboBoxObjNaming.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.comboBoxObjNaming.Location = new System.Drawing.Point(112, 76);
            this.comboBoxObjNaming.Name = "comboBoxObjNaming";
            this.comboBoxObjNaming.Size = new System.Drawing.Size(145, 21);
            this.comboBoxObjNaming.TabIndex = 5;
            this.comboBoxObjNaming.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjNaming_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Naming:";
            // 
            // textBoxObjDirectory
            // 
            this.textBoxObjDirectory.Location = new System.Drawing.Point(112, 48);
            this.textBoxObjDirectory.Name = "textBoxObjDirectory";
            this.textBoxObjDirectory.Size = new System.Drawing.Size(145, 20);
            this.textBoxObjDirectory.TabIndex = 3;
            this.textBoxObjDirectory.Text = "./obj";
            this.textBoxObjDirectory.TextChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
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
            this.comboBoxObjFormat.Location = new System.Drawing.Point(112, 20);
            this.comboBoxObjFormat.Name = "comboBoxObjFormat";
            this.comboBoxObjFormat.Size = new System.Drawing.Size(145, 21);
            this.comboBoxObjFormat.TabIndex = 0;
            this.comboBoxObjFormat.SelectedIndexChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControlCompileOutput);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(575, 395);
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
            this.tabControlCompileOutput.Name = "tabControlCompileOutput";
            this.tabControlCompileOutput.SelectedIndex = 0;
            this.tabControlCompileOutput.Size = new System.Drawing.Size(575, 395);
            this.tabControlCompileOutput.TabIndex = 0;
            // 
            // tabPageCompileOutputFormatted
            // 
            this.tabPageCompileOutputFormatted.Controls.Add(this.objectListViewCompileFormatted);
            this.tabPageCompileOutputFormatted.Controls.Add(this.toolStrip3);
            this.tabPageCompileOutputFormatted.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompileOutputFormatted.Name = "tabPageCompileOutputFormatted";
            this.tabPageCompileOutputFormatted.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompileOutputFormatted.Size = new System.Drawing.Size(567, 369);
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
            this.objectListViewCompileFormatted.Location = new System.Drawing.Point(3, 28);
            this.objectListViewCompileFormatted.MultiSelect = false;
            this.objectListViewCompileFormatted.Name = "objectListViewCompileFormatted";
            this.objectListViewCompileFormatted.ShowGroups = false;
            this.objectListViewCompileFormatted.Size = new System.Drawing.Size(561, 338);
            this.objectListViewCompileFormatted.SmallImageList = this.imageListCompileOutputs;
            this.objectListViewCompileFormatted.TabIndex = 1;
            this.objectListViewCompileFormatted.UseCompatibleStateImageBehavior = false;
            this.objectListViewCompileFormatted.View = System.Windows.Forms.View.Details;
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
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(561, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tabPageCompileOutputRaw
            // 
            this.tabPageCompileOutputRaw.Controls.Add(this.textBoxCompileOutputRaw);
            this.tabPageCompileOutputRaw.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompileOutputRaw.Name = "tabPageCompileOutputRaw";
            this.tabPageCompileOutputRaw.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompileOutputRaw.Size = new System.Drawing.Size(703, 370);
            this.tabPageCompileOutputRaw.TabIndex = 0;
            this.tabPageCompileOutputRaw.Text = "Raw";
            this.tabPageCompileOutputRaw.UseVisualStyleBackColor = true;
            // 
            // textBoxCompileOutputRaw
            // 
            this.textBoxCompileOutputRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCompileOutputRaw.Location = new System.Drawing.Point(3, 3);
            this.textBoxCompileOutputRaw.Multiline = true;
            this.textBoxCompileOutputRaw.Name = "textBoxCompileOutputRaw";
            this.textBoxCompileOutputRaw.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCompileOutputRaw.Size = new System.Drawing.Size(697, 364);
            this.textBoxCompileOutputRaw.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonBuild,
            this.toolStripButtonRun});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(583, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "Open TASM Project";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "Create New TASM Project";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Save Project";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBuild
            // 
            this.toolStripButtonBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBuild.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBuild.Image")));
            this.toolStripButtonBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBuild.Name = "toolStripButtonBuild";
            this.toolStripButtonBuild.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBuild.Text = "Build Current Project";
            this.toolStripButtonBuild.Click += new System.EventHandler(this.toolStripButtonBuild_Click);
            // 
            // toolStripButtonRun
            // 
            this.toolStripButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRun.Image")));
            this.toolStripButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRun.Name = "toolStripButtonRun";
            this.toolStripButtonRun.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRun.Text = "Run Current Project";
            this.toolStripButtonRun.Click += new System.EventHandler(this.toolStripButtonRun_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(583, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(568, 17);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Ready...";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Args";
            this.olvColumn2.FillsFreeSpace = true;
            this.olvColumn2.Text = "Custom Arguments";
            this.olvColumn2.Width = 159;
            // 
            // checkBoxExpandSource
            // 
            this.checkBoxExpandSource.AutoSize = true;
            this.checkBoxExpandSource.Location = new System.Drawing.Point(304, 331);
            this.checkBoxExpandSource.Name = "checkBoxExpandSource";
            this.checkBoxExpandSource.Size = new System.Drawing.Size(176, 17);
            this.checkBoxExpandSource.TabIndex = 11;
            this.checkBoxExpandSource.Text = "Expand Macro Source in Listing";
            this.checkBoxExpandSource.UseVisualStyleBackColor = true;
            this.checkBoxExpandSource.CheckedChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // checkBoxIgnoreCase
            // 
            this.checkBoxIgnoreCase.AutoSize = true;
            this.checkBoxIgnoreCase.Location = new System.Drawing.Point(304, 350);
            this.checkBoxIgnoreCase.Name = "checkBoxIgnoreCase";
            this.checkBoxIgnoreCase.Size = new System.Drawing.Size(132, 17);
            this.checkBoxIgnoreCase.TabIndex = 12;
            this.checkBoxIgnoreCase.Text = "Ignore Case on Labels";
            this.checkBoxIgnoreCase.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreCase.CheckedChanged += new System.EventHandler(this.CompilationOptions_OnChanged);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(583, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // recentProjectsToolStripMenuItem
            // 
            this.recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
            this.recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.recentProjectsToolStripMenuItem.Text = "Recent Projects..";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem,
            this.runToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buildToolStripMenuItem.Text = "Build";
            this.buildToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 492);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TASM-IDE - New Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
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
        private System.Windows.Forms.TextBox textBoxRunCommand;
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
    }
}

