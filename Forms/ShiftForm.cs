using System;
using System.Data;
using System.Windows.Forms;
using Shift_Sync.DataAccess;

namespace Shift_Sync
{
    public partial class ShiftForm : Form
    {
        private ShiftRepository _shiftRepository = new ShiftRepository();
        private UserRepository _userRepository = new UserRepository();

        public ShiftForm()
        {
            InitializeComponent();
        }

        private void ShiftForm_Load(object sender, EventArgs e)
        {
            DisplayAllShifts();

            if (cmbShift.Items.Count == 0)
            {
                cmbShift.Items.Add("Morning");
                cmbShift.Items.Add("Evening");
                cmbShift.Items.Add("Night");
            }
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
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void DisplayAllShifts()
        {
            try
            {
                DataTable dt = _shiftRepository.GetAllShifts();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Shifts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveShift_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbEmployee.Text) || cmbShift.SelectedItem == null)
            {
                MessageBox.Show("Please enter Employee Name and select a Shift Type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string empName = cmbEmployee.Text.Trim();
                string shiftType = cmbShift.SelectedItem.ToString();
                string shiftDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                bool isSaved = _shiftRepository.AddShift(empName, shiftType, shiftDate);

                if (isSaved)
                {
                    MessageBox.Show("Shift Assigned Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayAllShifts();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ YEH HAI CLEAR BUTTON KA FUNCTION
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            cmbEmployee.SelectedIndex = -1;
            cmbEmployee.Text = ""; // Text box ko puri tarah saaf karne ke liye
            cmbShift.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}