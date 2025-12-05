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
            this.btnUpdateEditStatus = new System.Windows.Forms.Button();
            this.btnCancelEditStatus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentStatus = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(129, 7);
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
            this.cmbEditStatus.Location = new System.Drawing.Point(110, 271);
            this.cmbEditStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEditStatus.Name = "cmbEditStatus";
            this.cmbEditStatus.Size = new System.Drawing.Size(145, 31);
            this.cmbEditStatus.TabIndex = 1;
            this.cmbEditStatus.SelectedIndexChanged += new System.EventHandler(this.cmbEditStatus_SelectedIndexChanged);
            // 
            // btnUpdateEditStatus
            // 
            this.btnUpdateEditStatus.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateEditStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateEditStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEditStatus.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnUpdateEditStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateEditStatus.Location = new System.Drawing.Point(64, 349);
            this.btnUpdateEditStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateEditStatus.Name = "btnUpdateEditStatus";
            this.btnUpdateEditStatus.Size = new System.Drawing.Size(106, 40);
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
            this.btnCancelEditStatus.Location = new System.Drawing.Point(190, 349);
            this.btnCancelEditStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelEditStatus.Name = "btnCancelEditStatus";
            this.btnCancelEditStatus.Size = new System.Drawing.Size(106, 40);
            this.btnCancelEditStatus.TabIndex = 4;
            this.btnCancelEditStatus.Text = "Cancel";
            this.btnCancelEditStatus.UseVisualStyleBackColor = false;
            this.btnCancelEditStatus.Click += new System.EventHandler(this.btnCancelEditStatus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(74, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(106, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Status: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(106, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCurrentStatus
            // 
            this.txtCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtCurrentStatus.Location = new System.Drawing.Point(110, 193);
            this.txtCurrentStatus.Name = "txtCurrentStatus";
            this.txtCurrentStatus.Size = new System.Drawing.Size(153, 31);
            this.txtCurrentStatus.TabIndex = 9;
            this.txtCurrentStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtName.Location = new System.Drawing.Point(78, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 31);
            this.txtName.TabIndex = 11;
            // 
            // EditStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(392, 409);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCurrentStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelEditStatus);
            this.Controls.Add(this.btnUpdateEditStatus);
            this.Controls.Add(this.cmbEditStatus);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnUpdateEditStatus;
        private System.Windows.Forms.Button btnCancelEditStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentStatus;
        private System.Windows.Forms.TextBox txtName;
    }
}