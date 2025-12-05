using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FINALSSS
{
    public partial class LogIn : Form
    {
        // Properties to store logged-in info
        public string LoggedInUsername { get; private set; }
        public string LoggedInUserRole { get; private set; }

        public LogIn()
        {
            InitializeComponent();
        }

        // Rounded form corners
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = 40;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            this.Region = new Region(path);
        }

        // Rounded controls (textboxes/buttons)
        public void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(path);
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            RoundControl(Username, 20);
            RoundControl(Password, 20);
            RoundControl(btnLogin, 20);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();
            string password = Password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new SqlConnection(DBconnection.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT Username, Password, Role FROM users WHERE Username = @user";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Username not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string dbPassword = reader["Password"].ToString();
                            string dbRole = reader["Role"].ToString();

                            if (password != dbPassword)
                            {
                                MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Successful login
                            LoggedInUsername = username;
                            LoggedInUserRole = dbRole;

                            // Open Main form and pass username + role
                            Main mainForm = new Main(LoggedInUsername, LoggedInUserRole);
                            mainForm.Show();

                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ask Admin for your account");
        }
    }
}
