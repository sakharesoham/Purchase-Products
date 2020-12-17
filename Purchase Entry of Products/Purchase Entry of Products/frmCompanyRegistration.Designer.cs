namespace Purchase_Entry_of_Products
{
    partial class frmCompanyRegistration
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyRegistration = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvCompany = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(25, 144);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(116, 19);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblCompanyRegistration
            // 
            this.lblCompanyRegistration.AutoSize = true;
            this.lblCompanyRegistration.Location = new System.Drawing.Point(351, 9);
            this.lblCompanyRegistration.Name = "lblCompanyRegistration";
            this.lblCompanyRegistration.Size = new System.Drawing.Size(159, 19);
            this.lblCompanyRegistration.TabIndex = 2;
            this.lblCompanyRegistration.Text = "Company Registration";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(180, 137);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(185, 26);
            this.txtCompanyName.TabIndex = 3;
            this.txtCompanyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyName_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(53, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(163, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvCompany
            // 
            this.dgvCompany.AllowUserToAddRows = false;
            this.dgvCompany.AllowUserToDeleteRows = false;
            this.dgvCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompany.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCompany.Location = new System.Drawing.Point(439, 119);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.ReadOnly = true;
            this.dgvCompany.Size = new System.Drawing.Size(402, 150);
            this.dgvCompany.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Company ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Company Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmCompanyRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 441);
            this.Controls.Add(this.dgvCompany);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyRegistration);
            this.Controls.Add(this.lblCompanyName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCompanyRegistration";
            this.Text = "frmCompanyRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyRegistration;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}