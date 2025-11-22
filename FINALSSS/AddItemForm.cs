using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            // No code needed here
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Simple validation
            if (string.IsNullOrWhiteSpace(txtItemName.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(cmbUnit.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemName = txtItemName.Text;
            string category = cmbCategory.Text;
            int stock = (int)numStock.Value;
            decimal price = decimal.Parse(txtPrice.Text);
            string unit = cmbUnit.Text;
            string status = cmbStatus.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Items (ItemName, Category, StockQuantity, Unit, Price, Status) 
                                     VALUES (@name, @category, @quantity, @unit, @price, @status)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", itemName);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@quantity", stock);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@unit", unit);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Item added successfully.");

                // Refresh main form DataGridView
                if (this.Owner is Main mainForm)
                {
                    mainForm.LoadItems();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
