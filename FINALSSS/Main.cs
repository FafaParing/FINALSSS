using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class Main : Form
    {
        private string currentUsername = "Admin"; // Replace with real logged-in user

        public Main()
        {
            InitializeComponent();

            // Panels and DataGridView setup
            ShowPanel(panelDashboard);
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivityLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
        }

        private void ShowPanel(Panel panelToShow)
        {
            panelDashboard.Visible = false;
            panelInventory.Visible = false;
            panelOrders.Visible = false;
            panelActivityLog.Visible = false;
            panelSalesReport.Visible = false;
            panelTransactionHistory.Visible = false;

            panelToShow.Visible = true;
        }

        private void btnDashboard_Click(object sender, EventArgs e) => ShowPanel(panelDashboard);
        private void btnInventory_Click(object sender, EventArgs e) => ShowPanel(panelInventory);
        private void btnOrders_Click(object sender, EventArgs e) => ShowPanel(panelOrders);
        private void btnActivityLog_Click(object sender, EventArgs e) => ShowPanel(panelActivityLog);
        private void btnTransactionHistory_Click(object sender, EventArgs e) => ShowPanel(panelTransactionHistory);
        private void btnSalesReport_Click(object sender, EventArgs e) => ShowPanel(panelSalesReport);

        // ---------- INVENTORY TAB ----------
        public void LoadItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT ItemID, ItemName, Category, StockQuantity, Price, Unit, Status FROM Items";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    dgvInventory.Rows.Clear();

                    while (reader.Read())
                    {
                        int rowIndex = dgvInventory.Rows.Add();
                        var row = dgvInventory.Rows[rowIndex];

                        row.Cells["colItemID"].Value = reader["ItemID"].ToString();
                        row.Cells["colItemName"].Value = reader["ItemName"].ToString();
                        row.Cells["colCategory"].Value = reader["Category"].ToString();
                        row.Cells["colStock"].Value = reader["StockQuantity"].ToString();
                        row.Cells["colPrice"].Value = reader["Price"].ToString();
                        row.Cells["colUnit"].Value = reader["Unit"].ToString();
                        row.Cells["colStatus"].Value = reader["Status"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            AddItemForm add = new AddItemForm();
            add.Owner = this;
            add.FormClosed += (s, args) =>
            {
                LoadItems();
                LogActivity(currentUsername, "Add Item", "Added new item");
            };
            add.ShowDialog();
        }

        private void btnAddStocks_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["colItemID"].Value);
                string itemName = dgvInventory.SelectedRows[0].Cells["colItemName"].Value.ToString();
                int currentQty = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["colStock"].Value);

                AddStock addStockForm = new AddStock(itemId, itemName, currentQty);
                addStockForm.Owner = this;
                addStockForm.FormClosed += (s, args) =>
                {
                    LoadItems();
                    LogActivity(currentUsername, "Add Stock", $"Added stock for item: {itemName}");
                };
                addStockForm.ShowDialog();
            }
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvInventory.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                int itemId = Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells["colItemID"].Value);
                string itemName = dgvInventory.Rows[e.RowIndex].Cells["colItemName"].Value.ToString();
                string category = dgvInventory.Rows[e.RowIndex].Cells["colCategory"].Value.ToString();
                decimal price = Convert.ToDecimal(dgvInventory.Rows[e.RowIndex].Cells["colPrice"].Value);
                string unit = dgvInventory.Rows[e.RowIndex].Cells["colUnit"].Value.ToString();
                string status = dgvInventory.Rows[e.RowIndex].Cells["colStatus"].Value.ToString();

                EditItem editForm = new EditItem(itemId, itemName, category, price, unit, status);
                editForm.Owner = this;
                editForm.FormClosed += (s, args) =>
                {
                    LoadItems();
                    LogActivity(currentUsername, "Edit Item", $"Edited item: {itemName}");
                };
                editForm.ShowDialog();
            }
        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            SearchInDataGridView(dgvInventory, txtSearchInventory.Text, "colItemName");
        }

        // ---------- ORDERS TAB ----------
        public void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT OrderID, CustomerName, ContactNumber, Email, DeliveryAddress, OrderDate, TotalAmount, Status
                        FROM Orders
                        ORDER BY OrderDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    dgvOrders.Rows.Clear();

                    while (reader.Read())
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["colOrderID"].Value = Convert.ToInt32(reader["OrderID"]);
                        row.Cells["colCustomer"].Value = reader["CustomerName"].ToString();
                        row.Cells["colContactNum"].Value = reader["ContactNumber"].ToString();
                        row.Cells["colEmail"].Value = reader["Email"].ToString();
                        row.Cells["colDeliverAdd"].Value = reader["DeliveryAddress"].ToString();
                        row.Cells["colDate"].Value = Convert.ToDateTime(reader["OrderDate"]).ToString("yyyy-MM-dd HH:mm");
                        row.Cells["colTotalAmount"].Value = Convert.ToDecimal(reader["TotalAmount"]).ToString("N2");
                        row.Cells["colOrderStatus"].Value = reader["Status"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder createOrderForm = new CreateOrder();
            createOrderForm.Owner = this;
            createOrderForm.FormClosed += (s, args) =>
            {
                LoadOrders();
                LogActivity(currentUsername, "Create Order", "Created new order");
            };
            createOrderForm.ShowDialog();
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvOrders.Columns[e.ColumnIndex].Name == "colAction")
            {
                int orderID = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["colOrderID"].Value);
                string currentStatus = dgvOrders.Rows[e.RowIndex].Cells["colOrderStatus"].Value.ToString();

                EditStatus editStatusForm = new EditStatus(orderID, currentStatus);
                editStatusForm.Owner = this;
                editStatusForm.FormClosed += (s, args) =>
                {
                    LoadOrders();
                    LogActivity(currentUsername, "Update Order Status", $"Order ID {orderID} status updated to {currentStatus}");
                };
                editStatusForm.ShowDialog();
            }
        }

        private void btnSearchOrders_Click(object sender, EventArgs e)
        {
            SearchInDataGridView(dgvOrders, txtSearchOrders.Text, "colCustomer");
        }

        // ---------- ACTIVITY LOG ----------
        public void LoadActivityLog()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT LogID, ActionBy, ActionType, ActionDetails, ActionDate 
                                     FROM ActivityLog 
                                     WHERE ActionBy <> 'System'
                                     ORDER BY ActionDate DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    dgvActivityLog.Rows.Clear();
                    dgvActivityLog.AllowUserToAddRows = false;

                    while (reader.Read())
                    {
                        int rowIndex = dgvActivityLog.Rows.Add();
                        var row = dgvActivityLog.Rows[rowIndex];

                        row.Cells["colLogID"].Value = reader["LogID"];
                        row.Cells["colActionBy"].Value = reader["ActionBy"];
                        row.Cells["colActionType"].Value = reader["ActionType"];
                        row.Cells["colActionDetails"].Value = reader["ActionDetails"];
                        row.Cells["colActionDate"].Value = Convert.ToDateTime(reader["ActionDate"]).ToString("yyyy-MM-dd HH:mm");
                        row.Cells["colViewDetails"].Value = "View";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading activity log: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvActivityLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvActivityLog.Columns[e.ColumnIndex].Name == "colViewDetails")
            {
                int logId = Convert.ToInt32(dgvActivityLog.Rows[e.RowIndex].Cells["colLogID"].Value);
                ActivityDetails detailsForm = new ActivityDetails(logId);
                detailsForm.ShowDialog();
            }
        }

        // ---------- SHARED METHODS ----------
        private void SearchInDataGridView(DataGridView dgv, string searchText, string columnName)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[columnName].Value != null)
                {
                    bool match = string.IsNullOrEmpty(searchText) ||
                                 row.Cells[columnName].Value.ToString().ToLower().Contains(searchText.ToLower());
                    row.Visible = match;
                }
            }

            if (string.IsNullOrEmpty(searchText))
            {
                if (dgv == dgvInventory) LoadItems();
                else if (dgv == dgvOrders) LoadOrders();
                else if (dgv == dgvActivityLog) LoadActivityLog();
            }
        }

        // ---------- LOGGING ----------
        public void LogActivity(string actionBy, string actionType, string actionDetails)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO ActivityLog (ActionBy, ActionType, ActionDetails, ActionDate)
                                     VALUES (@by, @type, @details, @date)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@by", actionBy);
                    cmd.Parameters.AddWithValue("@type", actionType);
                    cmd.Parameters.AddWithValue("@details", actionDetails);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }

                LoadActivityLog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging activity: " + ex.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadItems();
            LoadOrders();
            LoadActivityLog();
            dgvInventory.ClearSelection();
            dgvOrders.ClearSelection();
            dgvActivityLog.ClearSelection();
        }
    }
}
