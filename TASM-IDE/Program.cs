using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASM_IDE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //arg passing for clickonce is a little different, we need to look for args in both
            //the normal args parameter above in Main, plus the ClickOnce path..
            List<string> passedArgs = new List<string>();
            if (args != null) passedArgs.AddRange(args);
            if (AppDomain.CurrentDomain != null && AppDomain.CurrentDomain.SetupInformation != null && AppDomain.CurrentDomain.SetupInformation.ActivationArguments != null && AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData != null)
            {
                //seems that these are URI's, need to take off the 'file:///' prefix
                passedArgs.AddRange(AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData.Select(a => a.Replace("file:///", "")));
            }

            FormMain formMain = new FormMain();
            if (passedArgs.Count > 0)
            {
                formMain.OpenArgs = passedArgs[0];
            }
            Application.Run(formMain);
        }
    }
}
