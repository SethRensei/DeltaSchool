using System;
using System.Windows.Forms;

using DeltaSchool.Forms;

namespace DeltaSchool
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm main = new MainForm();
            Application.Run(main);
        }
    }
}
