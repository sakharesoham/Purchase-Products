namespace Purchase_Entry_of_Products
{
    partial class frmNewProductInfo
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblMRP = new System.Windows.Forms.Label();
            this.lblSAC = new System.Windows.Forms.Label();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHSNCode = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductMRP = new System.Windows.Forms.TextBox();
            this.txtProductSAC = new System.Windows.Forms.TextBox();
            this.txtProductHSNCode = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.cmbModelName = new System.Windows.Forms.ComboBox();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvNewProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(59, 145);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(104, 19);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(59, 78);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(116, 19);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Location = new System.Drawing.Point(532, 75);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(46, 19);
            this.lblMRP.TabIndex = 2;
            this.lblMRP.Text = "MRP";
            // 
            // lblSAC
            // 
            this.lblSAC.AutoSize = true;
            this.lblSAC.Location = new System.Drawing.Point(532, 206);
            this.lblSAC.Name = "lblSAC";
            this.lblSAC.Size = new System.Drawing.Size(75, 19);
            this.lblSAC.TabIndex = 3;
            this.lblSAC.Text = "SAC code";
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(78, 214);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(97, 19);
            this.lblModelName.TabIndex = 5;
            this.lblModelName.Text = "Model Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(78, 291);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 19);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // lblHSNCode
            // 
            this.lblHSNCode.AutoSize = true;
            this.lblHSNCode.Location = new System.Drawing.Point(532, 142);
            this.lblHSNCode.Name = "lblHSNCode";
            this.lblHSNCode.Size = new System.Drawing.Size(81, 19);
            this.lblHSNCode.TabIndex = 7;
            this.lblHSNCode.Text = "HSN Code";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(202, 142);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(210, 26);
            this.txtProductName.TabIndex = 8;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // txtProductMRP
            // 
            this.txtProductMRP.Location = new System.Drawing.Point(656, 68);
            this.txtProductMRP.Name = "txtProductMRP";
            this.txtProductMRP.Size = new System.Drawing.Size(210, 26);
            this.txtProductMRP.TabIndex = 9;
            this.txtProductMRP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductMRP_KeyDown);
            // 
            // txtProductSAC
            // 
            this.txtProductSAC.Location = new System.Drawing.Point(656, 203);
            this.txtProductSAC.Name = "txtProductSAC";
            this.txtProductSAC.Size = new System.Drawing.Size(210, 26);
            this.txtProductSAC.TabIndex = 10;
            this.txtProductSAC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductSAC_KeyDown);
            // 
            // txtProductHSNCode
            // 
            this.txtProductHSNCode.Location = new System.Drawing.Point(656, 135);
            this.txtProductHSNCode.Name = "txtProductHSNCode";
            this.txtProductHSNCode.Size = new System.Drawing.Size(210, 26);
            this.txtProductHSNCode.TabIndex = 11;
            this.txtProductHSNCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductHSNCode_KeyDown);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(202, 284);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(210, 26);
            this.txtProductDescription.TabIndex = 12;
            this.txtProductDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductDescription_KeyDown);
            // 
            // cmbModelName
            // 
            this.cmbModelName.FormattingEnabled = true;
            this.cmbModelName.Location = new System.Drawing.Point(202, 206);
            this.cmbModelName.Name = "cmbModelName";
            this.cmbModelName.Size = new System.Drawing.Size(210, 27);
            this.cmbModelName.TabIndex = 14;
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(202, 75);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(210, 27);
            this.cmbCompanyName.TabIndex = 15;
            this.cmbCompanyName.SelectedIndexChanged += new System.EventHandler(this.cmbCompanyName_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(291, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(504, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvNewProduct
            // 
            this.dgvNewProduct.AllowUserToAddRows = false;
            this.dgvNewProduct.AllowUserToDeleteRows = false;
            this.dgvNewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvNewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dgvNewProduct.Location = new System.Drawing.Point(63, 408);
            this.dgvNewProduct.Name = "dgvNewProduct";
            this.dgvNewProduct.ReadOnly = true;
            this.dgvNewProduct.Size = new System.Drawing.Size(906, 261);
            this.dgvNewProduct.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "New Product Information";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Company Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "MRP ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "SAC Code";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Model Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Desciption";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "HSN Code";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // frmNewProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNewProduct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbCompanyName);
            this.Controls.Add(this.cmbModelName);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductHSNCode);
            this.Controls.Add(this.txtProductSAC);
            this.Controls.Add(this.txtProductMRP);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblHSNCode);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblModelName);
            this.Controls.Add(this.lblSAC);
            this.Controls.Add(this.lblMRP);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblProductName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNewProductInfo";
            this.Text = "frmNewProductInfo";
            this.Load += new System.EventHandler(this.frmNewProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.Label lblSAC;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblHSNCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductMRP;
        private System.Windows.Forms.TextBox txtProductSAC;
        private System.Windows.Forms.TextBox txtProductHSNCode;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.ComboBox cmbModelName;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvNewProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}