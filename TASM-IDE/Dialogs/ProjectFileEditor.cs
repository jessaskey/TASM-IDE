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
    public partial class ProjectFileEditor : Form
    {
        public string FileName 
        {
            get 
            {
                return textBoxFilename.Text;
            }
            set
            {
                textBoxFilename.Text = value;
            }
        }

        public string Args
        {
            get
            {
                return textBoxArguments.Text;
            }
            set
            {
                textBoxArguments.Text = value;
            }
        }


        public ProjectFileEditor()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
