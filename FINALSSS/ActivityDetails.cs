using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class ActivityDetails : Form
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
                    lblUser.Text = reader["ActionBy"].ToString();
                    lblAction.Text = reader["ActionType"].ToString();
                    txtDetails.Text = reader["ActionDetails"].ToString();
                    lblDate.Text = Convert.ToDateTime(reader["ActionDate"]).ToString("g");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActivityDetails_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
