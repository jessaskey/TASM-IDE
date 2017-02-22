using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASM_IDE.Dialogs
{
    public partial class ProgramSettings : Form
    {
        public string EditorExecutable
        {
            get
            {
                return textBoxEditorExecutable.Text;
            }
            set
            {
                textBoxEditorExecutable.Text = value;
            }
        }

        public ProgramSettings()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBrowseEditorExecutable_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;

            DialogResult dr = od.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBoxEditorExecutable.Text = od.FileName;
            }
        }
    }
}
