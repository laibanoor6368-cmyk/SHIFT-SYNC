using System;
using System.Windows.Forms;
using Shift_Sync.DataAccess; // DataAccess Layer (DAL) ko link kiya

namespace Shift_Sync
{
    public partial class ManagerDashboard : Form
    {
        // Repositories ke objects taake database se data mangwaya ja sake
        private UserRepository _userRepository = new UserRepository();
        private ShiftRepository _shiftRepository = new ShiftRepository();

        public ManagerDashboard()
        {
            InitializeComponent();
        }

        // Jab dashboard load hoga, to yeh event automatic chalega
        private void LoadDashboardData()
        {
            try
            {
                // 1. Total Employees wale number ko update kiya (lblTotalEmp ki jagah uske asli number wale label ka naam)
                // Agar aapke numbers wale labels ke naam alag hain, to unhe designer se check karke yahan likhein:
                lblTotalEmp.Text = _userRepository.GetTotalEmployeesCount().ToString();

                // 2. Shifts Today ka main number update kiya
                lblShiftsToday.Text = _shiftRepository.GetTodayShiftsCount().ToString();

                // 3. Pending Requests ka number update kiya
                int pendingCount = _shiftRepository.GetPendingRequestsCount();
                lblPending.Text = pendingCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard Load Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------------------------
        // 🛠️ ALL BUTTON CLICK EVENTS
        // ----------------------------------------------------------------------

        // A. Manage Employees Button Click Event
        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            EmployeeManagementForm empForm = new EmployeeManagementForm();
            empForm.Show(); // Naya form open karega
        }

        // B. Assign/Manage Shifts Button Click Event
        private void btnAssignShifts_Click(object sender, EventArgs e)
        {
            ShiftForm shiftForm = new ShiftForm();
            shiftForm.Show(); // Shift form open karega
        }

        // C. Swap Requests Button Click Event
        private void btnSwapRequests_Click(object sender, EventArgs e)
        {
            SwapForm swapForm = new SwapForm();
            swapForm.Show(); // Swap form open karega
        }

        // D. Logout Button Click Event
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();   // Login window wapas samne layega
            this.Close();   // Manager dashboard form ko band kar dega
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}