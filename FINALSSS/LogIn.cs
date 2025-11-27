using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace FINALSSS
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = 40; // change this

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            this.Region = new Region(path);
        }
        public void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(path);
        }
        private void UserLogIn_Load(object sender, EventArgs e)
        {
            RoundControl(Username, 20);
            RoundControl(Password, 20);
            RoundControl(btnLogin, 20);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Optional: handle text change if needed
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = Username.Text;
            var password = Password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid!");
                return;
            }

            using (var conn = new MySqlConnection(DBconnection.ConnectionString))
            {
                conn.Open();
                // We select ONLY the hash based on the username
                string query = @"SELECT UserID, Username, Password, Role FROM users WHERE Username = @user";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("YOW");
                        return;
                    }

                    var originalPassword = reader["Password"].ToString();

                    if (password != originalPassword)
                    {
                        MessageBox.Show("Bro!!");
                        return;
                    }

                    Session.UserID = Convert.ToInt32(reader["UserID"]);
                    Session.Username = reader["Username"].ToString();
                    Session.Role = reader["Role"].ToString();

                    this.DialogResult = DialogResult.OK;
                    this.Hide();

                }
            }

            //bool loginSuccess = true; // Replace with real validation

            //if (loginSuccess)
            //{
            //    this.DialogResult = DialogResult.OK; // signals success
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid credentials.", "Login Failed",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
