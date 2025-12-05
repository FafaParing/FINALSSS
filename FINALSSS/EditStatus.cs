using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class EditStatus : Form
    {
        public string UpdatedStatus { get; set; }

        private string currentName;
        private string currentStatus;

        public EditStatus(string name, string status)
        {
            InitializeComponent();

            currentName = name;
            currentStatus = status;

            txtName.Text = name;
            txtCurrentStatus.Text = status;

            if (!string.IsNullOrWhiteSpace(currentStatus) &&
                cmbEditStatus.Items.Contains(currentStatus))
            {
                cmbEditStatus.SelectedItem = currentStatus;
            }
            else
            {
                cmbEditStatus.SelectedIndex = -1;
            }
        }

        private void btnUpdateEditStatus_Click(object sender, EventArgs e)
        {
            if (cmbEditStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = cmbEditStatus.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();

                    string query = "UPDATE Orders SET Status = @status WHERE CustomerName = @name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@name", currentName);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Return the new status to main form
                UpdatedStatus = newStatus;

                MessageBox.Show("Order status updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancelEditStatus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditStatus_Load(object sender, EventArgs e)
        {
            // Not used but kept for designer
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbEditStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
