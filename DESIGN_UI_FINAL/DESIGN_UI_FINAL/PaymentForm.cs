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

        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            LoadRoomDetails();
            LoadPaymentData();

            lblCapacity.Text = "Select a Room";
            lblRatePerMonth.Text = "0"; // Default rate
            numMonth.Minimum = 1; // Minimum months
        }


        private void LoadRoomDetails()
        {
            try
            {
                string query = "SELECT room_number, capacity FROM rooms WHERE status = 'occupied'";
                DataTable dt = new DataTable();

                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                adapter.Fill(dt);
                koneksi.Close();

                if (dt.Rows.Count > 0)
                {
                    comboBoxRoomNumber.DataSource = dt;
                    comboBoxRoomNumber.DisplayMember = "room_number";
                    comboBoxRoomNumber.ValueMember = "capacity";

                    // Reset labels or fields
                    lblCapacity.Text = "Select a Room";
                }
                else
                {
                    comboBoxRoomNumber.DataSource = null; // Clear if no rooms
                    lblCapacity.Text = "No available rooms.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room details: " + ex.Message);
            }
        }

        private void LoadPaymentData()
        {
            try
            {
                string query = "SELECT payment_id, mahasiswa_name, room_id, amount_due, due_date, payment_date, status, bank_type FROM payments";
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment data: " + ex.Message);
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
                // Validate required fields
                if (string.IsNullOrEmpty(txtMahasiswaName.Text) ||
                    string.IsNullOrEmpty(comboBoxRoomNumber.Text) ||
                    string.IsNullOrEmpty(txtTotalAmount.Text) ||
                    comboBoxPaymentStatus.SelectedItem == null ||
                    comboBoxPaymentMethod.SelectedItem == null ||
                    pictureBox3.Image == null)
                {
                    MessageBox.Show("Please fill in all required fields and attach a receipt image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure connection is open
                if (koneksi.State == ConnectionState.Closed)
                    koneksi.Open();

                // Prepare folder for receipt image
                string folderPath = @"C:\Receipts";
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                // Generate unique file name for the receipt image
                string fileName = Guid.NewGuid().ToString() + ".jpg";
                string filePath = Path.Combine(folderPath, fileName);

                // Save the image to the designated folder
                pictureBox3.Image.Save(filePath);

                // Insert payment details into the database, including payment_date
                query = "INSERT INTO payments (mahasiswa_name, room_id, amount_due, due_date, payment_date, status, bank_type, foto) " +
                        "VALUES (@MahasiswaName, @RoomID, @AmountDue, @DueDate, @PaymentDate, @Status, @BankType, @Foto)";
                perintah = new MySqlCommand(query, koneksi);

                // Add parameters to avoid SQL injection
                perintah.Parameters.AddWithValue("@MahasiswaName", txtMahasiswaName.Text);
                perintah.Parameters.AddWithValue("@RoomID", comboBoxRoomNumber.Text);
                perintah.Parameters.AddWithValue("@AmountDue", decimal.Parse(txtTotalAmount.Text));
                perintah.Parameters.AddWithValue("@DueDate", dateDueDate.Value.ToString("yyyy-MM-dd"));
                perintah.Parameters.AddWithValue("@PaymentDate", DateTime.Now.ToString("yyyy-MM-dd")); // Current date as payment date
                perintah.Parameters.AddWithValue("@Status", comboBoxPaymentStatus.SelectedItem.ToString());
                perintah.Parameters.AddWithValue("@BankType", comboBoxPaymentMethod.SelectedItem.ToString());
                perintah.Parameters.AddWithValue("@Foto", fileName);

                // Execute the query
                int result = perintah.ExecuteNonQuery();
                koneksi.Close();

                if (result == 1)
                {
                    MessageBox.Show("Payment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh payment records
                    LoadPaymentData();
                }
                else
                {
                    MessageBox.Show("Failed to save payment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show("An error occurred while saving the payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            RoomManagementForm roomManagementForm = new RoomManagementForm();

            // Subscribe to the event
            roomManagementForm.OnRoomListUpdated += LoadRoomDetails;

            // Show the Room Management form
            roomManagementForm.ShowDialog();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (!string.IsNullOrEmpty(txtPaymentID.Text))
                {
                    query = "SELECT * FROM payments WHERE payment_id = @PaymentID";
                }
                else if (!string.IsNullOrEmpty(txtMahasiswaName.Text))
                {
                    query = "SELECT * FROM payments WHERE mahasiswa_name LIKE @StudentName";
                }

                if (!string.IsNullOrEmpty(query))
                {
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);

                    if (!string.IsNullOrEmpty(txtPaymentID.Text))
                        perintah.Parameters.AddWithValue("@PaymentID", txtPaymentID.Text);
                    else
                        perintah.Parameters.AddWithValue("@StudentName", "%" + txtMahasiswaName.Text + "%");

                    adapter = new MySqlDataAdapter(perintah);
                    adapter.Fill(ds);
                    koneksi.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("No payment records found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Payment ID or Student Name to search.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(lblRatePerMonth.Text, out decimal rate) && numMonth.Value > 0)
                {
                    int months = (int)numMonth.Value;
                    txtTotalAmount.Text = (rate * months).ToString("F2");
                }
                else
                {
                    MessageBox.Show("Please select a valid room and rental duration.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating payment: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void numMonth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRoomNumber.SelectedValue != null)
            {
                string roomCapacity = comboBoxRoomNumber.SelectedValue.ToString();
                lblCapacity.Text = $"{roomCapacity} people";

                // Use a switch statement for setting rates
                switch (roomCapacity)
                {
                    case "1":
                        lblRatePerMonth.Text = "800000";
                        break;
                    case "2":
                        lblRatePerMonth.Text = "1300000";
                        break;
                    default:
                        lblRatePerMonth.Text = "0";
                        break;
                }
            }
            else
            {
                lblRatePerMonth.Text = "0"; // Default value if no room is selected
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            CRPaymentForm cRPaymentForm = new CRPaymentForm();
            cRPaymentForm.ShowDialog();
        }

        private void dashboardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }
    }
}
