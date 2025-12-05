using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class EditItem : Form
    {
        public string UpdatedItemName { get; private set; }

        private int itemId;

        // Constructor to receive selected item info
        public EditItem(int itemId, string itemName, string category, decimal price, string unit, string status)
        {
            InitializeComponent();

            this.itemId = itemId;

            // Populate form fields
            txtEditItemName.Text = itemName;
            cmbEditCategory.Text = category;
            numEditPrice.Value = price;
            cmbEditUnit.Text = unit;
            cmbStatus.Text = status;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtEditItemName.Text) ||
                string.IsNullOrWhiteSpace(cmbEditCategory.Text) ||
                string.IsNullOrWhiteSpace(cmbEditUnit.Text) ||
                string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemName = txtEditItemName.Text;
            string category = cmbEditCategory.Text;
            decimal price = numEditPrice.Value;
            string unit = cmbEditUnit.Text;
            string status = cmbStatus.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Items 
                             SET ItemName=@name, Category=@category, Price=@price, Unit=@unit, Status=@status 
                             WHERE ItemID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", itemName);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.Add("@price", System.Data.SqlDbType.Decimal).Value = price;
                    cmd.Parameters.AddWithValue("@unit", unit);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", itemId);

                    cmd.ExecuteNonQuery();
                }

                // Store updated name for parent form logging
                UpdatedItemName = itemName;

                // Optional: show message box
                MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Set DialogResult to OK so parent form can detect success
                this.DialogResult = DialogResult.OK;

                this.Close(); // Close the edit form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
