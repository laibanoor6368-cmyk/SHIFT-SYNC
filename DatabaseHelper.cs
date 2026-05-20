using System;
using System.Data.SQLite;

namespace Shift_Sync
{
    public static class DatabaseHelper
    {
        // 1. Aapka hamesha ka database path
        private static string dbPath = @"D:\ShiftSyncDB.db";

        public static SQLiteConnection GetConnection()
        {
            string connectionString = $"Data Source={dbPath};Version=3;New = true;Compress=True ;JournalMode=Wal;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            try
            {
                connection.Open();

                // 🔥 FIXED: 'kills' ko badal kar 'Skills' kar diya hai taake teeno forms ka pop-up khatam ho jaye!
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

                // Shifts table (Assign Shift aur Swap Form dono ke liye bilkul perfect)
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

                // 3. Default manager account logic (Fixed with Skills column)
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

        public static void CreateShiftsTableIfMissing()
        {
            try
            {
                using (SQLiteConnection conn = GetConnection())
                {
                    string query = @"CREATE TABLE IF NOT EXISTS Shifts (
                                ShiftID INTEGER PRIMARY KEY AUTOINCREMENT,
                                EmployeeName TEXT NOT NULL,
                                ShiftType TEXT NOT NULL,
                                ShiftDate TEXT NOT NULL,
                                Status TEXT NOT NULL);";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Table Creation Error: " + ex.Message);
            }
        }
    }
}