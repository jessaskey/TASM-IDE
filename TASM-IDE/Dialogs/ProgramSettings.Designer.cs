namespace TASM_IDE.Dialogs
{
    partial class ProgramSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEditorExecutable = new System.Windows.Forms.TextBox();
            this.buttonBrowseEditorExecutable = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editor Executable:";
            // 
            // textBoxEditorExecutable
            // 
            this.textBoxEditorExecutable.Location = new System.Drawing.Point(151, 21);
            this.textBoxEditorExecutable.Name = "textBoxEditorExecutable";
            this.textBoxEditorExecutable.Size = new System.Drawing.Size(415, 22);
            this.textBoxEditorExecutable.TabIndex = 1;
            // 
            // buttonBrowseEditorExecutable
            // 
            this.buttonBrowseEditorExecutable.Location = new System.Drawing.Point(569, 21);
            this.buttonBrowseEditorExecutable.Name = "buttonBrowseEditorExecutable";
            this.buttonBrowseEditorExecutable.Size = new System.Drawing.Size(30, 23);
            this.buttonBrowseEditorExecutable.TabIndex = 2;
            this.buttonBrowseEditorExecutable.Text = "...";
            this.buttonBrowseEditorExecutable.UseVisualStyleBackColor = true;
            this.buttonBrowseEditorExecutable.Click += new System.EventHandler(this.buttonBrowseEditorExecutable_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(412, 63);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(493, 63);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ProgramSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 106);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonBrowseEditorExecutable);
            this.Controls.Add(this.textBoxEditorExecutable);
            this.Controls.Add(this.label1);
            this.Name = "ProgramSettings";
            this.Text = "ProgramSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEditorExecutable;
        private System.Windows.Forms.Button buttonBrowseEditorExecutable;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}