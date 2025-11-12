using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // Hide all panels first
            panelDashboard.Visible = false;
            panelInventory.Visible = false;
            panelOrders.Visible = false;
            panelTransactionHistory.Visible = false;
            panelActivityLog.Visible = false;
            panelSalesReport.Visible = false;

            // Show the selected panel
            panelToShow.Visible = true;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(panelDashboard);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowPanel(panelInventory);

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ShowPanel(panelOrders);

        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            ShowPanel(panelTransactionHistory);

        }

        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            ShowPanel(panelActivityLog);

        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            ShowPanel(panelSalesReport);
        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

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
                string status = dgvInventory.Rows[e.RowIndex].Cells["colStatus"].Value.ToString();

                // Open the editItem form
                EditItem editForm = new EditItem(itemId, itemName, category, price, status);
                editForm.ShowDialog(); 
                                
            }
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.Owner = this;
            addItemForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.Cells["ItemName"].Value != null)
                {
                    bool match = string.IsNullOrEmpty(searchText) ||
                                 row.Cells["ItemName"].Value.ToString().ToLower().Contains(searchText);
                    row.Visible = match;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddStocks_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["colItemID"].Value);
                string itemName = dgvInventory.SelectedRows[0].Cells["colItemName"].Value.ToString();
                int currentQty = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["colStock"].Value);

                AddStock addStockForm = new AddStock(itemId, itemName, currentQty);
                addStockForm.ShowDialog();

            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder();
            createOrder.ShowDialog();
        }



        
    }
}
