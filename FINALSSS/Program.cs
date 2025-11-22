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

            using (UserLogIn login = new UserLogIn())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Main());
                }
            }
        }
    }
}
