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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtSearchCreateOrder = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCustomerInformation = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.dgvAvailableItems.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvailableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemID,
            this.colItemName,
            this.colCategory,
            this.colStock,
            this.colPrice,
            this.colUnit,
            this.colAdd});
            this.dgvAvailableItems.Location = new System.Drawing.Point(39, 177);
            this.dgvAvailableItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAvailableItems.MultiSelect = false;
            this.dgvAvailableItems.Name = "dgvAvailableItems";
            this.dgvAvailableItems.ReadOnly = true;
            this.dgvAvailableItems.RowHeadersVisible = false;
            this.dgvAvailableItems.RowHeadersWidth = 51;
            this.dgvAvailableItems.RowTemplate.Height = 24;
            this.dgvAvailableItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAvailableItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableItems.Size = new System.Drawing.Size(691, 574);
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
            this.colItemID.Visible = false;
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
            this.dgvCurrentItems.AllowUserToAddRows = false;
            this.dgvCurrentItems.AllowUserToDeleteRows = false;
            this.dgvCurrentItems.AllowUserToResizeColumns = false;
            this.dgvCurrentItems.AllowUserToResizeRows = false;
            this.dgvCurrentItems.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrentItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurrentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRemove,
            this.colItemID2,
            this.colItemName2,
            this.colQuantity,
            this.colPrice2,
            this.colSubtotal});
            this.dgvCurrentItems.Location = new System.Drawing.Point(772, 134);
            this.dgvCurrentItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCurrentItems.Name = "dgvCurrentItems";
            this.dgvCurrentItems.RowHeadersVisible = false;
            this.dgvCurrentItems.RowHeadersWidth = 51;
            this.dgvCurrentItems.RowTemplate.Height = 24;
            this.dgvCurrentItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCurrentItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentItems.Size = new System.Drawing.Size(700, 615);
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
            this.label1.Location = new System.Drawing.Point(688, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Order";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1311, 766);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.White;
            this.panelOrder.Controls.Add(this.panel1);
            this.panelOrder.Controls.Add(this.btnSearch);
            this.panelOrder.Controls.Add(this.txtSearchCreateOrder);
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
            this.panelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(1504, 825);
            this.panelOrder.TabIndex = 4;
            this.panelOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOrder_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 53);
            this.panel1.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(631, 140);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 33);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchCreateOrder
            // 
            this.txtSearchCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCreateOrder.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchCreateOrder.Location = new System.Drawing.Point(123, 140);
            this.txtSearchCreateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchCreateOrder.Multiline = true;
            this.txtSearchCreateOrder.Name = "txtSearchCreateOrder";
            this.txtSearchCreateOrder.Size = new System.Drawing.Size(505, 34);
            this.txtSearchCreateOrder.TabIndex = 12;
            this.txtSearchCreateOrder.Text = "Enter name";
            this.txtSearchCreateOrder.TextChanged += new System.EventHandler(this.txtSearchCreateOrder_TextChanged);
            this.txtSearchCreateOrder.MouseEnter += new System.EventHandler(this.txtSearchCreateOrder_MouseEnter);
            this.txtSearchCreateOrder.MouseLeave += new System.EventHandler(this.txtSearchCreateOrder_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(1141, 766);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 46);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1372, 101);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 29);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "lblTotal";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1305, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(33, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "All items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(765, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Order";
            // 
            // panelCustomerInformation
            // 
            this.panelCustomerInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCustomerInformation.Controls.Add(this.panel2);
            this.panelCustomerInformation.Controls.Add(this.button3);
            this.panelCustomerInformation.Controls.Add(this.btnPlaceOrder);
            this.panelCustomerInformation.Controls.Add(this.CustomerInformation);
            this.panelCustomerInformation.Controls.Add(this.OrderSummary);
            this.panelCustomerInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomerInformation.Location = new System.Drawing.Point(0, 0);
            this.panelCustomerInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCustomerInformation.Name = "panelCustomerInformation";
            this.panelCustomerInformation.Size = new System.Drawing.Size(1504, 825);
            this.panelCustomerInformation.TabIndex = 4;
            this.panelCustomerInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCustomerInformation_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1504, 62);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1504, 62);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(541, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(211, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "Add New Item";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1101, 766);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.DarkBlue;
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(1287, 766);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(169, 46);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Submit Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // CustomerInformation
            // 
            this.CustomerInformation.BackColor = System.Drawing.Color.LightGray;
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
            this.CustomerInformation.Location = new System.Drawing.Point(39, 112);
            this.CustomerInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerInformation.Name = "CustomerInformation";
            this.CustomerInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerInformation.Size = new System.Drawing.Size(607, 640);
            this.CustomerInformation.TabIndex = 0;
            this.CustomerInformation.TabStop = false;
            this.CustomerInformation.Enter += new System.EventHandler(this.CustomerInformation_Enter);
            // 
            // txtDeliverAdd
            // 
            this.txtDeliverAdd.BackColor = System.Drawing.Color.White;
            this.txtDeliverAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliverAdd.Location = new System.Drawing.Point(43, 405);
            this.txtDeliverAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeliverAdd.Multiline = true;
            this.txtDeliverAdd.Name = "txtDeliverAdd";
            this.txtDeliverAdd.Size = new System.Drawing.Size(508, 210);
            this.txtDeliverAdd.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Deliver Address*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Email address*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(191, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer Information";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(41, 251);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(365, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // txtContactNum
            // 
            this.txtContactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNum.Location = new System.Drawing.Point(41, 183);
            this.txtContactNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(223, 26);
            this.txtContactNum.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Contact Number*";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(41, 121);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(365, 26);
            this.txtCustomerName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Customer Name*";
            // 
            // OrderSummary
            // 
            this.OrderSummary.BackColor = System.Drawing.Color.LightGray;
            this.OrderSummary.Controls.Add(this.dgvOrderSummary);
            this.OrderSummary.Controls.Add(this.label7);
            this.OrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSummary.Location = new System.Drawing.Point(671, 112);
            this.OrderSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderSummary.Name = "OrderSummary";
            this.OrderSummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderSummary.Size = new System.Drawing.Size(785, 640);
            this.OrderSummary.TabIndex = 1;
            this.OrderSummary.TabStop = false;
            // 
            // dgvOrderSummary
            // 
            this.dgvOrderSummary.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemIDSummary,
            this.colItemNameSummary,
            this.colQuantitySummary,
            this.colPriceSummary,
            this.colSubTotalSummary});
            this.dgvOrderSummary.GridColor = System.Drawing.Color.Silver;
            this.dgvOrderSummary.Location = new System.Drawing.Point(24, 130);
            this.dgvOrderSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrderSummary.Name = "dgvOrderSummary";
            this.dgvOrderSummary.RowHeadersVisible = false;
            this.dgvOrderSummary.RowHeadersWidth = 51;
            this.dgvOrderSummary.RowTemplate.Height = 24;
            this.dgvOrderSummary.Size = new System.Drawing.Size(725, 485);
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
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(296, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Order Summary";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 825);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.panelCustomerInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSearchCreateOrder;
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
        private System.Windows.Forms.DataGridView dgvOrderSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemIDSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNameSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantitySummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotalSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewButtonColumn colAdd;
    }
}