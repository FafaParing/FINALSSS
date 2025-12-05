namespace FINALSSS
{
    partial class AddStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentQuantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numAddQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnCancelStock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numAddQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(192, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblItemName.Location = new System.Drawing.Point(202, 125);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(138, 30);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "lblItemName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(21, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Quantity:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCurrentQuantity
            // 
            this.lblCurrentQuantity.AutoSize = true;
            this.lblCurrentQuantity.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblCurrentQuantity.Location = new System.Drawing.Point(153, 216);
            this.lblCurrentQuantity.Name = "lblCurrentQuantity";
            this.lblCurrentQuantity.Size = new System.Drawing.Size(122, 30);
            this.lblCurrentQuantity.TabIndex = 4;
            this.lblCurrentQuantity.Text = "lblCurQuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(303, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity to Add:";
            // 
            // numAddQuantity
            // 
            this.numAddQuantity.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.numAddQuantity.Location = new System.Drawing.Point(351, 210);
            this.numAddQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numAddQuantity.Name = "numAddQuantity";
            this.numAddQuantity.Size = new System.Drawing.Size(99, 36);
            this.numAddQuantity.TabIndex = 6;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateStock.FlatAppearance.BorderSize = 0;
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStock.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateStock.Location = new System.Drawing.Point(100, 288);
            this.btnUpdateStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(147, 52);
            this.btnUpdateStock.TabIndex = 7;
            this.btnUpdateStock.Text = "Add";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnCancelStock
            // 
            this.btnCancelStock.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancelStock.FlatAppearance.BorderSize = 0;
            this.btnCancelStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelStock.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelStock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelStock.Location = new System.Drawing.Point(294, 288);
            this.btnCancelStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelStock.Name = "btnCancelStock";
            this.btnCancelStock.Size = new System.Drawing.Size(147, 52);
            this.btnCancelStock.TabIndex = 8;
            this.btnCancelStock.Text = "Cancel";
            this.btnCancelStock.UseVisualStyleBackColor = false;
            this.btnCancelStock.Click += new System.EventHandler(this.btnCancelStock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 62);
            this.panel1.TabIndex = 16;
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(538, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelStock);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.numAddQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCurrentQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAddQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAddQuantity;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnCancelStock;
        private System.Windows.Forms.Panel panel1;
    }
}