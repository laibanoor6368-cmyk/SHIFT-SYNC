using System;
using System.Data;
using System.Threading.Tasks; // Task.Delay ke liye
using System.Windows.Forms;
using Shift_Sync.DataAccess;

namespace Shift_Sync
{
    public partial class EmployeeDashboardForm : Form
    {
        private string loggedInUser = "";

        public EmployeeDashboardForm(string username)
        {
            InitializeComponent();
            loggedInUser = username;
        }

        private async void EmployeeDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + loggedInUser + "!";
            // 0.1 second ka wait karein taake connection free ho jaye
            await Task.Delay(100);
            LoadMyShifts();
        }

        private void LoadMyShifts()
        {
            try
            {
                // Global variable ki jagah local repo banayein
                ShiftRepository repo = new ShiftRepository();
                DataTable dt = repo.GetEmployeeShifts(loggedInUser);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}