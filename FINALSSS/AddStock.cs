using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class AddStock : Form
    {
        public int AddedQuantity { get; set; }

        private int itemId;
        private int currentQty;

        public AddStock(int itemId, string itemName, int currentQty)
        {
            InitializeComponent();

            this.itemId = itemId;
            this.currentQty = currentQty;

            lblItemName.Text = itemName;
            lblCurrentQuantity.Text = currentQty.ToString();
            numAddQuantity.Value = 0;
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            int qtyToAdd = (int)numAddQuantity.Value;
            int newQty = currentQty + qtyToAdd;

            if (qtyToAdd <= 0)
            {
                MessageBox.Show("Please enter a quantity greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();

                    string query = "UPDATE Items SET StockQuantity=@newQty WHERE ItemID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@newQty", newQty);
                    cmd.Parameters.AddWithValue("@id", itemId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Stock updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
