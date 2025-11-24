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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Status";
            // 
            // cmbEditStatus
            // 
            this.cmbEditStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditStatus.FormattingEnabled = true;
            this.cmbEditStatus.Items.AddRange(new object[] {
            "Processing",
            "Delivered",
            "Cancelled"});
            this.cmbEditStatus.Location = new System.Drawing.Point(116, 127);
            this.cmbEditStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEditStatus.Name = "cmbEditStatus";
            this.cmbEditStatus.Size = new System.Drawing.Size(110, 24);
            this.cmbEditStatus.TabIndex = 1;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(145, 89);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(59, 19);
            this.lblOrderID.TabIndex = 2;
            this.lblOrderID.Text = "OrderID";
            // 
            // btnUpdateEditStatus
            // 
            this.btnUpdateEditStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdateEditStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateEditStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEditStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEditStatus.Location = new System.Drawing.Point(58, 188);
            this.btnUpdateEditStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateEditStatus.Name = "btnUpdateEditStatus";
            this.btnUpdateEditStatus.Size = new System.Drawing.Size(100, 34);
            this.btnUpdateEditStatus.TabIndex = 3;
            this.btnUpdateEditStatus.Text = "Update";
            this.btnUpdateEditStatus.UseVisualStyleBackColor = false;
            this.btnUpdateEditStatus.Click += new System.EventHandler(this.btnUpdateEditStatus_Click);
            // 
            // btnCancelEditStatus
            // 
            this.btnCancelEditStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancelEditStatus.FlatAppearance.BorderSize = 0;
            this.btnCancelEditStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEditStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditStatus.Location = new System.Drawing.Point(177, 188);
            this.btnCancelEditStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelEditStatus.Name = "btnCancelEditStatus";
            this.btnCancelEditStatus.Size = new System.Drawing.Size(100, 34);
            this.btnCancelEditStatus.TabIndex = 4;
            this.btnCancelEditStatus.Text = "Cancel";
            this.btnCancelEditStatus.UseVisualStyleBackColor = false;
            this.btnCancelEditStatus.Click += new System.EventHandler(this.btnCancelEditStatus_Click);
            // 
            // EditStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(350, 245);
            this.Controls.Add(this.btnCancelEditStatus);
            this.Controls.Add(this.btnUpdateEditStatus);
            this.Controls.Add(this.lblOrderID);
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
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnUpdateEditStatus;
        private System.Windows.Forms.Button btnCancelEditStatus;
    }
}