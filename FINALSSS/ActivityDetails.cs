using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class ActivityDetails: Form
    {
        private int logId;

        public ActivityDetails(int id)
        {
            InitializeComponent();
            logId = id;
            LoadDetails();
        }

        private void LoadDetails()
        {
            using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
            {
                string query = "SELECT ActionBy, ActionType, ActionDetails, ActionDate FROM ActivityLog WHERE LogID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", logId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblUser.Text = reader["ActionBy"].ToString();           // Label for User
                    lblAction.Text = reader["ActionType"].ToString();       // Label for Action
                    txtDetails.Text = reader["ActionDetails"].ToString();   // Multiline TextBox for full details
                    lblDate.Text = Convert.ToDateTime(reader["ActionDate"]).ToString("g"); // Label for Date
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
