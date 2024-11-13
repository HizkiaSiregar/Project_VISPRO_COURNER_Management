namespace DESIGN_UI_FINAL
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMonitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNoteStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAction = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(965, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1208, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corner Admin Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.menuStrip1.Location = new System.Drawing.Point(673, 110);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1644, 64);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.manageRoomsToolStripMenuItem.Click += new System.EventHandler(this.manageRoomsToolStripMenuItem_Click);
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
            this.paymentsToolStripMenuItem.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(215, 60);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(194, 60);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-927, -62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(4140, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 1717);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3076, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "© 2024 Corner Kost. All rights reserved.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.comboBoxNoteStatus);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtAction);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.txtDescription);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(77, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2936, 1373);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.btnPrint.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1040, 269);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(166, 78);
            this.btnPrint.TabIndex = 46;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(70, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1043, 54);
            this.label4.TabIndex = 45;
            this.label4.Text = "Note Status";
            // 
            // comboBoxNoteStatus
            // 
            this.comboBoxNoteStatus.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNoteStatus.FormattingEnabled = true;
            this.comboBoxNoteStatus.Items.AddRange(new object[] {
            "Finish",
            "Unfinish"});
            this.comboBoxNoteStatus.Location = new System.Drawing.Point(77, 284);
            this.comboBoxNoteStatus.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxNoteStatus.Name = "comboBoxNoteStatus";
            this.comboBoxNoteStatus.Size = new System.Drawing.Size(944, 51);
            this.comboBoxNoteStatus.TabIndex = 44;
            this.comboBoxNoteStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxNoteStatus_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.btnSave.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(77, 1245);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(1129, 78);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(77, 1142);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(1129, 78);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.btnSearch.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1040, 126);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 78);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(77, 142);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(944, 46);
            this.txtID.TabIndex = 35;
            this.txtID.Text = "";
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(70, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(965, 54);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtAction
            // 
            this.txtAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAction.Location = new System.Drawing.Point(77, 401);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(1129, 46);
            this.txtAction.TabIndex = 19;
            this.txtAction.Text = "";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label13.Location = new System.Drawing.Point(70, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(965, 54);
            this.label13.TabIndex = 18;
            this.label13.Text = "Title";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1261, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1565, 1244);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(77, 534);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1129, 574);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.Text = "";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label12.Location = new System.Drawing.Point(70, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1136, 54);
            this.label12.TabIndex = 13;
            this.label12.Text = "Add Description";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(2936, 54);
            this.label11.TabIndex = 11;
            this.label11.Text = "Notes";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3076, 1767);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMonitorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox txtAction;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNoteStatus;
    }
}