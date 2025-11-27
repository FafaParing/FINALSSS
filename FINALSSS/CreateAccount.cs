using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FINALSSS
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = Username.Text.Trim();
            var password = Password.Text.Trim();

            //MessageBox.Show($"Username: {username}, Password: {password}");

            using (var conn = new MySqlConnection(DBconnection.ConnectionString))
            {
                conn.Open();

                string query = @"INSERT INTO users (Username, Password) VALUES (@User, @Password)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@User", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    cmd.ExecuteNonQuery();

                    this.Close();

                    MessageBox.Show("User successfully added!");
                }
            }
        }
    }
}
