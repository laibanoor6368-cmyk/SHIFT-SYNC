using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Shift_Sync.DataAccess
{
    public class ShiftRepository
    {
        // Connection string ko yahan fix kar diya hai taake bar bar lock na ho
        private string connString = "Data Source=D:\\ShiftSyncDB.db;Version=3;";

        // 1. DASHBOARD COUNT
        public int GetTodayShiftsCount()
        {
            int count = 0;
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Shifts WHERE ShiftDate = @today", conn))
                    {
                        cmd.Parameters.AddWithValue("@today", today);
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch { count = 0; }
            return count;
        }

        // 2. GET ALL SHIFTS (Pop-up FIX)
        public DataTable GetAllShifts()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT ShiftID, EmployeeName, ShiftType, ShiftDate, Status FROM Shifts", conn))
                    {
                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            return dt;
        }

        // 3. GET EMPLOYEE SHIFTS
        public DataTable GetEmployeeShifts(string username)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT ShiftID, ShiftType, ShiftDate, Status FROM Shifts WHERE EmployeeName = @user", conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            return dt;
        }

        // 4. ADD SHIFT
        public bool AddShift(string employeeName, string shiftType, string shiftDate)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Shifts (EmployeeName, ShiftType, ShiftDate, Status) VALUES (@emp, @type, @date, 'Assigned')", conn))
                    {
                        cmd.Parameters.AddWithValue("@emp", employeeName);
                        cmd.Parameters.AddWithValue("@type", shiftType);
                        cmd.Parameters.AddWithValue("@date", shiftDate);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); return false; }
        }

        // 5. REQUEST SWAP
        public bool RequestShiftSwap(int shiftId, string newEmployee)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Shifts SET EmployeeName = @newEmp, Status = 'Swapped' WHERE ShiftID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@newEmp", newEmployee);
                        cmd.Parameters.AddWithValue("@id", shiftId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); return false; }
        }

        // 6. PENDING COUNT
        public int GetPendingRequestsCount()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Shifts WHERE Status = 'Pending'", conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch { return 0; }
        }
    }
}