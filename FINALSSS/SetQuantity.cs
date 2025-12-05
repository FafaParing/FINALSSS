using System;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class SetQuantity : Form
    {
        public int SelectedQuantity => (int)numQuantity.Value;

        public SetQuantity(string itemName, int currentStock)
        {
            InitializeComponent();
            lblItemName.Text = itemName;
            lblCurrentStock.Text = currentStock.ToString();
            numQuantity.Maximum = currentStock;
            numQuantity.Value = 1;

            btnOkay.Click += (s, e) => { this.DialogResult = DialogResult.OK; this.Close(); };
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
        }

        private void SetQuantity_Load(object sender, EventArgs e)
        {
            // No extra code needed here
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
