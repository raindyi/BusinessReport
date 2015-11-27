using System;
using System.Windows.Forms;
using PV.BusinessReport.UI.Forms;
using log4net.Config;
using PV.BusinessReport.Core.Lib;

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
            ValidationAction action=new ValidationAction();
            if (action.ValidateLiceity().Successed)
            {
                Application.Run(new LoginForm());
                Application.ApplicationExit += Application_ApplicationExit;
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show("软件未通过验证,请联系软件供应商");
                Application.Exit();
            }
        }
        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
