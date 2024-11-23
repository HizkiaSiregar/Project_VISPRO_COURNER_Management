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
            LoadStatuses();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadStatuses()
        {
            // Load status options for ComboBox
            query = "SELECT status_id, status_name FROM note_status";
            adapter = new MySqlDataAdapter(query, koneksi);
            DataTable statusTable = new DataTable();
            adapter.Fill(statusTable);
            comboBoxNoteStatus.DataSource = statusTable;
            comboBoxNoteStatus.DisplayMember = "status_name";
            comboBoxNoteStatus.ValueMember = "status_id";
        }


        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT announcement.announcement_id, announcement.action, announcement.description, announcement.created_at, note_status.status_name " +
                        "FROM announcement " +
                        "LEFT JOIN note_status ON announcement.status_id = note_status.status_id";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "No";
                dataGridView1.Columns[1].HeaderText = "Note Title";
                dataGridView1.Columns[2].HeaderText = "Content";
                dataGridView1.Columns[3].HeaderText = "Date";
                dataGridView1.Columns[4].HeaderText = "Status";
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
                string statusId = comboBoxNoteStatus.SelectedValue.ToString();
                query = $"INSERT INTO announcement (action, description, status_id) VALUES ('{txtAction.Text}', '{txtDescription.Text}', {statusId})";
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();

                if (res == 1)
                {
                    MessageBox.Show("Note added successfully!");
                    DashboardForm_Load(null, null);
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
                if (!string.IsNullOrEmpty(txtID.Text))  // txtID is where user inputs the ID
                {
                    // Create the search query for a specific announcement_id
                    string searchQuery = $"SELECT announcement.announcement_id, announcement.action, announcement.description, announcement.created_at, note_status.status_name " +
                                         $"FROM announcement " +
                                         $"LEFT JOIN note_status ON announcement.status_id = note_status.status_id " +
                                         $"WHERE announcement.announcement_id = '{txtID.Text}'";

                    ds.Clear(); // Clear previous data from DataSet
                    koneksi.Open(); // Open connection
                    perintah = new MySqlCommand(searchQuery, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    adapter.Fill(ds); // Fill dataset with search result
                    koneksi.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        // Update DataGridView to display search results only, with specified headers
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].HeaderText = "No";
                        dataGridView1.Columns[1].HeaderText = "Note Title";
                        dataGridView1.Columns[2].HeaderText = "Content";
                        dataGridView1.Columns[3].HeaderText = "Date";
                        dataGridView1.Columns[4].HeaderText = "Status";

                        // Assuming you want to update textboxes with the first result row data
                        DataRow row = ds.Tables[0].Rows[0]; // Take the first row in the result set

                        // Ensure the textbox names match the ones in the designer
                        txtAction.Text = row["action"].ToString();
                        txtDescription.Text = row["description"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Note not found!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an ID to search.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    string statusId = comboBoxNoteStatus.SelectedValue.ToString();
                    query = $"UPDATE announcement SET action = '{txtAction.Text}', description = '{txtDescription.Text}', status_id = {statusId} WHERE announcement_id = '{txtID.Text}'";
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Success");
                        DashboardForm_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update data");
                    }
                }
                else
                {
                    MessageBox.Show("Incomplete Data");
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNoteStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CPdashboardFormcs cPdashboardFormcs = new CPdashboardFormcs();
            cPdashboardFormcs.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
