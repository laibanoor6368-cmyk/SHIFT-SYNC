using System;
using System.Data;
using System.Data.SQLite;

namespace Shift_Sync.DataAccess
{
    public class UserRepository
    {
        // DatabaseHelper se path aa raha hai
        private string connString = DatabaseHelper.ConnectionString;

        public bool AddEmployee(string username, string skills, string hours)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                string query = "INSERT INTO users (Username, Skills, Hours, Password, Role) VALUES (@user, @skills, @hours, '123', 'Employee')";
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@skills", skills);
                    cmd.Parameters.AddWithValue("@hours", hours);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool UpdateEmployee(int userId, string username, string skills, string hours)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                string query = "UPDATE users SET Username = @user, Skills = @skills, Hours = @hours WHERE UserID = @id";
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@skills", skills);
                    cmd.Parameters.AddWithValue("@hours", hours);
                    cmd.Parameters.AddWithValue("@id", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool DeleteEmployee(int userId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                string query = "DELETE FROM users WHERE UserID = @id";
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public int GetTotalEmployeesCount()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE Role = 'Employee'";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch { return 0; }
        }

        public string ValidateUser(string username, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                string query = "SELECT Role FROM users WHERE Username = @user AND Password = @pass";
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }

        public DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM users";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}