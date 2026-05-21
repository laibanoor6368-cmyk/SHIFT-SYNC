
using System;
using System.Data;
using System.Windows.Forms;
using Shift_Sync.DataAccess;

namespace Shift_Sync
{
    public partial class EmployeeManagementForm : Form
    {
        private UserRepository _userRepository = new UserRepository();
        private int selectedUserId = 0;

        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoGrid();
        }

        private void LoadDataIntoGrid()
        {
            dataGridView1.DataSource = _userRepository.GetAllEmployees();
        }

        // ✅ Grid click — data textboxes mein aayega
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    selectedUserId = Convert.ToInt32(row.Cells[0].Value);
                    txtName.Text = row.Cells["Username"].Value?.ToString();
                    txtSkills.Text = row.Cells["Skills"].Value?.ToString();
                    txtMaxHours.Text = row.Cells["Hours"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ✅ ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string skill = txtSkills.Text.Trim();
                string hours = txtMaxHours.Text.Trim();

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter a username!");
                    return;
                }

                if (_userRepository.AddEmployee(name, skill, hours))
                {
                    MessageBox.Show("Employee Added Successfully!");
                    txtName.Clear();
                    txtSkills.Clear();
                    txtMaxHours.Clear();
                    LoadDataIntoGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ✅ UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUserId == 0)
                {
                    MessageBox.Show("Pehle grid mein employee select karo!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string name = txtName.Text.Trim();
                string skill = txtSkills.Text.Trim();
                string hours = txtMaxHours.Text.Trim();

                if (_userRepository.UpdateEmployee(selectedUserId, name, skill, hours))
                {
                    MessageBox.Show("Employee Updated Successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedUserId = 0;
                    txtName.Clear();
                    txtSkills.Clear();
                    txtMaxHours.Clear();
                    LoadDataIntoGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ✅ DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUserId == 0)
                {
                    MessageBox.Show("Pehle grid mein employee select karo!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    "Kya aap yeh employee delete karna chahte hain?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    if (_userRepository.DeleteEmployee(selectedUserId))
                    {
                        MessageBox.Show("Employee Deleted!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectedUserId = 0;
                        txtName.Clear();
                        txtSkills.Clear();
                        txtMaxHours.Clear();
                        LoadDataIntoGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}