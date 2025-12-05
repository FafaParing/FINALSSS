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
            this.lblItemID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemID.ForeColor = System.Drawing.Color.Black;
            this.lblItemID.Location = new System.Drawing.Point(83, 98);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(85, 28);
            this.lblItemID.TabIndex = 0;
            this.lblItemID.Text = "Item ID:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.Black;
            this.lblItemName.Location = new System.Drawing.Point(55, 157);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(119, 28);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name:";
            this.lblItemName.Click += new System.EventHandler(this.lblItemName_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(68, 216);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(99, 28);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(100, 274);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 28);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(91, 339);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 28);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // lblItemNameValue
            // 
            this.lblItemNameValue.AutoSize = true;
            this.lblItemNameValue.Location = new System.Drawing.Point(150, 70);
            this.lblItemNameValue.Name = "lblItemNameValue";
            this.lblItemNameValue.Size = new System.Drawing.Size(0, 16);
            this.lblItemNameValue.TabIndex = 7;
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.AutoSize = true;
            this.lblCategoryValue.Location = new System.Drawing.Point(150, 134);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(0, 16);
            this.lblCategoryValue.TabIndex = 8;
            // 
            // lblQuantityValue
            // 
            this.lblQuantityValue.AutoSize = true;
            this.lblQuantityValue.Location = new System.Drawing.Point(153, 174);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.Size = new System.Drawing.Size(0, 16);
            this.lblQuantityValue.TabIndex = 9;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Location = new System.Drawing.Point(150, 190);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(0, 16);
            this.lblPriceValue.TabIndex = 10;
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Location = new System.Drawing.Point(150, 230);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(0, 16);
            this.lblStatusValue.TabIndex = 11;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSaveEdit.FlatAppearance.BorderSize = 0;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSaveEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveEdit.Location = new System.Drawing.Point(115, 408);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(113, 40);
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
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCancelEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelEdit.Location = new System.Drawing.Point(277, 408);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(113, 40);
            this.btnCancelEdit.TabIndex = 14;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // txtEditItemID
            // 
            this.txtEditItemID.Enabled = false;
            this.txtEditItemID.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtEditItemID.Location = new System.Drawing.Point(156, 94);
            this.txtEditItemID.Name = "txtEditItemID";
            this.txtEditItemID.Size = new System.Drawing.Size(187, 36);
            this.txtEditItemID.TabIndex = 15;
            // 
            // txtEditItemName
            // 
            this.txtEditItemName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtEditItemName.Location = new System.Drawing.Point(159, 157);
            this.txtEditItemName.Name = "txtEditItemName";
            this.txtEditItemName.Size = new System.Drawing.Size(231, 36);
            this.txtEditItemName.TabIndex = 16;
            // 
            // cmbEditCategory
            // 
            this.cmbEditCategory.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cmbEditCategory.FormattingEnabled = true;
            this.cmbEditCategory.Location = new System.Drawing.Point(156, 212);
            this.cmbEditCategory.Name = "cmbEditCategory";
            this.cmbEditCategory.Size = new System.Drawing.Size(187, 38);
            this.cmbEditCategory.TabIndex = 17;
            // 
            // numEditPrice
            // 
            this.numEditPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.numEditPrice.Location = new System.Drawing.Point(156, 270);
            this.numEditPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numEditPrice.Name = "numEditPrice";
            this.numEditPrice.Size = new System.Drawing.Size(85, 36);
            this.numEditPrice.TabIndex = 19;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "In Stock",
            "Out of Stock"});
            this.cmbStatus.Location = new System.Drawing.Point(156, 333);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(184, 38);
            this.cmbStatus.TabIndex = 20;
            // 
            // cmbEditUnit
            // 
            this.cmbEditUnit.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cmbEditUnit.FormattingEnabled = true;
            this.cmbEditUnit.Items.AddRange(new object[] {
            "ROLL",
            "PCS",
            "BOX"});
            this.cmbEditUnit.Location = new System.Drawing.Point(332, 270);
            this.cmbEditUnit.Name = "cmbEditUnit";
            this.cmbEditUnit.Size = new System.Drawing.Size(103, 38);
            this.cmbEditUnit.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(282, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Unit:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 58);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditItem
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(497, 475);
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
            this.Load += new System.EventHandler(this.EditItem_Load);
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
