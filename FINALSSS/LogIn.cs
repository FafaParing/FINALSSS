using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

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
