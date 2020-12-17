namespace Purchase_Entry_of_Products
{
    partial class frmPurchaseEntry
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblHSNCode = new System.Windows.Forms.Label();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblGSTRate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvReciept = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtRemainingAmount = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtGSTRate = new System.Windows.Forms.TextBox();
            this.txtHSNCode = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.cmbModelName = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReciept)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(29, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 19);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(308, 50);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(116, 19);
            this.lblInvoiceNo.TabIndex = 1;
            this.lblInvoiceNo.Text = "Invoice Number";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(611, 50);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(108, 19);
            this.lblSupplierName.TabIndex = 2;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(29, 118);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(119, 19);
            this.lblContactNumber.TabIndex = 3;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(308, 118);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(104, 19);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name";
            // 
            // lblHSNCode
            // 
            this.lblHSNCode.AutoSize = true;
            this.lblHSNCode.Location = new System.Drawing.Point(611, 118);
            this.lblHSNCode.Name = "lblHSNCode";
            this.lblHSNCode.Size = new System.Drawing.Size(81, 19);
            this.lblHSNCode.TabIndex = 5;
            this.lblHSNCode.Text = "HSN Code";
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(308, 200);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(97, 19);
            this.lblModelName.TabIndex = 6;
            this.lblModelName.Text = "Model Name";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(29, 200);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(116, 19);
            this.lblCompanyName.TabIndex = 7;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblGSTRate
            // 
            this.lblGSTRate.AutoSize = true;
            this.lblGSTRate.Location = new System.Drawing.Point(611, 200);
            this.lblGSTRate.Name = "lblGSTRate";
            this.lblGSTRate.Size = new System.Drawing.Size(77, 19);
            this.lblGSTRate.TabIndex = 8;
            this.lblGSTRate.Text = "GST Rate";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(78, 261);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(67, 19);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(308, 261);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(42, 19);
            this.lblRate.TabIndex = 10;
            this.lblRate.Text = "Rate";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(510, 257);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(61, 19);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(473, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Purchase Entry";
            // 
            // dgvReciept
            // 
            this.dgvReciept.AllowUserToAddRows = false;
            this.dgvReciept.AllowUserToDeleteRows = false;
            this.dgvReciept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReciept.BackgroundColor = System.Drawing.Color.White;
            this.dgvReciept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReciept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column7,
            this.Column8});
            this.dgvReciept.Location = new System.Drawing.Point(33, 308);
            this.dgvReciept.Name = "dgvReciept";
            this.dgvReciept.ReadOnly = true;
            this.dgvReciept.Size = new System.Drawing.Size(948, 192);
            this.dgvReciept.TabIndex = 13;
            this.dgvReciept.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReciept_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Company";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Model";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "HSN Code";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "QTY";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Rate";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "GST Rate";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "GST Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Amount";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(73, 526);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(98, 19);
            this.lblTotalAmount.TabIndex = 15;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(408, 526);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(40, 19);
            this.lblGST.TabIndex = 16;
            this.lblGST.Text = "GST";
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Location = new System.Drawing.Point(743, 526);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(89, 19);
            this.lblNetAmount.TabIndex = 17;
            this.lblNetAmount.Text = "Net Amount";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Location = new System.Drawing.Point(78, 580);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(93, 19);
            this.lblPaidAmount.TabIndex = 18;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // lblRemainingAmount
            // 
            this.lblRemainingAmount.AutoSize = true;
            this.lblRemainingAmount.Location = new System.Drawing.Point(676, 583);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(136, 19);
            this.lblRemainingAmount.TabIndex = 19;
            this.lblRemainingAmount.Text = "Remaining Amount";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(412, 651);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(562, 651);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtRemainingAmount
            // 
            this.txtRemainingAmount.Location = new System.Drawing.Point(841, 580);
            this.txtRemainingAmount.Name = "txtRemainingAmount";
            this.txtRemainingAmount.Size = new System.Drawing.Size(100, 26);
            this.txtRemainingAmount.TabIndex = 22;
            this.txtRemainingAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemainingAmount_KeyDown);
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(186, 577);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(100, 26);
            this.txtPaidAmount.TabIndex = 23;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtPaidAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidAmount_KeyDown);
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(841, 519);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(100, 26);
            this.txtNetAmount.TabIndex = 24;
            this.txtNetAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNetAmount_KeyDown);
            // 
            // txtGST
            // 
            this.txtGST.Location = new System.Drawing.Point(456, 519);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(100, 26);
            this.txtGST.TabIndex = 25;
            this.txtGST.TextChanged += new System.EventHandler(this.txtGST_TextChanged);
            this.txtGST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGST_KeyDown);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(186, 519);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 26);
            this.txtTotalAmount.TabIndex = 26;
            this.txtTotalAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalAmount_KeyDown);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(590, 254);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(158, 26);
            this.txtAmount.TabIndex = 27;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(369, 254);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 26);
            this.txtRate.TabIndex = 28;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyDown);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(154, 257);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 26);
            this.txtQuantity.TabIndex = 29;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // txtGSTRate
            // 
            this.txtGSTRate.Location = new System.Drawing.Point(727, 193);
            this.txtGSTRate.Name = "txtGSTRate";
            this.txtGSTRate.Size = new System.Drawing.Size(178, 26);
            this.txtGSTRate.TabIndex = 30;
            // 
            // txtHSNCode
            // 
            this.txtHSNCode.Location = new System.Drawing.Point(727, 111);
            this.txtHSNCode.Name = "txtHSNCode";
            this.txtHSNCode.Size = new System.Drawing.Size(178, 26);
            this.txtHSNCode.TabIndex = 31;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(154, 111);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(132, 26);
            this.txtContactNumber.TabIndex = 32;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(443, 43);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(141, 26);
            this.txtInvoiceNumber.TabIndex = 33;
            this.txtInvoiceNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoiceNumber_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(906, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(154, 197);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(132, 27);
            this.cmbCompanyName.TabIndex = 35;
            this.cmbCompanyName.SelectedIndexChanged += new System.EventHandler(this.cmbCompanyName_SelectedIndexChanged);
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(443, 110);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(141, 27);
            this.cmbProductName.TabIndex = 36;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(727, 47);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(178, 27);
            this.cmbSupplierName.TabIndex = 37;
            this.cmbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierName_SelectedIndexChanged);
            // 
            // cmbModelName
            // 
            this.cmbModelName.FormattingEnabled = true;
            this.cmbModelName.Location = new System.Drawing.Point(443, 192);
            this.cmbModelName.Name = "cmbModelName";
            this.cmbModelName.Size = new System.Drawing.Size(141, 27);
            this.cmbModelName.TabIndex = 38;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(86, 43);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 39;
            // 
            // frmPurchaseEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbModelName);
            this.Controls.Add(this.cmbSupplierName);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.cmbCompanyName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtHSNCode);
            this.Controls.Add(this.txtGSTRate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtGST);
            this.Controls.Add(this.txtNetAmount);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.txtRemainingAmount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRemainingAmount);
            this.Controls.Add(this.lblPaidAmount);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dgvReciept);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblGSTRate);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblModelName);
            this.Controls.Add(this.lblHSNCode);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPurchaseEntry";
            this.Text = "frmPurchaseEntry";
            this.Load += new System.EventHandler(this.frmPurchaseEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReciept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblHSNCode;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblGSTRate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvReciept;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lblRemainingAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtRemainingAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtGSTRate;
        private System.Windows.Forms.TextBox txtHSNCode;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.ComboBox cmbSupplierName;
        private System.Windows.Forms.ComboBox cmbModelName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

