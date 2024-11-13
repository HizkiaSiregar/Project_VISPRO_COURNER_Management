using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DESIGN_UI_FINAL
{
    public partial class RoomForm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public RoomForm()
        {
            alamat = "server=localhost; database=corner_vispro; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();

            this.AutoScroll = true;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT mahasiswa_name, room_id, amount_due, due_date, status, created_at FROM payments";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "Name";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Room ID";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].HeaderText = "Amount Due";
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[3].HeaderText = "Due Date";
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[4].HeaderText = "Status";
                dataGridView1.Columns[5].Width = 120;
                dataGridView1.Columns[5].HeaderText = "Created At";
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure all fields are filled and an image is selected
                if (txtMahasiswaName.Text != "" && txtRoomID.Text != "" && txtAmountDue.Text != "" &&
                    comboBoxStatus.SelectedItem != null && comboBoxBankType.SelectedItem != null && pictureBox3.Image != null)
                {
                    if (koneksi.State == System.Data.ConnectionState.Closed)
                    {
                        koneksi.Open();
                    }

                    // Trim the mahasiswa_name input to handle any leading/trailing spaces
                    string mahasiswaName = txtMahasiswaName.Text.Trim();

                    // Proceed directly to insert the data without checking if the name exists
                    decimal amountDue;
                    if (Decimal.TryParse(txtAmountDue.Text, out amountDue))
                    {
                        // Folder where the images will be saved
                        string folderPath = @"C:\Users\Y O G A\source\repos\DESIGN_UI_FINAL(Before Crystal Report)\DESIGN_UI_FINAL\Foto";

                        // Create folder if it doesn't exist
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        // Generate a unique filename for the image
                        string fileName = Guid.NewGuid().ToString() + ".jpg";
                        string filePath = Path.Combine(folderPath, fileName);

                        // Save the image to the folder
                        pictureBox3.Image.Save(filePath);

                        // Insert query with the image filename included
                        query = string.Format("INSERT INTO payments (mahasiswa_name, room_id, amount_due, due_date, status, bank_type, foto) " +
                                              "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                                              mahasiswaName, txtRoomID.Text, amountDue, dateTimePickerDueDate.Value.ToString("yyyy-MM-dd"),
                                              comboBoxStatus.SelectedItem.ToString(), comboBoxBankType.SelectedItem.ToString(), fileName);

                        perintah = new MySqlCommand(query, koneksi);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();

                        // Check if the insertion was successful
                        if (res == 1)
                        {
                            MessageBox.Show("Data inserted successfully!");
                            RoomForm_Load(null, null); // Reload the form data (refresh the DataGridView)
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid amount due value. Please enter a valid number.");
                    }
                }
                else
                {
                    MessageBox.Show("All fields must be filled and an image must be selected. Please ensure all fields are completed.");
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void txtAmountDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            lblFoto.Visible = false;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CRPaymentForm cRPaymentForm = new CRPaymentForm();
            cRPaymentForm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
