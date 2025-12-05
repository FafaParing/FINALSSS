using System;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class AddItemForm : Form
    {
        public string AddedItemName { get; set; }

        public AddItemForm()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = 30;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            this.Region = new Region(path);
        }
        public void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(path);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtItemName.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(cmbUnit.Text) ||
                numStock.Value <= 0)           
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemName = txtItemName.Text.Trim();
            string category = cmbCategory.Text.Trim();
            string unit = cmbUnit.Text.Trim();
            string status = cmbStatus.Text.Trim();
            int stock = (int)numStock.Value;

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Invalid price value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();

                    // Check for existing item
                    string checkQuery = "SELECT COUNT(*) FROM Items WHERE ItemName = @name AND Category = @category";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@name", itemName);
                    checkCmd.Parameters.AddWithValue("@category", category);

                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount > 0)
                    {
                        MessageBox.Show("Item already exists in this category.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert new item
                    string insertQuery = @"INSERT INTO Items (ItemName, Category, StockQuantity, Unit, Price, Status) 
                                           VALUES (@name, @category, @quantity, @unit, @price, @status)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@name", itemName);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@quantity", stock);
                    cmd.Parameters.AddWithValue("@unit", unit);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (this.Owner is Main mainForm)
                {
                    mainForm.LoadItems();
                    mainForm.LogActivity(mainForm.currentUsername, "Add Item", $"Added item: {itemName}");
                }

                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            RoundControl(txtItemName, 10);
            RoundControl(txtPrice, 10);
            RoundControl(btnSave, 10);
            RoundControl(btnCancel, 10);
        }

        private void numStock_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
