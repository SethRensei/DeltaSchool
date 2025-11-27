using System;
using System.Windows.Forms;

using DeltaSchool.Forms;
using DeltaSchool.Forms.Exam;

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
            //AddNoteF addNote = new AddNoteF(3, 1, "1er Trimestre");
            Application.Run(main);
        }
    }
}
