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

        private void MonitorManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT s.staff_id, s.staff_name, sr.room_id, sr.assigned_at, s.status FROM staff s JOIN staff_rooms sr ON s.staff_id = sr.staff_id";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                if (ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].Width = 100;
                    dataGridView1.Columns[0].HeaderText = "Staff ID";
                    dataGridView1.Columns[1].Width = 150;
                    dataGridView1.Columns[1].HeaderText = "Staff Name";
                    dataGridView1.Columns[2].Width = 120;
                    dataGridView1.Columns[2].HeaderText = "Room ID";
                    dataGridView1.Columns[3].Width = 120;
                    dataGridView1.Columns[3].HeaderText = "Assigned At";
                    dataGridView1.Columns[4].Width = 120;
                    dataGridView1.Columns[4].HeaderText = "Status";
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No data available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (koneksi.State == System.Data.ConnectionState.Closed)
                {
                    koneksi.Open();
                }

                // Check if staff_id exists
                string checkQuery = string.Format("SELECT COUNT(*) FROM staff WHERE staff_id = '{0}';", txtStaffName.Text);
                perintah = new MySqlCommand(checkQuery, koneksi);
                int count = Convert.ToInt32(perintah.ExecuteScalar());

                if (count == 0)
                {
                    query = string.Format("INSERT INTO staff (staff_name, status) VALUES ('{0}', '{1}');", txtStaffName.Text, comboBoxStatus.SelectedItem.ToString());
                    perintah = new MySqlCommand(query, koneksi);
                    int res = perintah.ExecuteNonQuery();

                    if (res == 1)
                    {
                        query = string.Format("INSERT INTO staff_rooms (room_id) VALUES ('{0}');", txtRoomID.Text);
                        perintah = new MySqlCommand(query, koneksi);
                        res = perintah.ExecuteNonQuery();
                        koneksi.Close();

                        if (res == 1)
                        {
                            MessageBox.Show("Insert Data Success ...");
                            MonitorManagementForm_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data...");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert data...");
                    }
                }
                else
                {
                    MessageBox.Show("The specified Staff ID already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }
    }
}
