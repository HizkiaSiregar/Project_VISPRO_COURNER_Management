using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DESIGN_UI_FINAL
{
    public partial class DashboardForm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public DashboardForm()
        {
            alamat = "server=localhost; database=corner_vispro; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("SELECT announcement_id, action, description, created_at FROM announcement");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "No";
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[1].HeaderText = "Note Title"; // Formerly Type of Announcement
                dataGridView1.Columns[2].Width = 300;
                dataGridView1.Columns[2].HeaderText = "Content"; // Formerly Description
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[3].HeaderText = "Date";

                btnSave.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the LoginForm
            KournerLoginApp loginForm = new KournerLoginApp();

            // Show the LoginForm
            loginForm.Show();

            // Close the current DashboardForm
            this.Close();  // Closes the current form (DashboardForm)
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the SettingsForm
            SettingForm settingsForm = new SettingForm();

            // Show the SettingsForm
            settingsForm.ShowDialog();  // Show as a modal dialog, meaning the user must close it before returning to the dashboard
            this.Hide();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the RoomForm
            RoomForm RoomForm = new RoomForm();

            // Optionally, pass data from the dashboard to the RoomForm (if needed)
            // For example, you can pass any shared data or objects here
            // RoomForm.LoadPayments(data);  <-- Example of passing data if needed

            // Show the RoomForm
            RoomForm.ShowDialog();
            this.Hide();
        }

        private void manageMonitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitorManagementForm MonitorManagementForm = new MonitorManagementForm();
            MonitorManagementForm.Show();
            this.Hide();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the RoomManagementForm
            RoomManagementForm roomManagementForm = new RoomManagementForm();

            // Show the Room Management form as a dialog or non-dialog window
            roomManagementForm.Show();  // You can use roomManagementForm.ShowDialog(); if you want a modal dialog

            // Optionally hide the dashboard if needed
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
      
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Insert a new note into the database
                query = string.Format("INSERT INTO announcement (action, description) VALUES ('{0}', '{1}');", txtAction.Text, txtDescription.Text);
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();

                if (res == 1)
                {
                    MessageBox.Show("Note added successfully!");
                    DashboardForm_Load(null, null); // Refresh the notes list
                }
                else
                {
                    MessageBox.Show("Failed to add note.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    string searchQuery = string.Format("SELECT * FROM announcement WHERE announcement_id = '{0}'", txtID.Text);

                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(searchQuery, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    adapter.Fill(ds);
                    koneksi.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].HeaderText = "No";
                        dataGridView1.Columns[1].HeaderText = "ID";
                        dataGridView1.Columns[2].HeaderText = "Note Title";
                        dataGridView1.Columns[3].HeaderText = "Content";
                        dataGridView1.Columns[4].HeaderText = "Date";

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            txtID.Text = row["announcement_id"].ToString();
                            txtAction.Text = row["action"].ToString();
                            txtDescription.Text = row["description"].ToString();
                            // Add other fields here as needed
                        }
                    }
                    else
                    {
                        MessageBox.Show("Note not found!");
                        DashboardForm_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an ID to search.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text) && !string.IsNullOrEmpty(txtAction.Text) && !string.IsNullOrEmpty(txtDescription.Text))
                {
                    if (koneksi.State == ConnectionState.Closed)
                    {
                        koneksi.Open();
                    }

                    query = string.Format(
                        "UPDATE announcement SET action = '{0}', description = '{1}' WHERE announcement_id = '{2}'",
                        txtAction.Text,
                        txtDescription.Text,
                        txtID.Text
                    );
                    perintah = new MySqlCommand(query, koneksi);
                    int res = perintah.ExecuteNonQuery();

                    if (koneksi.State == ConnectionState.Open)
                    {
                        koneksi.Close();
                    }

                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Success ...");
                        DashboardForm_Load(null, null); // Refresh the notes list
                    }
                    else
                    {
                        MessageBox.Show("Failed to update data ...");
                    }
                }
                else
                {
                    MessageBox.Show("Incomplete Data!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    if (MessageBox.Show("Are you sure you want to delete this note?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        query = string.Format("DELETE FROM announcement WHERE announcement_id = '{0}'", txtID.Text);
                        ds.Clear();
                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();

                        if (res == 1)
                        {
                            MessageBox.Show("Delete Data Success ...");
                            DashboardForm_Load(null, null); // Refresh the notes list
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete data...");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
