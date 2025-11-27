using System;
using System.Windows.Forms;

namespace FINALSSS
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

            using (LogIn login = new LogIn())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Main());
                }
            }
        }
    }
}
