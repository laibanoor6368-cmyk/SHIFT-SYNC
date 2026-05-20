using System;
using System.Data;
using System.Data.SQLite;

namespace Shift_Sync.DataAccess
{
    public class EmployeeRepository
    {
        // 1. Saare Employees ka data DataGridView ke liye load karna (READ)
        public DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();
            string query = "SELECT UserID, Username, Role FROM users WHERE Role = 'Employee'";

            try
            {
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading employees: " + ex.Message);
            }
            return dt;
        }

        // 2. Naya Employee Add karna (CREATE)
        public bool AddEmployee(string username, string password)
        {
            string query = "INSERT INTO users (Username, Password, Role) VALUES (@user, @pass, 'Employee')";
            try
            {
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding employee: " + ex.Message);
            }
        }

        // 3. Employee Delete karna (DELETE)
        public bool DeleteEmployee(int userId)
        {
            string query = "DELETE FROM users WHERE UserID = @id";
            try
            {
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting employee: " + ex.Message);
            }
        }
    }
}