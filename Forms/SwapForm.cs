using System;
using System.Data;
using System.Windows.Forms;
using Shift_Sync.DataAccess; // DAL Layer attach ki

namespace Shift_Sync
{
    public partial class SwapForm : Form
    {
        private ShiftRepository _shiftRepository = new ShiftRepository();
        private int selectedShiftId = 0;

        public SwapForm()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridViewShifts_CellClick;
            btnSubmit.Click += btnSwapRequest_Click;
            btnClean.Click += btnCancel_Click;
            btnClean.Click += btnCancel_Click;
        }
        
        private void SwapForm_Load(object sender, EventArgs e)
        {
            LoadShiftsData();
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSwapRequest_Click(object sender, EventArgs e)
        {
            if (selectedShiftId == 0)
            {
                MessageBox.Show("Please select a shift to swap from the grid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEmployee.SelectedItem == null)
            {
                MessageBox.Show("Please select the new employee for this shift!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newEmp = cmbEmployee.SelectedItem.ToString();

            if (_shiftRepository.RequestShiftSwap(selectedShiftId, newEmp))
            {
                MessageBox.Show("Shift Swapped Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadShiftsData(); // Refresh grid view
            }
        }

        private void dataGridViewShifts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedShiftId = Convert.ToInt32(row.Cells["ShiftID"].Value);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        

   
    }
}