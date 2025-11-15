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
    public partial class SetQuantity: Form
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

        }
    }
}
