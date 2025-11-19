using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINALSSS
{
    public partial class EditStatus: Form
    {
        private int orderId;
        private string currentStatus;
        public EditStatus(int id, string status)
        {
            InitializeComponent();

            orderId = id;
            currentStatus = status;

            // Display OrderID on label
            lblOrderID.Text = "Order ID: " + orderId.ToString();
            cmbEditStatus.SelectedItem = currentStatus;

        }

        private void btnUpdateEditStatus_Click(object sender, EventArgs e)
        {
            if (cmbEditStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Orders SET Status = @status WHERE OrderID = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", cmbEditStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@id", orderId);

                cmd.ExecuteNonQuery();
            }

            

            this.Close();
        }

        private void btnCancelEditStatus_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void EditStatus_Load(object sender, EventArgs e)
        {
            
        }
    }
}
