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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.objectListViewFiles = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddProjectFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveProjectFile = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLstManualFilename = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxLstNaming = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxLstDirectory = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxTimer = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxExpManualFilename = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxExpNaming = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxExpDirectory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSymManualFilename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSymNaming = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSymDirectory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxObjManualFilename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxObjNaming = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxObjDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxObjFormat = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRun = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStripButtonBuild = new System.Windows.Forms.ToolStripButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxRunCommand = new System.Windows.Forms.TextBox();
            this.tabControlCompileOutput = new System.Windows.Forms.TabControl();
            this.tabPageCompileOutputRaw = new System.Windows.Forms.TabPage();
            this.tabPageCompileOutputFormatted = new System.Windows.Forms.TabPage();
            this.textBoxCompileOutputRaw = new System.Windows.Forms.TextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.objectListViewCompileFormatted = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFile = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLine = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnImage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownObjFill = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewFiles)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControlCompileOutput.SuspendLayout();
            this.tabPageCompileOutputRaw.SuspendLayout();
            this.tabPageCompileOutputFormatted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCompileFormatted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjFill)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 330);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.objectListViewFiles);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Project Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // objectListViewFiles
            // 
            this.objectListViewFiles.AllColumns.Add(this.olvColumn1);
            this.objectListViewFiles.CellEditUseWholeCell = false;
            this.objectListViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1});
            this.objectListViewFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewFiles.FullRowSelect = true;
            this.objectListViewFiles.Location = new System.Drawing.Point(3, 28);
            this.objectListViewFiles.Name = "objectListViewFiles";
            this.objectListViewFiles.ShowGroups = false;
            this.objectListViewFiles.Size = new System.Drawing.Size(699, 273);
            this.objectListViewFiles.TabIndex = 1;
            this.objectListViewFiles.UseCompatibleStateImageBehavior = false;
            this.objectListViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Filename";
            this.olvColumn1.Text = "Filename";
            this.olvColumn1.Width = 238;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddProjectFile,
            this.toolStripButtonRemoveProjectFile});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(699, 25);
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
            this.toolStripButtonRemoveProjectFile.Text = "toolStripButton1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.checkBoxTimer);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(705, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compile Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxLstManualFilename);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBoxLstNaming);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxLstDirectory);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(289, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 108);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listing File Options:";
            // 
            // textBoxLstManualFilename
            // 
            this.textBoxLstManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxLstManualFilename.Enabled = false;
            this.textBoxLstManualFilename.Location = new System.Drawing.Point(111, 75);
            this.textBoxLstManualFilename.Name = "textBoxLstManualFilename";
            this.textBoxLstManualFilename.Size = new System.Drawing.Size(145, 20);
            this.textBoxLstManualFilename.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 78);
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
            this.comboBoxLstNaming.Location = new System.Drawing.Point(111, 48);
            this.comboBoxLstNaming.Name = "comboBoxLstNaming";
            this.comboBoxLstNaming.Size = new System.Drawing.Size(145, 21);
            this.comboBoxLstNaming.TabIndex = 5;
            this.comboBoxLstNaming.SelectedIndexChanged += new System.EventHandler(this.comboBoxLstNaming_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "File Naming:";
            // 
            // textBoxLstDirectory
            // 
            this.textBoxLstDirectory.Location = new System.Drawing.Point(111, 21);
            this.textBoxLstDirectory.Name = "textBoxLstDirectory";
            this.textBoxLstDirectory.Size = new System.Drawing.Size(145, 20);
            this.textBoxLstDirectory.TabIndex = 3;
            this.textBoxLstDirectory.Text = "./lst";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Output Directory:";
            // 
            // checkBoxTimer
            // 
            this.checkBoxTimer.AutoSize = true;
            this.checkBoxTimer.Location = new System.Drawing.Point(574, 36);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(123, 17);
            this.checkBoxTimer.TabIndex = 0;
            this.checkBoxTimer.Text = "Time each Assembly";
            this.checkBoxTimer.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxExpManualFilename);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.comboBoxExpNaming);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBoxExpDirectory);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(8, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 108);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Export File Options:";
            // 
            // textBoxExpManualFilename
            // 
            this.textBoxExpManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxExpManualFilename.Enabled = false;
            this.textBoxExpManualFilename.Location = new System.Drawing.Point(111, 75);
            this.textBoxExpManualFilename.Name = "textBoxExpManualFilename";
            this.textBoxExpManualFilename.Size = new System.Drawing.Size(145, 20);
            this.textBoxExpManualFilename.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 78);
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
            this.comboBoxExpNaming.Location = new System.Drawing.Point(111, 48);
            this.comboBoxExpNaming.Name = "comboBoxExpNaming";
            this.comboBoxExpNaming.Size = new System.Drawing.Size(145, 21);
            this.comboBoxExpNaming.TabIndex = 5;
            this.comboBoxExpNaming.SelectedIndexChanged += new System.EventHandler(this.comboBoxExpNaming_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "File Naming:";
            // 
            // textBoxExpDirectory
            // 
            this.textBoxExpDirectory.Location = new System.Drawing.Point(111, 21);
            this.textBoxExpDirectory.Name = "textBoxExpDirectory";
            this.textBoxExpDirectory.Size = new System.Drawing.Size(145, 20);
            this.textBoxExpDirectory.TabIndex = 3;
            this.textBoxExpDirectory.Text = "./exp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Output Directory:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSymManualFilename);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxSymNaming);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxSymDirectory);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(8, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 108);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symbol File Options:";
            // 
            // textBoxSymManualFilename
            // 
            this.textBoxSymManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxSymManualFilename.Enabled = false;
            this.textBoxSymManualFilename.Location = new System.Drawing.Point(111, 75);
            this.textBoxSymManualFilename.Name = "textBoxSymManualFilename";
            this.textBoxSymManualFilename.Size = new System.Drawing.Size(145, 20);
            this.textBoxSymManualFilename.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 78);
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
            this.comboBoxSymNaming.Location = new System.Drawing.Point(111, 48);
            this.comboBoxSymNaming.Name = "comboBoxSymNaming";
            this.comboBoxSymNaming.Size = new System.Drawing.Size(145, 21);
            this.comboBoxSymNaming.TabIndex = 5;
            this.comboBoxSymNaming.SelectedIndexChanged += new System.EventHandler(this.comboBoxSymNaming_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "File Naming:";
            // 
            // textBoxSymDirectory
            // 
            this.textBoxSymDirectory.Location = new System.Drawing.Point(111, 21);
            this.textBoxSymDirectory.Name = "textBoxSymDirectory";
            this.textBoxSymDirectory.Size = new System.Drawing.Size(145, 20);
            this.textBoxSymDirectory.TabIndex = 3;
            this.textBoxSymDirectory.Text = "./sym";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 24);
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
            this.groupBox1.Location = new System.Drawing.Point(289, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object File Options:";
            // 
            // textBoxObjManualFilename
            // 
            this.textBoxObjManualFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxObjManualFilename.Enabled = false;
            this.textBoxObjManualFilename.Location = new System.Drawing.Point(112, 103);
            this.textBoxObjManualFilename.Name = "textBoxObjManualFilename";
            this.textBoxObjManualFilename.Size = new System.Drawing.Size(145, 20);
            this.textBoxObjManualFilename.TabIndex = 7;
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
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonNew,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonBuild,
            this.toolStripButtonRun});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(713, 25);
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
            this.toolStripButtonOpen.Text = "toolStripButton2";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "toolStripButton3";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButton4";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRun
            // 
            this.toolStripButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRun.Image")));
            this.toolStripButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRun.Name = "toolStripButtonRun";
            this.toolStripButtonRun.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRun.Text = "toolStripButton2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(713, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControlCompileOutput);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(705, 304);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compile Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStripButtonBuild
            // 
            this.toolStripButtonBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBuild.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBuild.Image")));
            this.toolStripButtonBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBuild.Name = "toolStripButtonBuild";
            this.toolStripButtonBuild.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBuild.Text = "toolStripButton1";
            this.toolStripButtonBuild.Click += new System.EventHandler(this.toolStripButtonBuild_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxRunCommand);
            this.groupBox5.Location = new System.Drawing.Point(8, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(275, 46);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Run Command:";
            // 
            // textBoxRunCommand
            // 
            this.textBoxRunCommand.Location = new System.Drawing.Point(6, 20);
            this.textBoxRunCommand.Name = "textBoxRunCommand";
            this.textBoxRunCommand.Size = new System.Drawing.Size(263, 20);
            this.textBoxRunCommand.TabIndex = 0;
            // 
            // tabControlCompileOutput
            // 
            this.tabControlCompileOutput.Controls.Add(this.tabPageCompileOutputFormatted);
            this.tabControlCompileOutput.Controls.Add(this.tabPageCompileOutputRaw);
            this.tabControlCompileOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCompileOutput.Location = new System.Drawing.Point(0, 0);
            this.tabControlCompileOutput.Name = "tabControlCompileOutput";
            this.tabControlCompileOutput.SelectedIndex = 0;
            this.tabControlCompileOutput.Size = new System.Drawing.Size(705, 304);
            this.tabControlCompileOutput.TabIndex = 0;
            // 
            // tabPageCompileOutputRaw
            // 
            this.tabPageCompileOutputRaw.Controls.Add(this.textBoxCompileOutputRaw);
            this.tabPageCompileOutputRaw.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompileOutputRaw.Name = "tabPageCompileOutputRaw";
            this.tabPageCompileOutputRaw.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompileOutputRaw.Size = new System.Drawing.Size(697, 278);
            this.tabPageCompileOutputRaw.TabIndex = 0;
            this.tabPageCompileOutputRaw.Text = "Raw";
            this.tabPageCompileOutputRaw.UseVisualStyleBackColor = true;
            // 
            // tabPageCompileOutputFormatted
            // 
            this.tabPageCompileOutputFormatted.Controls.Add(this.objectListViewCompileFormatted);
            this.tabPageCompileOutputFormatted.Controls.Add(this.toolStrip3);
            this.tabPageCompileOutputFormatted.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompileOutputFormatted.Name = "tabPageCompileOutputFormatted";
            this.tabPageCompileOutputFormatted.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompileOutputFormatted.Size = new System.Drawing.Size(697, 278);
            this.tabPageCompileOutputFormatted.TabIndex = 1;
            this.tabPageCompileOutputFormatted.Text = "Formatted";
            this.tabPageCompileOutputFormatted.UseVisualStyleBackColor = true;
            // 
            // textBoxCompileOutputRaw
            // 
            this.textBoxCompileOutputRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCompileOutputRaw.Location = new System.Drawing.Point(3, 3);
            this.textBoxCompileOutputRaw.Multiline = true;
            this.textBoxCompileOutputRaw.Name = "textBoxCompileOutputRaw";
            this.textBoxCompileOutputRaw.Size = new System.Drawing.Size(691, 272);
            this.textBoxCompileOutputRaw.TabIndex = 0;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(691, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // objectListViewCompileFormatted
            // 
            this.objectListViewCompileFormatted.AllColumns.Add(this.olvColumnImage);
            this.objectListViewCompileFormatted.AllColumns.Add(this.olvColumnDescription);
            this.objectListViewCompileFormatted.AllColumns.Add(this.olvColumnFile);
            this.objectListViewCompileFormatted.AllColumns.Add(this.olvColumnLine);
            this.objectListViewCompileFormatted.CellEditUseWholeCell = false;
            this.objectListViewCompileFormatted.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnImage,
            this.olvColumnDescription,
            this.olvColumnFile,
            this.olvColumnLine});
            this.objectListViewCompileFormatted.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewCompileFormatted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewCompileFormatted.FullRowSelect = true;
            this.objectListViewCompileFormatted.HasCollapsibleGroups = false;
            this.objectListViewCompileFormatted.Location = new System.Drawing.Point(3, 28);
            this.objectListViewCompileFormatted.MultiSelect = false;
            this.objectListViewCompileFormatted.Name = "objectListViewCompileFormatted";
            this.objectListViewCompileFormatted.ShowGroups = false;
            this.objectListViewCompileFormatted.Size = new System.Drawing.Size(691, 247);
            this.objectListViewCompileFormatted.TabIndex = 1;
            this.objectListViewCompileFormatted.UseCompatibleStateImageBehavior = false;
            this.objectListViewCompileFormatted.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnDescription
            // 
            this.olvColumnDescription.FillsFreeSpace = true;
            this.olvColumnDescription.Groupable = false;
            this.olvColumnDescription.Text = "Description";
            this.olvColumnDescription.Width = 328;
            // 
            // olvColumnFile
            // 
            this.olvColumnFile.Text = "File";
            this.olvColumnFile.Width = 99;
            // 
            // olvColumnLine
            // 
            this.olvColumnLine.Text = "Line";
            // 
            // olvColumnImage
            // 
            this.olvColumnImage.Text = "";
            this.olvColumnImage.Width = 22;
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
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 377);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "FormMain";
            this.Text = "TASM-IDE - New Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewFiles)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControlCompileOutput.ResumeLayout(false);
            this.tabPageCompileOutputRaw.ResumeLayout(false);
            this.tabPageCompileOutputRaw.PerformLayout();
            this.tabPageCompileOutputFormatted.ResumeLayout(false);
            this.tabPageCompileOutputFormatted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCompileFormatted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjFill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
        private BrightIdeasSoftware.OLVColumn olvColumnImage;
        private BrightIdeasSoftware.OLVColumn olvColumnDescription;
        private BrightIdeasSoftware.OLVColumn olvColumnFile;
        private BrightIdeasSoftware.OLVColumn olvColumnLine;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.NumericUpDown numericUpDownObjFill;
        private System.Windows.Forms.Label label14;
    }
}

