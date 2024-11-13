namespace DESIGN_UI_FINAL
{
    partial class MonitorManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorManagementForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMonitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.manageRoomsToolStripMenuItem,
            this.manageMonitorsToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(665, 119);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1644, 64);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(278, 60);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // manageRoomsToolStripMenuItem
            // 
            this.manageRoomsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageRoomsToolStripMenuItem.Name = "manageRoomsToolStripMenuItem";
            this.manageRoomsToolStripMenuItem.Size = new System.Drawing.Size(373, 60);
            this.manageRoomsToolStripMenuItem.Text = "Manage Rooms";
            this.manageRoomsToolStripMenuItem.Click += new System.EventHandler(this.manageRoomsToolStripMenuItem_Click_1);
            // 
            // manageMonitorsToolStripMenuItem
            // 
            this.manageMonitorsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageMonitorsToolStripMenuItem.Name = "manageMonitorsToolStripMenuItem";
            this.manageMonitorsToolStripMenuItem.Size = new System.Drawing.Size(324, 60);
            this.manageMonitorsToolStripMenuItem.Text = "Manage Staff";
            this.manageMonitorsToolStripMenuItem.Click += new System.EventHandler(this.manageMonitorsToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(252, 60);
            this.paymentsToolStripMenuItem.Text = "Payments";
            this.paymentsToolStripMenuItem.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click_1);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(215, 60);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click_1);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(194, 60);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(957, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1208, 108);
            this.label1.TabIndex = 15;
            this.label1.Text = "Corner Admin Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-935, -53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(4140, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 1829);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3076, 50);
            this.label3.TabIndex = 18;
            this.label3.Text = "© 2024 Corner Kost. All rights reserved.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtStaffName);
            this.panel4.Controls.Add(this.comboBoxStatus);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtStaffID);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(503, 734);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2070, 758);
            this.panel4.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1029, 573);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(978, 93);
            this.button1.TabIndex = 40;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(39, 446);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(1968, 93);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.btnSearch.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1833, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 65);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 43);
            this.label2.TabIndex = 33;
            this.label2.Text = "Staff Name";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(37, 229);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(1964, 50);
            this.txtStaffName.TabIndex = 32;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBoxStatus.Location = new System.Drawing.Point(37, 363);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(1962, 51);
            this.comboBoxStatus.TabIndex = 31;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 43);
            this.label5.TabIndex = 25;
            this.label5.Text = "Staff Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 43);
            this.label7.TabIndex = 19;
            this.label7.Text = "Staff ID";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(39, 109);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(1767, 50);
            this.txtStaffID.TabIndex = 18;
            this.txtStaffID.TextChanged += new System.EventHandler(this.txtStaffID_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.btnSave.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(41, 573);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(959, 93);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(2070, 54);
            this.label11.TabIndex = 11;
            this.label11.Text = "Add New Staff";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(503, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2070, 463);
            this.panel1.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1966, 359);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2070, 54);
            this.label8.TabIndex = 11;
            this.label8.Text = "Staff Overview";
            // 
            // MonitorManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3076, 1879);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MonitorManagementForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MonitorManagementForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMonitorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
    }
}