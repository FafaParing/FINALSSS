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
    public partial class AddItemForm: Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Simple validation
            if (string.IsNullOrWhiteSpace(txtItemName.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepare new item data
            string newItemID = "001"; // Replace with logic to generate unique ID
            string itemName = txtItemName.Text;
            string category = cmbCategory.Text;
            int stock = (int)numStock.Value;
            decimal price = decimal.Parse(txtPrice.Text);
            string status = cmbStatus.Text;

            // Add row to dgvInventory on main form
            ((Main)this.Owner).dgvInventory.Rows.Add(newItemID, itemName, category, stock, price, status);

            // Close AddItemForm
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
