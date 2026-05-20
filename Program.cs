using System;
using System.Windows.Forms;
using System.Data.SQLite; // 🔥 Yeh line upar lazmi add karein

namespace Shift_Sync
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 🔥 FORCED TABLE CREATION: Yeh bina data delete kiye table har haal mein bana dega
            try
            {
                string dbPath = @"D:\ShiftSyncDB.db";
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    string query = @"CREATE TABLE IF NOT EXISTS Shifts (
                                        ShiftID INTEGER PRIMARY KEY AUTOINCREMENT,
                                        EmployeeName TEXT NOT NULL,
                                        ShiftType TEXT NOT NULL,
                                        ShiftDate TEXT NOT NULL,
                                        Status TEXT NOT NULL
                                     );";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Agar pehle se ban gaya hoga to chup rahega
            }

            // Aapka login form yahan se shuru hoga
            Application.Run(new LoginForm());
        }
    }
}