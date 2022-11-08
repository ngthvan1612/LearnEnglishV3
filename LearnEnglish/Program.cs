using LearnEnglish.App.GUI;
using LearnEnglish.Infrastructure.DataAccess;
using LearnEnglish.Infrastructure.DataAccess.EF.SqlServer;
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
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}