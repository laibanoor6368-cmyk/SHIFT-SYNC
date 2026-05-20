using System;
using System.Windows.Forms;
using Shift_Sync.DataAccess; // Yahan se UserRepository access ho rahi hai

namespace Shift_Sync
{
    public partial class EmployeeManagementForm : Form
    {
        // Repository ka object
        private UserRepository _userRepository = new UserRepository();

        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        // ADD BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // UI se values lein
                string name = txtName.Text.Trim();
                string skill = txtSkills.Text.Trim();
                string hours = txtMaxHours.Text.Trim();

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter a username!");
                    return;
                }

                // Repository call karein
                if (_userRepository.AddEmployee(name, skill, hours))
                {
                    MessageBox.Show("Employee Added Successfully!");
                    // Textboxes saaf kar dein
                    txtName.Clear();
                    txtSkills.Clear();
                    txtMaxHours.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // DELETE BUTTON
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // GridView se ID uthayein (Assume: aapne Grid mein ID column rakha hai)
                int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);

                if (_userRepository.DeleteEmployee(userId))
                {
                    MessageBox.Show("Employee Deleted Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a row first! Error: " + ex.Message);
            }
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {// Form load hote hi table bhar jayega

        
            LoadDataIntoGrid();
        }

        private void LoadDataIntoGrid()
        {
            // UserRepository se data layen
            dataGridView1.DataSource = _userRepository.GetAllEmployees();
        }

    }
    }
