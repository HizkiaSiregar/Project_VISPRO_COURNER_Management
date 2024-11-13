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
    public partial class MonitorManagementForm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public MonitorManagementForm()
        {
            alamat = "server=localhost; database=corner_vispro; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                if (koneksi.State == ConnectionState.Closed)
                    koneksi.Open();

                query = "SELECT staff_id, staff_name, status FROM staff";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                ds.Clear();
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "Staff ID";
                dataGridView1.Columns[1].HeaderText = "Staff Name";
                dataGridView1.Columns[2].HeaderText = "Status";

                // Ensure comboBoxStatus has options for "Active" and "Unactive"
                if (comboBoxStatus.Items.Count == 0)
                {
                    comboBoxStatus.Items.Add("Active");
                    comboBoxStatus.Items.Add("Inactive");
                }

                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void MonitorManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffName.Text) || comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Please enter a Staff Name and select a Status.");
                return;
            }

            try
            {
                if (koneksi.State == ConnectionState.Closed)
                {
                    koneksi.Open();
                }

                // Check if staff_name already exists
                string checkQuery = "SELECT COUNT(*) FROM staff WHERE staff_name = @staffName";
                perintah = new MySqlCommand(checkQuery, koneksi);
                perintah.Parameters.AddWithValue("@staffName", txtStaffName.Text); // Correct parameter here
                int count = Convert.ToInt32(perintah.ExecuteScalar());

                if (count == 0)
                {
                    // Insert new staff data
                    query = "INSERT INTO staff (staff_name, status) VALUES (@staffName, @status)";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@staffName", txtStaffName.Text); // Correct parameter here
                    perintah.Parameters.AddWithValue("@status", comboBoxStatus.SelectedItem.ToString());
                    int res = perintah.ExecuteNonQuery();

                    if (res == 1)
                    {
                        MessageBox.Show("Data inserted successfully.");
                        MonitorManagementForm_Load(null, null); // Refresh data
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert staff data.");
                    }
                }
                else
                {
                    MessageBox.Show("The specified Staff Name already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
            finally
            {
                koneksi.Close(); // Ensure the connection is closed after saving data
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtStaffName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string status = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxStatus.SelectedItem = status; // Selects Active or Unactive in comboBox
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

        private void settingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Create a new instance of the SettingsForm
            SettingForm settingsForm = new SettingForm();

            // Show the SettingsForm
            settingsForm.ShowDialog();  // Show as a modal dialog, meaning the user must close it before returning to the dashboard
            this.Hide();
        }

        private void manageMonitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitorManagementForm MonitorManagementForm = new MonitorManagementForm();
            MonitorManagementForm.Show();
            this.Hide();
        }

        private void manageRoomsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the RoomManagementForm
            RoomManagementForm roomManagementForm = new RoomManagementForm();

            // Show the Room Management form as a dialog or non-dialog window
            roomManagementForm.Show();  // You can use roomManagementForm.ShowDialog(); if you want a modal dialog

            // Optionally hide the dashboard if needed
            this.Hide();
        }

        private void paymentsToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffName.Text) || comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Please enter a Staff Name and select a Status.");
                return;
            }

            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a staff member to update.");
                return;
            }

            string staffId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (koneksi.State == ConnectionState.Closed)
                    koneksi.Open();

                query = "UPDATE staff SET staff_name = @staffName, status = @status WHERE staff_id = @staffId";
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@staffName", txtStaffName.Text);
                perintah.Parameters.AddWithValue("@status", comboBoxStatus.SelectedItem.ToString());
                perintah.Parameters.AddWithValue("@staffId", staffId);

                if (perintah.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data updated successfully.");
                    LoadData(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update staff data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff member to delete.");
                return;
            }

            string staffId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Deletion", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            try
            {
                if (koneksi.State == ConnectionState.Closed)
                    koneksi.Open();

                query = "DELETE FROM staff WHERE staff_id = @staffId";
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@staffId", staffId);

                if (perintah.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Staff member deleted successfully.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to delete staff member.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtStaffID.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a Staff ID or Staff Name to search.");
                return;
            }

            try
            {
                if (koneksi.State == ConnectionState.Closed)
                    koneksi.Open();

                query = "SELECT staff_id, staff_name, status FROM staff WHERE staff_id LIKE @searchTerm OR staff_name LIKE @searchTerm";
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                adapter = new MySqlDataAdapter(perintah);

                ds.Clear();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    txtStaffName.Text = ds.Tables[0].Rows[0]["staff_name"].ToString();
                    comboBoxStatus.SelectedItem = ds.Tables[0].Rows[0]["status"].ToString();
                    MessageBox.Show("Search results updated.");
                }
                else
                {
                    MessageBox.Show("No matching records found.");
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }
    }
}
