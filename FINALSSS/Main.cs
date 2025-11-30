using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Data;

namespace FINALSSS
{
    public partial class Main : Form
    {
        public string currentUsername = "Admin"; // Replace with actual logged-in user

        public Main()
        {
            InitializeComponent();
            RefreshDashboard();
            // Panel setup
            SetColors(btnDashboard);
            ShowPanel(panelDashboard);

            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivityLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            RoundControl(TotalItems, 20);
            RoundControl(OutOfStock, 20);
            RoundControl(LowStock, 20);
            if (Session.Role == "Admin")
            {
                btnManageAccounts.Visible = true;
                panelManageAccounts.Visible = true;
            }
            else
            {
                btnManageAccounts.Visible = false;
                panelManageAccounts.Visible = false;
            }

            LoadItems(); 
            LoadOrders(); 
            LoadActivityLog();
            LoadTransactionHistory();
            LoadManageUsers();

            dgvInventory.ClearSelection();
            dgvOrders.ClearSelection();
            dgvActivityLog.ClearSelection();

            btnManageAccounts.Visible = Session.Role == "Admin";
        }
        private void btnDashboard_Click(object sender, EventArgs e) { SetColors(btnDashboard); ShowPanel(panelDashboard); }
        private void btnInventory_Click(object sender, EventArgs e) { SetColors(btnInventory); ShowPanel(panelInventory); }
        private void btnOrders_Click(object sender, EventArgs e) { SetColors(btnOrders); ShowPanel(panelOrders); }
        private void btnActivityLog_Click(object sender, EventArgs e) { SetColors(btnActivityLog); ShowPanel(panelActivityLog); }
        private void btnTransactionHistory_Click(object sender, EventArgs e) { SetColors(btnTransactionHistory); ShowPanel(panelTransactionHistory); }
        private void btnSalesReport_Click(object sender, EventArgs e) { SetColors(btnSalesReport); ShowPanel(panelSalesReport); dtpFrom.Value = DateTime.Today.AddMonths(-1); dtpTo.Value = DateTime.Today; LoadSalesReport(dtpFrom.Value.Date, dtpTo.Value.Date.AddDays(1).AddSeconds(-1)); }
        private void btnManageAccounts_Click(object sender, EventArgs e) { SetColors(btnManageAccounts); ShowPanel(panelManageAccounts); }

        public void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(path);
        }
        private void btnManageAccounts_Click_1(object sender, EventArgs e)
        {
            SetColors(btnManageAccounts);
            ShowPanel(panelManageAccounts);
        }

        public void LoadTopSellingChart()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT TOP 5 i.ItemName, SUM(oi.Quantity) AS QuantitySold
                             FROM OrderItems oi
                             INNER JOIN Orders o ON oi.OrderID = o.OrderID
                             INNER JOIN Items i ON oi.ItemID = i.ItemID
                             GROUP BY i.ItemName
                             ORDER BY QuantitySold DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    TopSellingChart.Series.Clear();
                    TopSellingChart.Series.Add("TopSellingItems");
                    TopSellingChart.Series["TopSellingItems"].XValueMember = "ItemName";
                    TopSellingChart.Series["TopSellingItems"].YValueMembers = "QuantitySold";
                    TopSellingChart.DataSource = dt;
                    TopSellingChart.DataBind();

