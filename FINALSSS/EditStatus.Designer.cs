namespace FINALSSS
{
    partial class EditStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEditStatus = new System.Windows.Forms.ComboBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnUpdateEditStatus = new System.Windows.Forms.Button();
            this.btnCancelEditStatus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Status";
            // 
            // cmbEditStatus
            // 
            this.cmbEditStatus.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cmbEditStatus.FormattingEnabled = true;
            this.cmbEditStatus.Items.AddRange(new object[] {
            "Processing",
            "Delivered",
            "Cancelled"});
            this.cmbEditStatus.Location = new System.Drawing.Point(157, 297);
            this.cmbEditStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEditStatus.Name = "cmbEditStatus";
            this.cmbEditStatus.Size = new System.Drawing.Size(145, 31);
            this.cmbEditStatus.TabIndex = 1;
            this.cmbEditStatus.SelectedIndexChanged += new System.EventHandler(this.cmbEditStatus_SelectedIndexChanged);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderID.ForeColor = System.Drawing.Color.Black;
            this.lblOrderID.Location = new System.Drawing.Point(36, 89);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(70, 21);
            this.lblOrderID.TabIndex = 2;
            this.lblOrderID.Text = "OrderID";
            // 
            // btnUpdateEditStatus
            // 
            this.btnUpdateEditStatus.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateEditStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateEditStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEditStatus.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnUpdateEditStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateEditStatus.Location = new System.Drawing.Point(94, 363);
            this.btnUpdateEditStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateEditStatus.Name = "btnUpdateEditStatus";
            this.btnUpdateEditStatus.Size = new System.Drawing.Size(113, 40);
            this.btnUpdateEditStatus.TabIndex = 3;
            this.btnUpdateEditStatus.Text = "Update";
            this.btnUpdateEditStatus.UseVisualStyleBackColor = false;
            this.btnUpdateEditStatus.Click += new System.EventHandler(this.btnUpdateEditStatus_Click);
            // 
            // btnCancelEditStatus
            // 
            this.btnCancelEditStatus.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancelEditStatus.FlatAppearance.BorderSize = 0;
            this.btnCancelEditStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEditStatus.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCancelEditStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelEditStatus.Location = new System.Drawing.Point(286, 363);
            this.btnCancelEditStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelEditStatus.Name = "btnCancelEditStatus";
            this.btnCancelEditStatus.Size = new System.Drawing.Size(113, 40);
            this.btnCancelEditStatus.TabIndex = 4;
            this.btnCancelEditStatus.Text = "Cancel";
            this.btnCancelEditStatus.UseVisualStyleBackColor = false;
            this.btnCancelEditStatus.Click += new System.EventHandler(this.btnCancelEditStatus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(232, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(36, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(153, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Status: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(232, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox1.Location = new System.Drawing.Point(236, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 31);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox2.Location = new System.Drawing.Point(40, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 31);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox3.Location = new System.Drawing.Point(236, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 31);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox4.Location = new System.Drawing.Point(40, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 31);
            this.textBox4.TabIndex = 12;
            // 
            // EditStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(492, 425);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelEditStatus);
            this.Controls.Add(this.btnUpdateEditStatus);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.cmbEditStatus);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStatus";
            this.Load += new System.EventHandler(this.EditStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEditStatus;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnUpdateEditStatus;
        private System.Windows.Forms.Button btnCancelEditStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}