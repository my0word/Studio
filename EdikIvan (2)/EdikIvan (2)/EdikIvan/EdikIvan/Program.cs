using System.Data.SQLite;

namespace EdikIvan
{
    internal static class Program
    {
        public static SQLiteConnection DB = new SQLiteConnection(Database.connection);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LogForm());
        }
    }
    class Database
    {
        public static string connection = @"Data source = database.db";
    }
}