using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class EditStatus : Form
    {
        private int orderId;
        private string currentStatus;

        public EditStatus(int id, string status)
        {
            InitializeComponent();

            orderId = id;
            currentStatus = status;

            lblOrderID.Text = "Order ID: " + orderId.ToString();

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

                    string query = "UPDATE Orders SET Status = @status WHERE OrderID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", orderId);
                        cmd.ExecuteNonQuery();
                    }

                    string logQuery = @"
                        INSERT INTO ActivityLog (ActionBy, ActionType, ActionDetails)
                        VALUES (@user, @type, @details)";

                    using (SqlCommand logCmd = new SqlCommand(logQuery, conn))
                    {
                        logCmd.Parameters.AddWithValue("@user", "System");
                        logCmd.Parameters.AddWithValue("@type", "Updated Order Status");
                        logCmd.Parameters.AddWithValue("@details",
                            $"OrderID {orderId}: {currentStatus} → {newStatus}");

                        logCmd.ExecuteNonQuery();
                    }
                }

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
    }
}
