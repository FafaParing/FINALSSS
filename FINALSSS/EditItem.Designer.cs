namespace FINALSSS
{
    partial class EditItem
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblItemNameValue;
        private System.Windows.Forms.Label lblCategoryValue;
        private System.Windows.Forms.Label lblQuantityValue;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblStatusValue;

        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnCancelEdit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblItemNameValue = new System.Windows.Forms.Label();
            this.lblCategoryValue = new System.Windows.Forms.Label();
            this.lblQuantityValue = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.txtEditItemID = new System.Windows.Forms.TextBox();
            this.txtEditItemName = new System.Windows.Forms.TextBox();
            this.cmbEditCategory = new System.Windows.Forms.ComboBox();
            this.numEditPrice = new System.Windows.Forms.NumericUpDown();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbEditUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEditPrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblItemID.Location = new System.Drawing.Point(82, 79);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(59, 16);
            this.lblItemID.TabIndex = 0;
            this.lblItemID.Text = "Item ID:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblItemName.Location = new System.Drawing.Point(55, 135);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(85, 16);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCategory.Location = new System.Drawing.Point(69, 198);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(74, 16);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrice.Location = new System.Drawing.Point(97, 252);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(88, 312);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // lblItemNameValue
            // 
            this.lblItemNameValue.AutoSize = true;
            this.lblItemNameValue.Location = new System.Drawing.Point(150, 70);
            this.lblItemNameValue.Name = "lblItemNameValue";
            this.lblItemNameValue.Size = new System.Drawing.Size(0, 13);
            this.lblItemNameValue.TabIndex = 7;
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.AutoSize = true;
            this.lblCategoryValue.Location = new System.Drawing.Point(150, 110);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(0, 13);
            this.lblCategoryValue.TabIndex = 8;
            // 
            // lblQuantityValue
            // 
            this.lblQuantityValue.AutoSize = true;
            this.lblQuantityValue.Location = new System.Drawing.Point(150, 150);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.Size = new System.Drawing.Size(0, 13);
            this.lblQuantityValue.TabIndex = 9;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Location = new System.Drawing.Point(150, 190);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(0, 13);
            this.lblPriceValue.TabIndex = 10;
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Location = new System.Drawing.Point(150, 230);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(0, 13);
            this.lblStatusValue.TabIndex = 11;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.Blue;
            this.btnSaveEdit.FlatAppearance.BorderSize = 0;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveEdit.Location = new System.Drawing.Point(63, 379);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(148, 52);
            this.btnSaveEdit.TabIndex = 12;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelEdit.Location = new System.Drawing.Point(247, 379);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(148, 52);
            this.btnCancelEdit.TabIndex = 14;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // txtEditItemID
            // 
            this.txtEditItemID.Enabled = false;
            this.txtEditItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditItemID.Location = new System.Drawing.Point(174, 73);
            this.txtEditItemID.Name = "txtEditItemID";
            this.txtEditItemID.Size = new System.Drawing.Size(181, 23);
            this.txtEditItemID.TabIndex = 15;
            // 
            // txtEditItemName
            // 
            this.txtEditItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditItemName.Location = new System.Drawing.Point(174, 129);
            this.txtEditItemName.Name = "txtEditItemName";
            this.txtEditItemName.Size = new System.Drawing.Size(181, 23);
            this.txtEditItemName.TabIndex = 16;
            // 
            // cmbEditCategory
            // 
            this.cmbEditCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditCategory.FormattingEnabled = true;
            this.cmbEditCategory.Location = new System.Drawing.Point(174, 190);
            this.cmbEditCategory.Name = "cmbEditCategory";
            this.cmbEditCategory.Size = new System.Drawing.Size(181, 24);
            this.cmbEditCategory.TabIndex = 17;
            // 
            // numEditPrice
            // 
            this.numEditPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEditPrice.Location = new System.Drawing.Point(174, 246);
            this.numEditPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numEditPrice.Name = "numEditPrice";
            this.numEditPrice.Size = new System.Drawing.Size(78, 23);
            this.numEditPrice.TabIndex = 19;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(174, 304);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(184, 24);
            this.cmbStatus.TabIndex = 20;
            // 
            // cmbEditUnit
            // 
            this.cmbEditUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditUnit.FormattingEnabled = true;
            this.cmbEditUnit.Location = new System.Drawing.Point(319, 246);
            this.cmbEditUnit.Name = "cmbEditUnit";
            this.cmbEditUnit.Size = new System.Drawing.Size(39, 24);
            this.cmbEditUnit.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(269, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Unit:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 56);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(198, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditItem
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEditUnit);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.numEditPrice);
            this.Controls.Add(this.cmbEditCategory);
            this.Controls.Add(this.txtEditItemName);
            this.Controls.Add(this.txtEditItemID);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblItemNameValue);
            this.Controls.Add(this.lblCategoryValue);
            this.Controls.Add(this.lblQuantityValue);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblStatusValue);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.btnCancelEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "t";
            ((System.ComponentModel.ISupportInitialize)(this.numEditPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtEditItemID;
        private System.Windows.Forms.TextBox txtEditItemName;
        private System.Windows.Forms.ComboBox cmbEditCategory;
        private System.Windows.Forms.NumericUpDown numEditPrice;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbEditUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
