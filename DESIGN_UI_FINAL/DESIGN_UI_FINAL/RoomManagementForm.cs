using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DESIGN_UI_FINAL
{
    public partial class RoomManagementForm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public RoomManagementForm()
        {
            alamat = "server=localhost; database=corner_vispro; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();

            this.AutoScroll = true;
        }

        private void RoomManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT room_id, room_number, room_type, status, capacity, floor, created_at FROM rooms";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                if (ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].Width = 100;
                    dataGridView1.Columns[0].HeaderText = "Room ID";
                    dataGridView1.Columns[1].Width = 150;
                    dataGridView1.Columns[1].HeaderText = "Room Number";
                    dataGridView1.Columns[2].Width = 120;
                    dataGridView1.Columns[2].HeaderText = "Room Type";
                    dataGridView1.Columns[3].Width = 120;
                    dataGridView1.Columns[3].HeaderText = "Status";
                    dataGridView1.Columns[4].Width = 120;
                    dataGridView1.Columns[4].HeaderText = "Capacity";
                    dataGridView1.Columns[5].Width = 120;
                    dataGridView1.Columns[5].HeaderText = "Floor";
                    dataGridView1.Columns[6].Width = 120;
                    dataGridView1.Columns[6].HeaderText = "Created At";
                }
                else
                {
                    MessageBox.Show("No data available.");
                }

                btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtRoomNumber.Text) && !string.IsNullOrEmpty(txtRoomNumber.Text))
                {
                    query = string.Format(
                        "UPDATE rooms SET room_number = '{0}', status = '{1}', capacity = '{2}', floor = '{3}' WHERE room_id = '{4}'",
                        txtRoomNumber.Text,
                        comboBoxStatus.SelectedItem.ToString(),
                        comboBoxCapacity.SelectedItem.ToString(),
                        comboBoxFloor.SelectedItem.ToString(),
                        txtRoomNumber.Text
                    );
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Success ...");
                        RoomManagementForm_Load(null, null);
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


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void manageMonitorsToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    if (koneksi.State == System.Data.ConnectionState.Closed)
                    {
                        koneksi.Open();
                    }

                    // Check if room_id exists
                    string checkQuery = string.Format("SELECT COUNT(*) FROM rooms WHERE room_id = '{0}';", txtRoomNumber.Text);
                    perintah = new MySqlCommand(checkQuery, koneksi);
                    int count = Convert.ToInt32(perintah.ExecuteScalar());

                    if (count == 0)
                    {
                        query = string.Format("INSERT INTO rooms (room_id, room_number, status, capacity, floor) VALUES ('{0}', '{0}', '{1}', '{2}', '{3}');", txtRoomNumber.Text, comboBoxStatus.SelectedItem.ToString(), comboBoxCapacity.SelectedItem.ToString(), comboBoxFloor.SelectedItem.ToString());
                        perintah = new MySqlCommand(query, koneksi);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();

                        if (res == 1)
                        {
                            MessageBox.Show("Insert Data Success ...");
                            RoomManagementForm_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data...");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The specified Room ID already exists.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtRoomNumber.Text))
                {
                    string searchQuery = string.Format("SELECT * FROM rooms WHERE room_number = '{0}'", txtRoomNumber.Text);

                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(searchQuery, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            txtRoomNumber.Text = row["room_id"].ToString();
                            txtRoomNumber.Text = row["room_number"].ToString(); comboBoxStatus.SelectedItem = row["status"].ToString(); comboBoxCapacity.SelectedItem = row["capacity"].ToString(); comboBoxFloor.SelectedItem = row["floor"].ToString();
                            // Add other fields here as needed
                        }

                        txtRoomNumber.Enabled = true;
                        dataGridView1.DataSource = ds.Tables[0];
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnSearch.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Room not found!");
                        RoomManagementForm_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Room Number to search.");
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
                if (!string.IsNullOrEmpty(txtRoomNumber.Text))
                {
                    if (MessageBox.Show("Are you sure you want to delete this room?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        query = string.Format("DELETE FROM rooms WHERE room_Number = '{0}'", txtRoomNumber.Text);
                        ds.Clear();
                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();

                        if (res == 1)
                        {
                            MessageBox.Show("Delete Data Success ...");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete data...");
                        }

                        RoomManagementForm_Load(null, null); // Reload the form data
                    }
                }
                else
                {
                    MessageBox.Show("The specified Room ID does not exist!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxCapacity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFloor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }
    }
}
