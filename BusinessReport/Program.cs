using System;
using System.Windows.Forms;
using PV.BusinessReport.UI.Forms;
using log4net.Config;

namespace BusinessReport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            BasicConfigurator.Configure();
            Application.Run(new MainForm());
        }
    }
}
