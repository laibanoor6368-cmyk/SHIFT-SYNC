using System;
using System.Data.SQLite;
using System.IO;

namespace Shift_Sync
{
    public static class DatabaseHelper
    {
        // Wapas D: drive — purana database
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MYSHIFTSYNC.db");//@"D:\ShiftSyncDB.db";

        public static string ConnectionString =
            $"Data Source={dbPath};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            try
            {
                connection.Open();

                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS users (
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL,
                        Skills TEXT,   
                        Hours INTEGER
                    );";
                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                string createShiftsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Shifts (
                        ShiftID INTEGER PRIMARY KEY AUTOINCREMENT,
                        EmployeeName TEXT NOT NULL,
                        ShiftType TEXT NOT NULL,
                        ShiftDate TEXT NOT NULL,
                        Status TEXT NOT NULL
                    );";
                using (SQLiteCommand cmd = new SQLiteCommand(createShiftsTableQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                string checkManagerQuery = "SELECT COUNT(*) FROM users WHERE Username = 'manager'";
                long count = 0;
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkManagerQuery, connection))
                {
                    count = Convert.ToInt64(checkCmd.ExecuteScalar());
                }

                if (count == 0)
                {
                    string insertManagerQuery = "INSERT INTO users (Username, Password, Role, Skills, Hours) " +
                                               "VALUES ('manager', 'manager123', 'Manager', 'Admin', 0)";
                    using (SQLiteCommand insertCmd = new SQLiteCommand(insertManagerQuery, connection))
                    {
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB Setup Error: " + ex.Message);
            }
            return connection;
        }
    }
}