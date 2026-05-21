using System;
using System.Data;
using System.Windows.Forms;
using Shift_Sync.DataAccess;

namespace Shift_Sync
{
    public partial class EmployeeDashboardForm : Form
    {
        private string _username;
        private ShiftRepository _shiftRepo = new ShiftRepository();

        public EmployeeDashboardForm(string username)
        {
            InitializeComponent();
            _username = username;
            lblWelcome.Text = "Welcome, " + username;
        }

        // 1. MY SCHEDULE - MessageBox mein shifts dikhao
        private void btnMySchedule_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    //Weeklu shifts
                    DataTable shifts = _shiftRepo.GetEmployeeShifts(_username);

                    // Grid mein dikhao
                    dataGridView1.DataSource = shifts;

                    if (shifts.Rows.Count == 0)
                    {
                        MessageBox.Show("No Shifts Assigned for this week",
                            "My Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);//, "Error",
                       // MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            }
        
        // 2. SWAP REQUEST - SwapForm open karo
        private void btnSwapRequest_Click(object sender, EventArgs e)
        {
            try
            {
                SwapForm swapForm = new SwapForm();
                swapForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening swap form: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. LOGOUT - Login form par wapis
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void EmployeeDashboardForm_Load(object sender, EventArgs e)
        {
            // Form load hone par kuch extra karna ho to yahan likhein
        }
    }
}
