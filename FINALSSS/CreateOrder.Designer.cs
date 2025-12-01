namespace FINALSSS
{
    partial class CreateOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAvailableItems = new System.Windows.Forms.DataGridView();
            this.colItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvCurrentItems = new System.Windows.Forms.DataGridView();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colItemID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCustomerInformation = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.CustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtDeliverAdd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderSummary = new System.Windows.Forms.GroupBox();
            this.dgvOrderSummary = new System.Windows.Forms.DataGridView();
            this.colItemIDSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemNameSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantitySummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotalSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentItems)).BeginInit();
            this.panelOrder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCustomerInformation.SuspendLayout();
            this.CustomerInformation.SuspendLayout();
            this.OrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableItems
            // 
            this.dgvAvailableItems.AllowUserToAddRows = false;
            this.dgvAvailableItems.AllowUserToDeleteRows = false;
            this.dgvAvailableItems.AllowUserToResizeColumns = false;
            this.dgvAvailableItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAvailableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemID,
            this.colItemName,
            this.colCategory,
            this.colStock,
            this.colPrice,
            this.colUnit,
            this.colAdd});
            this.dgvAvailableItems.Location = new System.Drawing.Point(29, 144);
            this.dgvAvailableItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAvailableItems.MultiSelect = false;
            this.dgvAvailableItems.Name = "dgvAvailableItems";
            this.dgvAvailableItems.ReadOnly = true;
            this.dgvAvailableItems.RowHeadersVisible = false;
            this.dgvAvailableItems.RowHeadersWidth = 51;
            this.dgvAvailableItems.RowTemplate.Height = 24;
            this.dgvAvailableItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAvailableItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableItems.Size = new System.Drawing.Size(518, 466);
            this.dgvAvailableItems.TabIndex = 0;
            this.dgvAvailableItems.TabStop = false;
            this.dgvAvailableItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableItems_CellContentClick);
            // 
            // colItemID
            // 
            this.colItemID.HeaderText = "Item ID";
            this.colItemID.MinimumWidth = 6;
            this.colItemID.Name = "colItemID";
            this.colItemID.ReadOnly = true;
            this.colItemID.Width = 125;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Name";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Width = 125;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 125;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 125;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.MinimumWidth = 6;
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Width = 125;
            // 
            // colAdd
            // 
            this.colAdd.HeaderText = "";
            this.colAdd.MinimumWidth = 6;
            this.colAdd.Name = "colAdd";
            this.colAdd.ReadOnly = true;
            this.colAdd.Text = "Add";
            this.colAdd.UseColumnTextForButtonValue = true;
            this.colAdd.Width = 125;
            // 
            // dgvCurrentItems
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrentItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCurrentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRemove,
            this.colItemID2,
            this.colItemName2,
            this.colQuantity,
            this.colPrice2,
            this.colSubtotal});
            this.dgvCurrentItems.Location = new System.Drawing.Point(579, 109);
            this.dgvCurrentItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCurrentItems.Name = "dgvCurrentItems";
            this.dgvCurrentItems.RowHeadersVisible = false;
            this.dgvCurrentItems.RowHeadersWidth = 51;
            this.dgvCurrentItems.RowTemplate.Height = 24;
            this.dgvCurrentItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCurrentItems.Size = new System.Drawing.Size(525, 500);
            this.dgvCurrentItems.TabIndex = 1;
            this.dgvCurrentItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentItems_CellContentClick);
            // 
            // colRemove
            // 
            this.colRemove.HeaderText = "";
            this.colRemove.MinimumWidth = 6;
            this.colRemove.Name = "colRemove";
            this.colRemove.Text = "Remove";
            this.colRemove.Width = 125;
            // 
            // colItemID2
            // 
            this.colItemID2.HeaderText = "Item ID";
            this.colItemID2.MinimumWidth = 6;
            this.colItemID2.Name = "colItemID2";
            this.colItemID2.Width = 125;
            // 
            // colItemName2
            // 
            this.colItemName2.HeaderText = "Item Name";
            this.colItemName2.MinimumWidth = 6;
            this.colItemName2.Name = "colItemName2";
            this.colItemName2.Width = 200;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 125;
            // 
            // colPrice2
            // 
            this.colPrice2.HeaderText = "Price";
            this.colPrice2.MinimumWidth = 6;
            this.colPrice2.Name = "colPrice2";
            this.colPrice2.Width = 125;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Sub Total";
            this.colSubtotal.MinimumWidth = 6;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(516, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Order";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(983, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.panelOrder.Controls.Add(this.panel1);
            this.panelOrder.Controls.Add(this.btnSearch);
            this.panelOrder.Controls.Add(this.txtSearch);
            this.panelOrder.Controls.Add(this.btnCancel);
            this.panelOrder.Controls.Add(this.lblTotal);
            this.panelOrder.Controls.Add(this.label5);
            this.panelOrder.Controls.Add(this.label4);
            this.panelOrder.Controls.Add(this.label3);
            this.panelOrder.Controls.Add(this.dgvAvailableItems);
            this.panelOrder.Controls.Add(this.dgvCurrentItems);
            this.panelOrder.Controls.Add(this.button1);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(0, 0);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(2);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(1128, 670);
            this.panelOrder.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 43);
            this.panel1.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(473, 114);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 27);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(92, 114);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(380, 28);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.Text = "Search...";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(856, 622);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1029, 82);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 25);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "lblTotal";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(979, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "All items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Order";
            // 
            // panelCustomerInformation
            // 
            this.panelCustomerInformation.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelCustomerInformation.Controls.Add(this.button3);
            this.panelCustomerInformation.Controls.Add(this.btnPlaceOrder);
            this.panelCustomerInformation.Controls.Add(this.CustomerInformation);
            this.panelCustomerInformation.Controls.Add(this.OrderSummary);
            this.panelCustomerInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomerInformation.Location = new System.Drawing.Point(0, 0);
            this.panelCustomerInformation.Margin = new System.Windows.Forms.Padding(2);
            this.panelCustomerInformation.Name = "panelCustomerInformation";
            this.panelCustomerInformation.Size = new System.Drawing.Size(1128, 670);
            this.panelCustomerInformation.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(826, 622);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(965, 622);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(127, 37);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Submit Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // CustomerInformation
            // 
            this.CustomerInformation.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerInformation.Controls.Add(this.txtDeliverAdd);
            this.CustomerInformation.Controls.Add(this.label11);
            this.CustomerInformation.Controls.Add(this.label10);
            this.CustomerInformation.Controls.Add(this.label6);
            this.CustomerInformation.Controls.Add(this.txtEmail);
            this.CustomerInformation.Controls.Add(this.txtContactNum);
            this.CustomerInformation.Controls.Add(this.label9);
            this.CustomerInformation.Controls.Add(this.txtCustomerName);
            this.CustomerInformation.Controls.Add(this.label8);
            this.CustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInformation.Location = new System.Drawing.Point(29, 76);
            this.CustomerInformation.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerInformation.Name = "CustomerInformation";
            this.CustomerInformation.Padding = new System.Windows.Forms.Padding(2);
            this.CustomerInformation.Size = new System.Drawing.Size(455, 535);
            this.CustomerInformation.TabIndex = 0;
            this.CustomerInformation.TabStop = false;
            // 
            // txtDeliverAdd
            // 
            this.txtDeliverAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliverAdd.Location = new System.Drawing.Point(32, 329);
            this.txtDeliverAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliverAdd.Multiline = true;
            this.txtDeliverAdd.Name = "txtDeliverAdd";
            this.txtDeliverAdd.Size = new System.Drawing.Size(382, 171);
            this.txtDeliverAdd.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 302);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Deliver Address*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Email address*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer Information";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(32, 205);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtContactNum
            // 
            this.txtContactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNum.Location = new System.Drawing.Point(32, 132);
            this.txtContactNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(168, 23);
            this.txtContactNum.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Contact Number*";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(32, 79);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(275, 23);
            this.txtCustomerName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Customer Name*";
            // 
            // OrderSummary
            // 
            this.OrderSummary.BackColor = System.Drawing.SystemColors.Control;
            this.OrderSummary.Controls.Add(this.dgvOrderSummary);
            this.OrderSummary.Controls.Add(this.label7);
            this.OrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSummary.Location = new System.Drawing.Point(503, 76);
            this.OrderSummary.Margin = new System.Windows.Forms.Padding(2);
            this.OrderSummary.Name = "OrderSummary";
            this.OrderSummary.Padding = new System.Windows.Forms.Padding(2);
            this.OrderSummary.Size = new System.Drawing.Size(589, 535);
            this.OrderSummary.TabIndex = 1;
            this.OrderSummary.TabStop = false;
            // 
            // dgvOrderSummary
            // 
            this.dgvOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemIDSummary,
            this.colItemNameSummary,
            this.colQuantitySummary,
            this.colPriceSummary,
            this.colSubTotalSummary});
            this.dgvOrderSummary.Location = new System.Drawing.Point(24, 114);
            this.dgvOrderSummary.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrderSummary.Name = "dgvOrderSummary";
            this.dgvOrderSummary.RowHeadersVisible = false;
            this.dgvOrderSummary.RowHeadersWidth = 51;
            this.dgvOrderSummary.RowTemplate.Height = 24;
            this.dgvOrderSummary.Size = new System.Drawing.Size(544, 394);
            this.dgvOrderSummary.TabIndex = 3;
            // 
            // colItemIDSummary
            // 
            this.colItemIDSummary.HeaderText = "ID";
            this.colItemIDSummary.MinimumWidth = 6;
            this.colItemIDSummary.Name = "colItemIDSummary";
            this.colItemIDSummary.Width = 125;
            // 
            // colItemNameSummary
            // 
            this.colItemNameSummary.HeaderText = "Name";
            this.colItemNameSummary.MinimumWidth = 6;
            this.colItemNameSummary.Name = "colItemNameSummary";
            this.colItemNameSummary.Width = 125;
            // 
            // colQuantitySummary
            // 
            this.colQuantitySummary.HeaderText = "Quantity";
            this.colQuantitySummary.MinimumWidth = 6;
            this.colQuantitySummary.Name = "colQuantitySummary";
            this.colQuantitySummary.Width = 125;
            // 
            // colPriceSummary
            // 
            this.colPriceSummary.HeaderText = "Price";
            this.colPriceSummary.MinimumWidth = 6;
            this.colPriceSummary.Name = "colPriceSummary";
            this.colPriceSummary.Width = 125;
            // 
            // colSubTotalSummary
            // 
            this.colSubTotalSummary.HeaderText = "Sub Total";
            this.colSubTotalSummary.MinimumWidth = 6;
            this.colSubTotalSummary.Name = "colSubTotalSummary";
            this.colSubTotalSummary.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Order Summary";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 670);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.panelCustomerInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentItems)).EndInit();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCustomerInformation.ResumeLayout(false);
            this.CustomerInformation.ResumeLayout(false);
            this.CustomerInformation.PerformLayout();
            this.OrderSummary.ResumeLayout(false);
            this.OrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvailableItems;
        private System.Windows.Forms.DataGridView dgvCurrentItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelCustomerInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox OrderSummary;
        private System.Windows.Forms.GroupBox CustomerInformation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.TextBox txtDeliverAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewButtonColumn colAdd;
        private System.Windows.Forms.DataGridView dgvOrderSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemIDSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNameSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantitySummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotalSummary;
    }
}