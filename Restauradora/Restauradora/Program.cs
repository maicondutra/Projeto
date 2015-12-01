using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauradora
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
            Login FLogin = new Login();

            while (!FLogin.logado)
            {
                FLogin.ShowDialog();
            }

            if (FLogin.logado)
            {
                Application.Run(new Restauradora());
            }   
        }
    }
}
