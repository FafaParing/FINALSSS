using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class TransactionDetails : Form
    {
        private int orderID;

        public TransactionDetails(int orderID)
        {
            InitializeComponent();
            dgvTransDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.orderID = orderID;
        }

        private void TransactionDetails_Load(object sender, EventArgs e)
        {
            LoadCustomerInfo();
            LoadOrderItems();
        }

        private void LoadCustomerInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT CustomerName, ContactNumber, Email, DeliveryAddress, TotalAmount
                                     FROM Orders
                                     WHERE OrderID = @orderID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orderID", orderID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCustomerName.Text = reader["CustomerName"].ToString();
                        txtContactNum.Text = reader["ContactNumber"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtAddress.Text = reader["DeliveryAddress"].ToString();
                        lblTotal.Text = Convert.ToDecimal(reader["TotalAmount"]).ToString("N2");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer info: " + ex.Message);
            }
        }

        private void LoadOrderItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT i.ItemName, oi.Quantity, oi.Price AS UnitPrice, oi.SubTotal
                        FROM OrderItems oi
                        INNER JOIN Items i ON oi.ItemID = i.ItemID
                        WHERE oi.OrderID = @orderID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orderID", orderID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    dgvTransDetails.Rows.Clear();

                    while (reader.Read())
                    {
                        int rowIndex = dgvTransDetails.Rows.Add();
                        var row = dgvTransDetails.Rows[rowIndex];

                        row.Cells["colItemName"].Value = reader["ItemName"].ToString();
                        row.Cells["colQuantity"].Value = Convert.ToInt32(reader["Quantity"]);
                        row.Cells["colUnitPrice"].Value = Convert.ToDecimal(reader["UnitPrice"]).ToString("N2");
                        row.Cells["colSubTotal"].Value = Convert.ToDecimal(reader["SubTotal"]).ToString("N2");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order items: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
