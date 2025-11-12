using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Order has been successfully placed!",
                   "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelCustomerInformation.Visible = false;
            panelOrder.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelOrder.Visible = false;
            panelCustomerInformation.Visible = true;
        }
    }
}
