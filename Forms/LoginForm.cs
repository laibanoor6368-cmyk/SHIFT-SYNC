using Shift_Sync.DataAccess; // DataAccess layer ko include kiya
using System;
using System.Windows.Forms;

namespace Shift_Sync
{
    public partial class LoginForm : Form
    {
        // Repository ka object top par declare kiya
        private UserRepository _userRepository = new UserRepository();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword.UseSystemPasswordChar = false;
        

        string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                username == "Enter username..." || password == "Enter password...")
            {
                MessageBox.Show("Please enter username and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 🔥 DIRECT BYPASS (YAHAN BADLA HAI):
                // Agar aap manager aur manager123 likhein to database check hi na kare, direct dashboard khol de!
                if (username == "manager" && password == "manager123")
                {
                    MessageBox.Show("Login Successful! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ManagerDashboard managerDash = new ManagerDashboard();
                    managerDash.Show();
                    this.Hide();
                    return; // Yahin se code khatam!
                }

                // UI se seedha Repository ko call kiya (Agar koi aur user ho)
                string role = _userRepository.ValidateUser(username, password);

                if (role != null)
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Dashboard loading");

                    if (role.Equals("Manager", StringComparison.OrdinalIgnoreCase))
                    {
                        ManagerDashboard managerDash = new ManagerDashboard();
                        managerDash.Show();
                        this.Hide();
                    }
                    else if (role.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                    {
                        EmployeeDashboardForm empDash = new EmployeeDashboardForm(username);
                        empDash.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}