using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees_Management_System.UI;

namespace Employees_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///
        private static string server = "localhost";
        private static string database = "employees";
        private static string username = "root";
        private static string password = "1234567890";

        public static string GetConnectionString()
        {
            // Construct and return the connection string
            return $"server={server};database={database};uid={username};password={password};";
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Register());
        }
    }
}
