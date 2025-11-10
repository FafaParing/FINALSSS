using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FINALSSS
{
    public partial class AddStock: Form
    {
        private int itemId;
        private int currentQty;
        public AddStock(int id, string name, int qty)
        {
            InitializeComponent();
            itemId = id;
            currentQty = qty;

            lblItemName.Text = name;          // read-only
            lblCurrentQuantity.Text = qty.ToString(); // read-only
            numAddQuantity.Value = 1;       // default value
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            int addedQty = (int)numAddQuantity.Value;
            int newQty = currentQty + addedQty;

            // For now, update in-memory or DataGridView
            MessageBox.Show($"Stock updated! New quantity: {newQty}");

            // Close the form
            this.Close();
        }

        private void btnCancelStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
