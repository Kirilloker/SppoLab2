using SppoLab2.Script.Users;
using SppoLab2.WindowsForm;
using System;
using System.Windows.Forms;

namespace SppoLab2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
