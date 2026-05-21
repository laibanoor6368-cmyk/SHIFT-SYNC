using System;
using System.Data;
using System.Windows.Forms;
using Shift_Sync.DataAccess;

namespace Shift_Sync
{
    public partial class ManagerDashboard : Form
    {
        private UserRepository _userRepository = new UserRepository();
        private ShiftRepository _shiftRepository = new ShiftRepository();
        private int selectedShiftId = 0;

        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void LoadDashboardData()
        {
            try
            {
                // ✅ Labels mein text + number dono
                int empCount = _userRepository.GetTotalEmployeesCount();
                int shiftsCount = _shiftRepository.GetTodayShiftsCount();
                int pendingCount = _shiftRepository.GetPendingRequestsCount();

                lblTotalEmp.Text = "Total Employees\n" + empCount;
                lblShiftsToday.Text = "Shifts Today\n" + shiftsCount;
                lblPending.Text = "Pending Requests\n" + pendingCount;

                // ✅ Sirf Pending swap requests grid mein
                DataTable pending = _shiftRepository.GetPendingSwapRequests();
                dataGridView1.DataSource = pending;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        // ✅ Grid row click — ShiftID lo
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = dataGridView1.Rows[e.RowIndex];
                    if (row.Cells["ShiftID"].Value != null)
                    {
                        selectedShiftId = Convert.ToInt32(row.Cells["ShiftID"].Value);
                    }
                }
            }
            catch
            {
                selectedShiftId = 0;
            }
        }

        
        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            EmployeeManagementForm empForm = new EmployeeManagementForm();
            empForm.Show();
        }

        private void btnAssignShifts_Click(object sender, EventArgs e)
        {
            ShiftForm shiftForm = new ShiftForm();
            shiftForm.Show();
        }

        private void btnSwapRequests_Click(object sender, EventArgs e)
        {
            SwapForm swapForm = new SwapForm();
            swapForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
