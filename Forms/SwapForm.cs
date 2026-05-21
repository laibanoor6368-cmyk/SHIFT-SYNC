using System;
using System.Data;
using System.Windows.Forms;
using Shift_Sync.DataAccess;

namespace Shift_Sync
{
    public partial class SwapForm : Form
    {
        private ShiftRepository _shiftRepository = new ShiftRepository();
        private UserRepository _userRepository = new UserRepository();
        private int selectedShiftId = 0;

        public SwapForm()
        {
            InitializeComponent();
        }

        private void SwapForm_Load(object sender, EventArgs e)
        {
            LoadShiftsData();
            LoadEmployeesInComboBox();
        }

        private void LoadEmployeesInComboBox()
        {
            try
            {
                cmbEmployee.Items.Clear();
                DataTable employees = _userRepository.GetAllEmployees();
                foreach (DataRow row in employees.Rows)
                {
                    if (row["Role"].ToString() == "Employee")
                    {
                        cmbEmployee.Items.Add(row["Username"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadShiftsData()
        {
            try
            {
                DataTable dt = _shiftRepository.GetAllShifts();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Grid row click — ShiftID pakdo
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
                        MessageBox.Show("Shift " + selectedShiftId + " selected!", "Selected");
                    }
                }
            }
            catch
            {
                selectedShiftId = 0;
            }
        }

        // ✅ Submit button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (selectedShiftId == 0)
            {
                MessageBox.Show("Pehle grid mein shift select karo!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEmployee.SelectedItem == null)
            {
                MessageBox.Show("Naya employee select karo!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newEmp = cmbEmployee.SelectedItem.ToString();

            bool success = _shiftRepository.UpdateShiftStatus(selectedShiftId, newEmp);

            if (success)
            {
                MessageBox.Show("Swap Request Submitted!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedShiftId = 0;
                LoadShiftsData();
            }
        }

        // ✅ Clean button
        private void btnClean_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

        }
    }
}