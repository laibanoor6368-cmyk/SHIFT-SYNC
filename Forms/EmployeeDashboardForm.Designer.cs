namespace Shift_Sync
{
    partial class EmployeeDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnViewShift = new System.Windows.Forms.Button();
            this.btnSwapRequest = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColShifts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkBlue;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1024, 100);
            this.panelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(354, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE DASHBOARD";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWelcome.Location = new System.Drawing.Point(53, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(169, 38);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME ,";
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelWelcome.Controls.Add(this.lblEmpID);
            this.panelWelcome.Controls.Add(this.lblWelcome);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWelcome.Location = new System.Drawing.Point(0, 100);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1024, 100);
            this.panelWelcome.TabIndex = 2;
      
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEmpID.Location = new System.Drawing.Point(111, 50);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(191, 23);
            this.lblEmpID.TabIndex = 2;
            this.lblEmpID.Text = "Employee ID : EMP001";
            // 
            // btnViewShift
            // 
            this.btnViewShift.BackColor = System.Drawing.Color.DarkGreen;
            this.btnViewShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewShift.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewShift.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewShift.Location = new System.Drawing.Point(108, 258);
            this.btnViewShift.Name = "btnViewShift";
            this.btnViewShift.Size = new System.Drawing.Size(178, 52);
            this.btnViewShift.TabIndex = 3;
            this.btnViewShift.Text = "My Schedule";
            this.btnViewShift.UseVisualStyleBackColor = false;
            // 
            // btnSwapRequest
            // 
            this.btnSwapRequest.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSwapRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwapRequest.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapRequest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSwapRequest.Location = new System.Drawing.Point(323, 258);
            this.btnSwapRequest.Name = "btnSwapRequest";
            this.btnSwapRequest.Size = new System.Drawing.Size(178, 52);
            this.btnSwapRequest.TabIndex = 4;
            this.btnSwapRequest.Text = "Swap Request";
            this.btnSwapRequest.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(533, 258);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(181, 52);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDay,
            this.ColDate,
            this.ColStatus,
            this.ColShifts});
            this.dataGridView1.Location = new System.Drawing.Point(108, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 277);
            this.dataGridView1.TabIndex = 6;
            // 
            // ColDay
            // 
            this.ColDay.HeaderText = "Day";
            this.ColDay.MinimumWidth = 6;
            this.ColDay.Name = "ColDay";
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.MinimumWidth = 6;
            this.ColDate.Name = "ColDate";
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.MinimumWidth = 6;
            this.ColStatus.Name = "ColStatus";
            // 
            // ColShifts
            // 
            this.ColShifts.HeaderText = "Shifts";
            this.ColShifts.MinimumWidth = 6;
            this.ColShifts.Name = "ColShifts";
            // 
            // EmployeeDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSwapRequest);
            this.Controls.Add(this.btnViewShift);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panelTop);
            this.Name = "EmployeeDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeDashboardForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnViewShift;
        private System.Windows.Forms.Button btnSwapRequest;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColShifts;
    }
}