                    // Optional: clean Y-axis
                    TopSellingChart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
                    TopSellingChart.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading top selling chart: " + ex.Message);
            }
        }


        private void LoadDashboardMetrics()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();

                    // Total Items
                    SqlCommand cmdTotal = new SqlCommand("SELECT COUNT(*) FROM Items", conn);
                    lblTotalItems.Text = cmdTotal.ExecuteScalar().ToString();

                    // Out of Stock
                    SqlCommand cmdOut = new SqlCommand("SELECT COUNT(*) FROM Items WHERE StockQuantity = 0", conn);
                    lblOutOfStock.Text = cmdOut.ExecuteScalar().ToString();

                    // Low Stock (<=5)
                    SqlCommand cmdLow = new SqlCommand("SELECT COUNT(*) FROM Items WHERE StockQuantity <= 5 AND StockQuantity > 0", conn);
                    lblLowStock.Text = cmdLow.ExecuteScalar().ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard metrics: " + ex.Message);
            }
        }

        private void RefreshDashboard()
        {
            LoadDashboardMetrics();    // existing metrics
            LoadTopSellingChart();     // new chart
        }


        public void LoadSalesReport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open(); string query = @" SELECT i.ItemName, i.Category, SUM(oi.Quantity) AS QuantitySold, i.Price AS UnitPrice, SUM(oi.SubTotal) AS Total FROM OrderItems oi INNER JOIN Orders o ON oi.OrderID = o.OrderID INNER JOIN Items i ON oi.ItemID = i.ItemID WHERE o.OrderDate BETWEEN @from AND @to GROUP BY i.ItemName, i.Category, i.Price ORDER BY i.ItemName ASC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@from", fromDate);
                    cmd.Parameters.AddWithValue("@to", toDate);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dgvSalesReport.Rows.Clear(); int totalItemsSold = 0;
                    decimal totalSalesAmount = 0; while (reader.Read())
                    {
                        int rowIndex = dgvSalesReport.Rows.Add();
                        var row = dgvSalesReport.Rows[rowIndex]; int qtySold = Convert.ToInt32(reader["QuantitySold"]);
                        decimal unitPrice = Convert.ToDecimal(reader["UnitPrice"]); decimal total = Convert.ToDecimal(reader["Total"]);
                        row.Cells["colItemNameSales"].Value = reader["ItemName"].ToString();
                        row.Cells["colCategorySales"].Value = reader["Category"].ToString();
                        row.Cells["colQuantitySold"].Value = qtySold;
                        row.Cells["colUnitPrice"].Value = unitPrice.ToString("N2");
                        row.Cells["colTotal"].Value = total.ToString("N2");
                        totalItemsSold += qtySold; totalSalesAmount += total;
                    }
                    reader.Close();
                    lblTotalOrders.Text = totalItemsSold.ToString();
                    lblTotalAmount.Text = totalSalesAmount.ToString("N2");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error loading sales report: " + ex.Message); }
        }
        public void LoadTransactionHistory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();
                    string query = @" SELECT OrderID, CustomerName, OrderDate, TotalAmount, Status FROM Orders ORDER BY OrderDate DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dgvTransactionHistory.Rows.Clear();
                    while (reader.Read())
                    {
                        int rowIndex = dgvTransactionHistory.Rows.Add();
                        var row = dgvTransactionHistory.Rows[rowIndex];
                        row.Cells["colTransOrderID"].Value = Convert.ToInt32(reader["OrderID"]);
                        row.Cells["colTransCustomer"].Value = reader["CustomerName"].ToString();
                        row.Cells["colTransDate"].Value = Convert.ToDateTime(reader["OrderDate"]).ToString("yyyy-MM-dd HH:mm");
                        row.Cells["colTransTotalAmount"].Value = Convert.ToDecimal(reader["TotalAmount"]).ToString("N2");
                        row.Cells["colTransStatus"].Value = reader["Status"].ToString(); row.Cells["colTransViewDetails"].Value = "View";
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction history: " + ex.Message);
            }
        }
        

        public void LoadManageUsers()
        {
            dgvManageAccounts.ClearSelection();


            using (var conn = new SqlConnection(DBconnection.ConnectionString))
            {
                conn.Open();
                // We select ONLY the hash based on the username
                string query = @"SELECT * FROM users";

                using (var cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int rowIndex = dgvManageAccounts.Rows.Add();
                        var row = dgvManageAccounts.Rows[rowIndex];

                        row.Cells["colUserID"].Value = reader["UserID"];
                        row.Cells["colUsername"].Value = reader["Username"];
                        row.Cells["colPassword"].Value = reader["Password"];
                        row.Cells["colRole"].Value = reader["Role"];
                    }
                }
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    int rowIndex = dgvManageAccounts.Rows.Add();
            //    var row = dgvManageAccounts.Rows[rowIndex];

            //    row.Cells["colUserID"].Value = i.ToString();
            //}
        }
        private void ShowPanel(Panel panelToShow)
        {
            panelDashboard.Visible = false;
            panelInventory.Visible = false;
            panelOrders.Visible = false;
            panelActivityLog.Visible = false;
            panelSalesReport.Visible = false;
            panelTransactionHistory.Visible = false;
            panelManageAccounts.Visible = false;

            panelToShow.Visible = true;
        }

        private void SetColors(Button btn)
        {
            ResetColors();
            btn.BackColor = Color.FromArgb(108, 147, 255);
            btn.ForeColor = Color.White;
        }
        private void ResetColors()
        {
            Color defaultColor = Color.FromArgb(58, 111, 248);
            Color defaultTextColor = Color.White;

            btnDashboard.BackColor = defaultColor; btnDashboard.ForeColor = defaultTextColor;
            btnInventory.BackColor = defaultColor; btnInventory.ForeColor = defaultTextColor;
            btnOrders.BackColor = defaultColor; btnOrders.ForeColor = defaultTextColor;
            btnTransactionHistory.BackColor = defaultColor; btnTransactionHistory.ForeColor = defaultTextColor;
            btnActivityLog.BackColor = defaultColor; btnActivityLog.ForeColor = defaultTextColor;
            btnSalesReport.BackColor = defaultColor; btnSalesReport.ForeColor = defaultTextColor;
            btnManageAccounts.BackColor = defaultColor; btnManageAccounts.ForeColor = defaultTextColor;
        }

        // ---------------- INVENTORY ----------------
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
            catch (SqlException ex)
            {
                MessageBox.Show("Database error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGenerateSales_Click(object sender, EventArgs e) 
        { 
            DateTime fromDate = dtpFrom.Value.Date; 
            DateTime toDate = dtpTo.Value.Date.AddDays(1).AddSeconds(-1); 
            LoadSalesReport(fromDate, toDate); 
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddItemForm addForm = new AddItemForm { Owner = this };
                addForm.FormClosed += (s, args) =>
                {
                    LoadItems();
                };
                addForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Add Item form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddStocks_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0) return;

            try
            {
                int itemId = 0, currentQty = 0;
                string itemName = dgvInventory.SelectedRows[0].Cells["colItemName"].Value?.ToString() ?? "";

                if (!int.TryParse(dgvInventory.SelectedRows[0].Cells["colItemID"].Value?.ToString(), out itemId) ||
                    !int.TryParse(dgvInventory.SelectedRows[0].Cells["colStock"].Value?.ToString(), out currentQty))
                {
                    MessageBox.Show("Invalid item data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AddStock addStockForm = new AddStock(itemId, itemName, currentQty) { Owner = this };
                addStockForm.FormClosed += (s, args) =>
                {
                    LoadItems();
                    LogActivity(currentUsername, "Add Stock", $"Added stock for item: {itemName}");
                };
                addStockForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvInventory.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                try
                {
                    int itemId = 0;
                    string itemName = dgvInventory.Rows[e.RowIndex].Cells["colItemName"].Value?.ToString() ?? "";
                    string category = dgvInventory.Rows[e.RowIndex].Cells["colCategory"].Value?.ToString() ?? "";
                    string unit = dgvInventory.Rows[e.RowIndex].Cells["colUnit"].Value?.ToString() ?? "";
                    string status = dgvInventory.Rows[e.RowIndex].Cells["colStatus"].Value?.ToString() ?? "";

                    if (!int.TryParse(dgvInventory.Rows[e.RowIndex].Cells["colItemID"].Value?.ToString(), out itemId))
                    {
                        MessageBox.Show("Invalid Item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!decimal.TryParse(dgvInventory.Rows[e.RowIndex].Cells["colPrice"].Value?.ToString(), out decimal price))
                    {
                        MessageBox.Show("Invalid price value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    EditItem editForm = new EditItem(itemId, itemName, category, price, unit, status) { Owner = this };
                    editForm.FormClosed += (s, args) =>
                    {
                        LoadItems();
                        LogActivity(currentUsername, "Edit Item", $"Edited item: {itemName}");
                    };
                    editForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error editing item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            try
            {
                SearchInDataGridView(dgvInventory, txtSearchInventory.Text, "colItemName");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------- ORDERS ----------------
        public void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT OrderID, CustomerName, ContactNumber, Email, DeliveryAddress, OrderDate, TotalAmount, Status
                                     FROM Orders ORDER BY OrderDate DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    dgvOrders.Rows.Clear();
                    while (reader.Read())
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["colOrderID"].Value = reader["OrderID"].ToString();
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
            catch (SqlException ex)
            {
                MessageBox.Show("Database error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                CreateOrder createForm = new CreateOrder { Owner = this };
                createForm.FormClosed += (s, args) => LoadOrders();
                createForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Create Order form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvOrders.Columns[e.ColumnIndex].Name == "colAction")
            {
                try
                {
                    if (!int.TryParse(dgvOrders.Rows[e.RowIndex].Cells["colOrderID"].Value?.ToString(), out int orderID))
                    {
                        MessageBox.Show("Invalid Order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string currentStatus = dgvOrders.Rows[e.RowIndex].Cells["colOrderStatus"].Value?.ToString() ?? "";

                    EditStatus editStatusForm = new EditStatus(orderID, currentStatus) { Owner = this };
                    editStatusForm.FormClosed += (s, args) => LoadOrders();
                    editStatusForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error editing order status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchOrders_Click(object sender, EventArgs e)
        {
            try
            {
                SearchInDataGridView(dgvOrders, txtSearchOrders.Text, "colCustomer");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------- ACTIVITY LOG ----------------
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
            catch (SqlException ex)
            {
                MessageBox.Show("Database error loading activity log: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error loading activity log: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvActivityLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvActivityLog.Columns[e.ColumnIndex].Name == "colViewDetails")
            {
                try
                {
                    if (!int.TryParse(dgvActivityLog.Rows[e.RowIndex].Cells["colLogID"].Value?.ToString(), out int logId))
                    {
                        MessageBox.Show("Invalid Log ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ActivityDetails detailsForm = new ActivityDetails(logId);
                    detailsForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error viewing activity details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ---------------- SHARED METHODS ----------------
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

        // ---------------- LOGGING ----------------
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
            }
            catch { /* optional: log to file or ignore */ }
        }

        private void dgvTransactionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvTransactionHistory.Columns[e.ColumnIndex].Name == "colTransViewDetails")
            {
                int orderID = Convert.ToInt32(dgvTransactionHistory.Rows[e.RowIndex].Cells["colTransOrderID"].Value);
                TransactionDetails detailsForm = new TransactionDetails(orderID);
                detailsForm.ShowDialog();
            }
        }

        private void panelManageAccounts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            new CreateAccount().ShowDialog();
        }

        private void TopSellingChart_Click(object sender, EventArgs e)
        {

        }
    }
}
