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
    public partial class ConfigurationEditor : Form
    {
        public string Name 
        {
            get 
            {
                return textBoxName.Text;
            }
            set
            {
                textBoxName.Text = value;
            }
        }

        public string RunCommand
        {
            get
            {
                return textBoxRunCommand.Text;
            }
            set
            {
                textBoxRunCommand.Text = value;
            }
        }


        public ConfigurationEditor()
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
