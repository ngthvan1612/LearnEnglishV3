using LearnEnglish.App.GUI;
using LearnEnglish.Infrastructure.DataAccess;
using System;

namespace LearnEnglish
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            new EnglishDbContext();
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}