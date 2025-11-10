using System;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class EditItem : Form
    {
        private int itemId;

        public EditItem(int id, string name, string category, decimal price, string status)
        {
            InitializeComponent();
            itemId = id;

            txtEditItemName.Text = name;
            cmbEditCategory.Text = category;
            numEditPrice.Value = price;
            cmbStatus.Text = status;
        }
        public EditItem()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {

        }
    }
}