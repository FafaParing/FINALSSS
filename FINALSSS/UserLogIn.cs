using System;
using System.Windows.Forms;

namespace FINALSSS
{
    public partial class UserLogIn : Form
    {
        public UserLogIn()
        {
            InitializeComponent();
        }

        private void UserLogIn_Load(object sender, EventArgs e)
        {
            // Optional: Any initialization code
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Optional: handle text change if needed
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginSuccess = true; // Replace with real validation

            if (loginSuccess)
            {
                this.DialogResult = DialogResult.OK; // signals success
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}
