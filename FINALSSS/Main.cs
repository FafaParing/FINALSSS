using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FINALSSS;

namespace FINALSSS
{
    public partial class Main: Form
    {

        public Main()
        {
            InitializeComponent();
            ShowPanel(panelDashboard);
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivityLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ShowPanel(Panel panelToShow)
        {
            // Hide all panels
            panelDashboard.Visible = false;
            panelInventory.Visible = false;
            panelOrders.Visible = false;
            panelTransactionHistory.Visible = false;
            panelActivityLog.Visible = false;
            panelSalesReport.Visible = false;

            // Show the selected panel
            panelToShow.Visible = true;
        }

        private void btnDashboard_Click(object sender, EventArgs e) => ShowPanel(panelDashboard);
        private void btnInventory_Click(object sender, EventArgs e) => ShowPanel(panelInventory);
        private void btnOrders_Click(object sender, EventArgs e) => ShowPanel(panelOrders);
        private void btnTransactionHistory_Click(object sender, EventArgs e) => ShowPanel(panelTransactionHistory);
        private void btnActivityLog_Click(object sender, EventArgs e) => ShowPanel(panelActivityLog);
        private void btnSalesReport_Click(object sender, EventArgs e) => ShowPanel(panelSalesReport);


        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {
            LoadItems();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvInventory.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                // Get the selected item data
                int itemId = Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells["colItemID"].Value);
                string itemName = dgvInventory.Rows[e.RowIndex].Cells["colItemName"].Value.ToString();
                string category = dgvInventory.Rows[e.RowIndex].Cells["colCategory"].Value.ToString();
                decimal price = Convert.ToDecimal(dgvInventory.Rows[e.RowIndex].Cells["colPrice"].Value);
                string unit = dgvInventory.Rows[e.RowIndex].Cells["colUnit"].Value.ToString();
                string status = dgvInventory.Rows[e.RowIndex].Cells["colStatus"].Value.ToString();


                // Open the editItem form
                EditItem editForm = new EditItem(itemId, itemName, category, price, unit, status);
                editForm.FormClosed += (s, args) => LoadItems();
                editForm.ShowDialog();

            }
            

        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            AddItemForm add = new AddItemForm();
            add.FormClosed += (s, args) => LoadItems(); // refresh after closing add form
            add.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.Cells["colItemName"].Value != null)
                {
                    // Check if the item name contains the search text
                    bool match = string.IsNullOrEmpty(searchText) ||
                                 row.Cells["colItemName"].Value.ToString().ToLower().Contains(searchText);

                    row.Visible = match;
                }
            }
        }

        private void btnAddStocks_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["colItemID"].Value);
                string itemName = dgvInventory.SelectedRows[0].Cells["colItemName"].Value.ToString();
                int currentQty = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["colStock"].Value);

                AddStock addStockForm = new AddStock(itemId, itemName, currentQty);

                // Refresh inventory after closing AddStock form
                addStockForm.FormClosed += (s, args) => LoadItems();
                addStockForm.ShowDialog();
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder createOrderForm = new CreateOrder();
            createOrderForm.Owner = this; // important
            createOrderForm.ShowDialog();

        }


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

                    // Clear the DataGridView before loading new data
                    dgvInventory.Rows.Clear();

                    while (reader.Read())
                    {
                        // Add a new row
                        int rowIndex = dgvInventory.Rows.Add();
                        DataGridViewRow row = dgvInventory.Rows[rowIndex];

                        // Assign values to the correct columns by Name
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
                ORDER BY OrderDate DESC"; // newest orders first

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    dgvOrders.Rows.Clear(); // Clear previous data

                    while (reader.Read())
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        DataGridViewRow row = dgvOrders.Rows[rowIndex];

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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadItems();
            LoadOrders();
            dgvInventory.ClearSelection();
            dgvOrders.ClearSelection();
        }
    }
}
