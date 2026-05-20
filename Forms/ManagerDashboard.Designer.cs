namespace Shift_Sync
{
    partial class ManagerDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSwapre = new System.Windows.Forms.Button();
            this.btnAssigns = new System.Windows.Forms.Button();
            this.btnManages = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelEmployees = new System.Windows.Forms.Panel();
            this.lblemp = new System.Windows.Forms.Label();
            this.lblTotalEmp = new System.Windows.Forms.Label();
            this.panelShifts = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShiftsToday = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSidebar.SuspendLayout();
            this.panelEmployees.SuspendLayout();
            this.panelShifts.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Navy;
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnSwapre);
            this.panelSidebar.Controls.Add(this.btnAssigns);
            this.panelSidebar.Controls.Add(this.btnManages);
            this.panelSidebar.Controls.Add(this.button1);
            this.panelSidebar.Controls.Add(this.label1);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(263, 700);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Navy;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(21, 527);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(205, 46);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSwapre
            // 
            this.btnSwapre.BackColor = System.Drawing.Color.Navy;
            this.btnSwapre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwapre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSwapre.Location = new System.Drawing.Point(15, 331);
            this.btnSwapre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwapre.Name = "btnSwapre";
            this.btnSwapre.Size = new System.Drawing.Size(229, 46);
            this.btnSwapre.TabIndex = 4;
            this.btnSwapre.Text = "View Swap Request";
            this.btnSwapre.UseVisualStyleBackColor = false;
            this.btnSwapre.Click += new System.EventHandler(this.btnSwapRequests_Click);
            // 
            // btnAssigns
            // 
            this.btnAssigns.BackColor = System.Drawing.Color.Navy;
            this.btnAssigns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssigns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssigns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAssigns.Location = new System.Drawing.Point(15, 271);
            this.btnAssigns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssigns.Name = "btnAssigns";
            this.btnAssigns.Size = new System.Drawing.Size(229, 46);
            this.btnAssigns.TabIndex = 3;
            this.btnAssigns.Text = "Assign Shifts";
            this.btnAssigns.UseVisualStyleBackColor = false;
            this.btnAssigns.Click += new System.EventHandler(this.btnAssignShifts_Click);
            // 
            // btnManages
            // 
            this.btnManages.BackColor = System.Drawing.Color.Navy;
            this.btnManages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManages.Location = new System.Drawing.Point(15, 208);
            this.btnManages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManages.Name = "btnManages";
            this.btnManages.Size = new System.Drawing.Size(229, 46);
            this.btnManages.TabIndex = 2;
            this.btnManages.Text = "Manage Employees";
            this.btnManages.UseVisualStyleBackColor = false;
            this.btnManages.Click += new System.EventHandler(this.btnManageEmployees_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(21, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHIFT-SYNC";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblWelcome.Location = new System.Drawing.Point(281, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(356, 45);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome , manager ! ";
            // 
            // panelEmployees
            // 
            this.panelEmployees.BackColor = System.Drawing.Color.DarkBlue;
            this.panelEmployees.Controls.Add(this.lblemp);
            this.panelEmployees.Controls.Add(this.lblTotalEmp);
            this.panelEmployees.Location = new System.Drawing.Point(307, 130);
            this.panelEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEmployees.Name = "panelEmployees";
            this.panelEmployees.Size = new System.Drawing.Size(232, 185);
            this.panelEmployees.TabIndex = 2;
            // 
            // lblemp
            // 
            this.lblemp.AutoSize = true;
            this.lblemp.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblemp.Location = new System.Drawing.Point(75, 78);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(81, 62);
            this.lblemp.TabIndex = 1;
            this.lblemp.Text = "25";
            // 
            // lblTotalEmp
            // 
            this.lblTotalEmp.AutoSize = true;
            this.lblTotalEmp.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalEmp.Location = new System.Drawing.Point(0, 17);
            this.lblTotalEmp.Name = "lblTotalEmp";
            this.lblTotalEmp.Size = new System.Drawing.Size(229, 38);
            this.lblTotalEmp.TabIndex = 0;
            this.lblTotalEmp.Text = "Total Employees";
            // 
            // panelShifts
            // 
            this.panelShifts.BackColor = System.Drawing.Color.DarkOrange;
            this.panelShifts.Controls.Add(this.label2);
            this.panelShifts.Controls.Add(this.lblShiftsToday);
            this.panelShifts.Location = new System.Drawing.Point(565, 130);
            this.panelShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShifts.Name = "panelShifts";
            this.panelShifts.Size = new System.Drawing.Size(232, 185);
            this.panelShifts.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(72, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "14";
            // 
            // lblShiftsToday
            // 
            this.lblShiftsToday.AutoSize = true;
            this.lblShiftsToday.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftsToday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShiftsToday.Location = new System.Drawing.Point(23, 17);
            this.lblShiftsToday.Name = "lblShiftsToday";
            this.lblShiftsToday.Size = new System.Drawing.Size(178, 38);
            this.lblShiftsToday.TabIndex = 0;
            this.lblShiftsToday.Text = "Shifts Today";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPending);
            this.panel1.Location = new System.Drawing.Point(827, 130);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 185);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(100, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 62);
            this.label4.TabIndex = 1;
            this.label4.Text = "3";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPending.Location = new System.Drawing.Point(3, 17);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(248, 38);
            this.lblPending.TabIndex = 0;
            this.lblPending.Text = "Pending Requests";
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.ForestGreen;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApprove.Location = new System.Drawing.Point(413, 351);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(149, 50);
            this.btnApprove.TabIndex = 5;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Red;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReject.Location = new System.Drawing.Point(596, 351);
            this.btnReject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(149, 50);
            this.btnReject.TabIndex = 6;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(307, 430);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(771, 256);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Shifts";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 654);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelShifts);
            this.Controls.Add(this.panelEmployees);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panelSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift-Sync- ManagerDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelEmployees.ResumeLayout(false);
            this.panelEmployees.PerformLayout();
            this.panelShifts.ResumeLayout(false);
            this.panelShifts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSwapre;
        private System.Windows.Forms.Button btnAssigns;
        private System.Windows.Forms.Button btnManages;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelEmployees;
        private System.Windows.Forms.Label lblemp;
        private System.Windows.Forms.Label lblTotalEmp;
        private System.Windows.Forms.Panel panelShifts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShiftsToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}