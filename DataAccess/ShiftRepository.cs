using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Shift_Sync.DataAccess
{
    public class ShiftRepository
    {
        // DatabaseHelper se path aa raha hai
        private string connString = DatabaseHelper.ConnectionString;

        public int GetTodayShiftsCount()
        {
            int count = 0;
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(
                        "SELECT COUNT(*) FROM Shifts WHERE ShiftDate = @today", conn))
                    {
                        cmd.Parameters.AddWithValue("@today", today);
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch { count = 0; }
            return count;
        }

        public DataTable GetAllShifts()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(
                        "SELECT ShiftID, EmployeeName, ShiftType, ShiftDate, Status FROM Shifts", conn))
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

        public DataTable GetEmployeeShifts(string username)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string query = @"SELECT ShiftID, ShiftType, ShiftDate, Status 
                                    FROM Shifts 
                                    WHERE EmployeeName = @user 
                                    AND ShiftDate >= date('now') 
                                    AND ShiftDate <= date('now', '+7 days')
                                    ORDER BY ShiftDate ASC";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
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

        public bool AddShift(string employeeName, string shiftType, string shiftDate)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(
                        "INSERT INTO Shifts (EmployeeName, ShiftType, ShiftDate, Status) VALUES (@emp, @type, @date, 'Assigned')", conn))
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
        // Swap request — sirf status update karo, row delete mat karo
        public bool UpdateShiftStatus(int shiftId, string newEmployee)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string query = "UPDATE Shifts SET EmployeeName = @newEmp, Status = 'Pending' WHERE ShiftID = @id";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newEmp", newEmployee);
                        cmd.Parameters.AddWithValue("@id", shiftId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool RequestShiftSwap(int shiftId, string newEmployee)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(
                        "UPDATE Shifts SET EmployeeName = @newEmp, Status = 'Swapped' WHERE ShiftID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@newEmp", newEmployee);
                        cmd.Parameters.AddWithValue("@id", shiftId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); return false; }
        }

        public int GetPendingRequestsCount()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(
                        "SELECT COUNT(*) FROM Shifts WHERE Status = 'Pending'", conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch { return 0; }
        }

        public DataTable GetPendingSwapRequests()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT ShiftID, EmployeeName, ShiftType, ShiftDate, Status FROM Shifts WHERE Status = 'Pending'";
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(new SQLiteCommand(query, conn)))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            return dt;
        }

        public bool ApproveSwapRequest(int shiftId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(
                        "UPDATE Shifts SET Status = 'Approved' WHERE ShiftID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", shiftId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); return false; }
        }

        public bool RejectSwapRequest(int shiftId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(
                        "UPDATE Shifts SET Status = 'Rejected' WHERE ShiftID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", shiftId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); return false; }
        }
    }
}