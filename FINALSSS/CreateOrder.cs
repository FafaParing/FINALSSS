using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
            dgvAvailableItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurrentItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            LoadAvailableItems();
        }

        // ===============================
        // CANCEL BUTTON
        // ===============================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===============================
        // LOAD AVAILABLE ITEMS
        // ===============================
        public void LoadAvailableItems()
        {
            dgvAvailableItems.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT ItemID, ItemName, Category, StockQuantity, Price, Unit FROM Items";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int rowIndex = dgvAvailableItems.Rows.Add();
                        DataGridViewRow row = dgvAvailableItems.Rows[rowIndex];

                        row.Cells["colItemID"].Value = reader["ItemID"].ToString();
                        row.Cells["colItemName"].Value = reader["ItemName"].ToString();
                        row.Cells["colCategory"].Value = reader["Category"].ToString();
                        row.Cells["colStock"].Value = reader["StockQuantity"].ToString();
                        row.Cells["colPrice"].Value = reader["Price"].ToString();
                        row.Cells["colUnit"].Value = reader["Unit"].ToString();
                    }
                }
            }
        }

        // ===============================
        // CLICK "ADD" BUTTON IN AVAILABLE ITEMS
        // ===============================
        private void dgvAvailableItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvAvailableItems.Columns[e.ColumnIndex].Name != "colAdd") return;

            DataGridViewRow selected = dgvAvailableItems.Rows[e.RowIndex];
            if (selected.Cells["colItemID"].Value == null) return;

            int stock = Convert.ToInt32(selected.Cells["colStock"].Value);

            if (stock <= 0)
            {
                MessageBox.Show("Item is out of stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Popup for quantity
            SetQuantity qtyForm = new SetQuantity(
                selected.Cells["colItemName"].Value.ToString(),
                stock
            );

            if (qtyForm.ShowDialog() == DialogResult.OK)
            {
                int quantityToAdd = qtyForm.SelectedQuantity;

                // Check if already in current items
                foreach (DataGridViewRow row in dgvCurrentItems.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells["colItemID2"].Value == null) continue;

                    if (row.Cells["colItemID2"].Value.ToString() ==
                        selected.Cells["colItemID"].Value.ToString())
                    {
                        // Update qty
                        int newQty = (int)row.Cells["colQuantity"].Value + quantityToAdd;
                        row.Cells["colQuantity"].Value = newQty;
                        row.Cells["colSubTotal"].Value =
                            Convert.ToDecimal(row.Cells["colPrice2"].Value) * newQty;

                        UpdateTotal();
                        return;
                    }
                }

                // Add NEW row
                dgvCurrentItems.Rows.Add(
                    "Remove",
                    selected.Cells["colItemID"].Value,
                    selected.Cells["colItemName"].Value,
                    quantityToAdd,
                    selected.Cells["colPrice"].Value,
                    Convert.ToDecimal(selected.Cells["colPrice"].Value) * quantityToAdd
                );

                UpdateTotal();
            }
        }

        // ===============================
        // REMOVE ITEM BUTTON
        // ===============================
        private void dgvCurrentItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dgvCurrentItems.Columns[e.ColumnIndex].Name == "colRemove")
            {
                dgvCurrentItems.Rows.RemoveAt(e.RowIndex);
                UpdateTotal();
            }
        }

        // ===============================
        // NEXT BUTTON  (button1)
        // ===============================
        private void button1_Click(object sender, EventArgs e)
        {
            // ❗ PREVENT NEXT IF NO ITEMS
            if (!HasAtLeastOneItem())
            {
                MessageBox.Show("Please add at least one item to proceed.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Clear summary
            dgvOrderSummary.Rows.Clear();

            // Copy items into summary table
            foreach (DataGridViewRow row in dgvCurrentItems.Rows)
            {
                if (row.IsNewRow) continue;

                int idx = dgvOrderSummary.Rows.Add();
                DataGridViewRow sum = dgvOrderSummary.Rows[idx];

                sum.Cells["colItemIDSummary"].Value = row.Cells["colItemID2"].Value;
                sum.Cells["colItemNameSummary"].Value = row.Cells["colItemName2"].Value;
                sum.Cells["colQuantitySummary"].Value = row.Cells["colQuantity"].Value;
                sum.Cells["colPriceSummary"].Value = row.Cells["colPrice2"].Value;

                decimal qty = Convert.ToDecimal(row.Cells["colQuantity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["colPrice2"].Value);

                sum.Cells["colSubTotalSummary"].Value = (qty * price).ToString("N2");
            }

            lblTotal.Text = CalculateTotalAmount().ToString("N2");

            // Switch panels
            panelOrder.Visible = false;
            panelCustomerInformation.Visible = true;

        }

        // ===============================
        // BACK BUTTON
        // ===============================
        private void button3_Click(object sender, EventArgs e)
        {
            panelCustomerInformation.Visible = false;
            panelOrder.Visible = true;
        }

        // ===============================
        // CALCULATE TOTAL
        // ===============================
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

        // ===============================
        // PLACE ORDER BUTTON
        // ===============================
        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            // Validate customer info
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtContactNum.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDeliverAdd.Text))
            {
                MessageBox.Show("Please fill out all customer information.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvOrderSummary.Rows.Count == 0)
            {
                MessageBox.Show("No items added to order.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
            {
                conn.Open();
                SqlTransaction trx = conn.BeginTransaction();

                try
                {
                    // Insert order
                    string insertOrder =
                        @"INSERT INTO Orders
                        (CustomerName, ContactNumber, Email, DeliveryAddress, OrderDate, TotalAmount, Status)
                        OUTPUT INSERTED.OrderID
                        VALUES (@n, @c, @e, @a, @d, @t, @s)";

                    SqlCommand cmd = new SqlCommand(insertOrder, conn, trx);
                    cmd.Parameters.AddWithValue("@n", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@c", txtContactNum.Text);
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@a", txtDeliverAdd.Text);
                    cmd.Parameters.AddWithValue("@d", DateTime.Now);
                    cmd.Parameters.AddWithValue("@t", CalculateTotalAmount());
                    cmd.Parameters.AddWithValue("@s", "Pending");

                    int newOrderID = (int)cmd.ExecuteScalar();

                    // Insert items
                    foreach (DataGridViewRow row in dgvOrderSummary.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int itemId = Convert.ToInt32(row.Cells["colItemIDSummary"].Value);
                        int qty = Convert.ToInt32(row.Cells["colQuantitySummary"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["colPriceSummary"].Value);
                        decimal subtotal = Convert.ToDecimal(row.Cells["colSubTotalSummary"].Value);

                        // Get next OrderItemID
                        int orderItemID = GetNextOrderItemID(conn, trx);

                        string insertItem =
                            @"INSERT INTO OrderItems (OrderItemID, OrderID, ItemID, Quantity, Price, SubTotal)
                              VALUES (@oi, @o, @i, @q, @p, @s)";

                        SqlCommand ci = new SqlCommand(insertItem, conn, trx);
                        ci.Parameters.AddWithValue("@oi", orderItemID);
                        ci.Parameters.AddWithValue("@o", newOrderID);
                        ci.Parameters.AddWithValue("@i", itemId);
                        ci.Parameters.AddWithValue("@q", qty);
                        ci.Parameters.AddWithValue("@p", price);
                        ci.Parameters.AddWithValue("@s", subtotal);
                        ci.ExecuteNonQuery();

                        // Deduct stock
                        SqlCommand us = new SqlCommand(
                            "UPDATE Items SET StockQuantity = StockQuantity - @q WHERE ItemID = @i",
                            conn, trx);
                        us.Parameters.AddWithValue("@q", qty);
                        us.Parameters.AddWithValue("@i", itemId);
                        us.ExecuteNonQuery();
                    }

                    trx.Commit();

                    MessageBox.Show("Order placed successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (this.Owner is Main m)
                        m.LoadOrders();

                    this.Close();
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    MessageBox.Show("Error placing order: " + ex.Message);
                }
            }
        }

        // ===============================
        // GET NEXT ORDER ITEM ID
        // ===============================
        private int GetNextOrderItemID(SqlConnection conn, SqlTransaction trx)
        {
            string q = "SELECT ISNULL(MAX(OrderItemID), 0) + 1 FROM OrderItems";
            SqlCommand cmd = new SqlCommand(q, conn, trx);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        private void UpdateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvOrderSummary.Rows)
            {
                if (row.Cells["colSubTotalSummary"].Value != null)
                {
                    decimal subTotal;
                    if (decimal.TryParse(row.Cells["colSubTotalSummary"].Value.ToString(), out subTotal))
                    {
                        total += subTotal;
                    }
                }
            }

            lblTotal.Text = total.ToString("0.00");
        }

        private bool HasAtLeastOneItem()
        {
            foreach (DataGridViewRow row in dgvCurrentItems.Rows)
            {
                // Skip the placeholder row
                if (!row.IsNewRow)
                {
                    return true;
                }
            }
            return false;
        }
    }
}