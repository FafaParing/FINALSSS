using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class CreateOrder: Form
    {
        public CreateOrder()
        {
            InitializeComponent();
            dgvAvailableItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurrentItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadAvailableItems();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            // 1️⃣ Validate customer info
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtContactNum.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDeliverAdd.Text))
            {
                MessageBox.Show("Please fill out all customer information.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ Validate that there are items in order
            if (dgvOrderSummary.Rows.Count == 0)
            {
                MessageBox.Show("No items added to the order.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 3️⃣ Insert into Orders table
                    string insertOrderQuery = @"
                INSERT INTO Orders 
                    (CustomerName, ContactNumber, Email, DeliveryAddress, OrderDate, TotalAmount, Status)
                OUTPUT INSERTED.OrderID
                VALUES (@name, @contact, @email, @address, @date, @total, @status)";

                    SqlCommand cmdOrder = new SqlCommand(insertOrderQuery, conn, transaction);
                    cmdOrder.Parameters.AddWithValue("@name", txtCustomerName.Text);
                    cmdOrder.Parameters.AddWithValue("@contact", txtContactNum.Text);
                    cmdOrder.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmdOrder.Parameters.AddWithValue("@address", txtDeliverAdd.Text);
                    cmdOrder.Parameters.AddWithValue("@date", DateTime.Now);
                    cmdOrder.Parameters.AddWithValue("@total", CalculateTotalAmount());
                    cmdOrder.Parameters.AddWithValue("@status", "Pending");

                    int newOrderID = (int)cmdOrder.ExecuteScalar(); // Get generated OrderID

                    // 4️⃣ Insert each item into OrderItems table and deduct stock
                    foreach (DataGridViewRow row in dgvOrderSummary.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int itemId = Convert.ToInt32(row.Cells["colItemIDSummary"].Value);
                        int qty = Convert.ToInt32(row.Cells["colQuantitySummary"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["colPriceSummary"].Value);
                        decimal subtotal = Convert.ToDecimal(row.Cells["colSubTotalSummary"].Value);

                        // Generate OrderItemID manually
                        int orderItemID = GetNextOrderItemID(conn, transaction);

                        string insertItemQuery = @"
        INSERT INTO OrderItems (OrderItemID, OrderID, ItemID, Quantity, Price, SubTotal)
        VALUES (@orderItemID, @orderID, @itemID, @qty, @price, @subtotal)";
                        SqlCommand cmdItem = new SqlCommand(insertItemQuery, conn, transaction);
                        cmdItem.Parameters.AddWithValue("@orderItemID", orderItemID);
                        cmdItem.Parameters.AddWithValue("@orderID", newOrderID);
                        cmdItem.Parameters.AddWithValue("@itemID", itemId);
                        cmdItem.Parameters.AddWithValue("@qty", qty);
                        cmdItem.Parameters.AddWithValue("@price", price);
                        cmdItem.Parameters.AddWithValue("@subtotal", subtotal);

                        cmdItem.ExecuteNonQuery();

                        // Deduct stock
                        string updateStockQuery = @"
        UPDATE Items 
        SET StockQuantity = StockQuantity - @qty
        WHERE ItemID = @itemID";
                        SqlCommand cmdUpdate = new SqlCommand(updateStockQuery, conn, transaction);
                        cmdUpdate.Parameters.AddWithValue("@qty", qty);
                        cmdUpdate.Parameters.AddWithValue("@itemID", itemId);
                        cmdUpdate.ExecuteNonQuery();
                    }


                    transaction.Commit();

                    MessageBox.Show("Order placed successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5️⃣ Refresh Orders page in Main form
                    if (this.Owner is Main mainForm)
                    {
                        mainForm.LoadOrders();
                    }

                    // Close CreateOrder form
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error placing order: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvAvailableItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // header
            if (dgvAvailableItems.Columns[e.ColumnIndex].Name != "colAdd") return;

            DataGridViewRow selected = dgvAvailableItems.Rows[e.RowIndex];
            if (selected.Cells["colItemID"].Value == null) return;

            int stock = Convert.ToInt32(selected.Cells["colStock"].Value);

            if (stock <= 0)
            {
                MessageBox.Show("Item is out of stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open popup to select quantity
            SetQuantity qtyForm = new SetQuantity(
                selected.Cells["colItemName"].Value.ToString(),
                stock
            );

            if (qtyForm.ShowDialog() == DialogResult.OK)
            {
                int quantityToAdd = qtyForm.SelectedQuantity;

                // Check if item already exists in CurrentItems
                foreach (DataGridViewRow row in dgvCurrentItems.Rows)
                {
                    if (row.IsNewRow) continue; // skip placeholder row
                    if (row.Cells["colItemID2"].Value == null) continue;

                    if (row.Cells["colItemID2"].Value.ToString() == selected.Cells["colItemID"].Value.ToString())
                    {
                        // Update quantity & subtotal
                        row.Cells["colQuantity"].Value = (int)row.Cells["colQuantity"].Value + quantityToAdd;
                        row.Cells["colSubTotal"].Value = Convert.ToDecimal(row.Cells["colPrice2"].Value) * (int)row.Cells["colQuantity"].Value;
                        UpdateTotal();
                        return;
                    }
                }

                // Add new row to CurrentItems
                dgvCurrentItems.Rows.Add(
                    "Remove", // Button column
                    selected.Cells["colItemID"].Value,
                    selected.Cells["colItemName"].Value,
                    quantityToAdd,
                    selected.Cells["colPrice"].Value,
                    Convert.ToDecimal(selected.Cells["colPrice"].Value) * quantityToAdd
                );

                UpdateTotal();
            }
        }
        public void LoadAvailableItems()
        {
            dgvAvailableItems.Rows.Clear(); // Clear previous rows

            using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT ItemID, ItemName, Category, StockQuantity, Price, Unit FROM Items";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int rowIndex = dgvAvailableItems.Rows.Add(); // add empty row
                        DataGridViewRow row = dgvAvailableItems.Rows[rowIndex];

                        row.Cells["colItemID"].Value = reader["ItemID"].ToString();
                        row.Cells["colItemName"].Value = reader["ItemName"].ToString();
                        row.Cells["colCategory"].Value = reader["Category"].ToString();
                        row.Cells["colStock"].Value = reader["StockQuantity"].ToString();
                        row.Cells["colPrice"].Value = reader["Price"].ToString();
                        row.Cells["colUnit"].Value = reader["Unit"].ToString();

                        // Button column 'colAdd' will automatically show the "Add" text
                    }
                }
            }
        }

        private void panelOrder_Paint(object sender, PaintEventArgs e)
        {
            LoadAvailableItems();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
          
        }
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCurrentItems.Rows)
            {
                total += Convert.ToDecimal(row.Cells["colSubTotal"].Value);
            }
            lblTotal.Text = total.ToString("C");
        }

        private void dgvCurrentItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCurrentItems.Columns[e.ColumnIndex].Name == "colRemove")
            {
                dgvCurrentItems.Rows.RemoveAt(e.RowIndex);
                UpdateTotal();
            }
        }
        private void dgvAvailableItems_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        // Helper method to calculate total amount from dgvOrderSummary
        private decimal CalculateTotalAmount()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvOrderSummary.Rows)
            {
                if (!row.IsNewRow)
                {
                    total += Convert.ToDecimal(row.Cells["colSubTotalSummary"].Value);
                }
            }

            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1️⃣ Clear previous summary
            dgvOrderSummary.Rows.Clear();

            // 2️⃣ Loop through current order items and copy them to summary
            foreach (DataGridViewRow row in dgvCurrentItems.Rows)
            {
                if (row.IsNewRow) continue;

                int rowIndex = dgvOrderSummary.Rows.Add();
                DataGridViewRow summaryRow = dgvOrderSummary.Rows[rowIndex];

                summaryRow.Cells["colItemIDSummary"].Value = row.Cells["colItemID2"].Value;
                summaryRow.Cells["colItemNameSummary"].Value = row.Cells["colItemName2"].Value;
                summaryRow.Cells["colQuantitySummary"].Value = row.Cells["colQuantity"].Value;
                summaryRow.Cells["colPriceSummary"].Value = row.Cells["colPrice2"].Value;

                // Calculate subtotal: Quantity * Price
                decimal qty = Convert.ToDecimal(row.Cells["colQuantity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["colPrice2"].Value);
                summaryRow.Cells["colSubTotalSummary"].Value = (qty * price).ToString("N2");
            }

            // 3️⃣ Show the next panel (Order Summary / Customer Info)
            panelCustomerInformation.Visible = true;
            panelOrder.Visible = false;

            // 4️⃣ Optionally, calculate total amount and show in a label
            lblTotal.Text = CalculateTotalAmount().ToString("N2");
        }
        int GetNextOrderItemID(SqlConnection conn, SqlTransaction transaction)
        {
            string query = "SELECT ISNULL(MAX(OrderItemID), 0) + 1 FROM OrderItems";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            return (int)cmd.ExecuteScalar();
        }
    }
}
