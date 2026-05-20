using System;
using System.Data;
using System.Windows.Forms;
using Shift_Sync.DataAccess; // DataAccess Layer ko include kiya

namespace Shift_Sync
{
    public partial class ShiftForm : Form
    {
        // Repository ka object top par banaya
        private ShiftRepository _shiftRepository = new ShiftRepository();

        public ShiftForm()
        {
            InitializeComponent();
        }

        private void ShiftForm_Load(object sender, EventArgs e)
        {
            // Form load hote hi shifts data grid view mein show ho jayein
            DisplayAllShifts();

            // Agar aapke paas ComboBox hai shift types ke liye, to options add kar dein
            if (cmbShift.Items.Count == 0)
            {
                cmbShift.Items.Add("Morning");
                cmbShift.Items.Add("Evening");
                cmbShift.Items.Add("Night");
            }
        }

        // Grid view ko data se bharne ka function
        private void DisplayAllShifts()
        {
            try
            {
                // UI se direct query nahi chali, Repository se data mangwaya
                DataTable dt = _shiftRepository.GetAllShifts();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Shifts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Shift Save/Add karne ka button click event
        private void btnSaveShift_Click(object sender, EventArgs e)
        {
            // 1. Validation check (Controls khali na hon)
            if (string.IsNullOrEmpty(cmbEmployee.Text) || cmbShift.SelectedItem == null)
            {
                MessageBox.Show("Please enter Employee Name and select a Shift Type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string empName = cmbEmployee.Text.Trim();
                string shiftType = cmbShift.SelectedItem.ToString();
                string shiftDate = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // DateTimePicker se date li

                // 2. DataAccess Layer (Repository) ko call kiya
                bool isSaved = _shiftRepository.AddShift(empName, shiftType, shiftDate);

                if (isSaved)
                {
                    MessageBox.Show("Shift Assigned Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayAllShifts(); // Grid refresh karein
                    ClearFields();      // Inputs saaf karein
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            // ComboBox ki selection khatam karne ke liye index ko -1 set karte hain
            cmbEmployee.SelectedIndex = -1;

            // Agar cmbShift bhi ComboBox hai to isay bhi aise hi clear karein
            cmbShift.SelectedIndex = -1;

            // DatePicker ko wapas aaj ki date par set karne ke liye
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}