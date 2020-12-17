namespace Purchase_Entry_of_Products
{
    partial class frmModelRegistration
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
            this.dgvModel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.lblModelRegistration = new System.Windows.Forms.Label();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModel
            // 
            this.dgvModel.AllowUserToAddRows = false;
            this.dgvModel.AllowUserToDeleteRows = false;
            this.dgvModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModel.BackgroundColor = System.Drawing.Color.White;
            this.dgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dgvModel.Location = new System.Drawing.Point(439, 86);
            this.dgvModel.Name = "dgvModel";
            this.dgvModel.ReadOnly = true;
            this.dgvModel.Size = new System.Drawing.Size(402, 150);
            this.dgvModel.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Model ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Company Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Model Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(712, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(586, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(194, 210);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(185, 26);
            this.txtModelName.TabIndex = 9;
            this.txtModelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtModelName_KeyDown);
            // 
            // lblModelRegistration
            // 
            this.lblModelRegistration.AutoSize = true;
            this.lblModelRegistration.Location = new System.Drawing.Point(358, 21);
            this.lblModelRegistration.Name = "lblModelRegistration";
            this.lblModelRegistration.Size = new System.Drawing.Size(140, 19);
            this.lblModelRegistration.TabIndex = 8;
            this.lblModelRegistration.Text = "Model Registration";
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(43, 217);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(97, 19);
            this.lblModelName.TabIndex = 7;
            this.lblModelName.Text = "Model Name";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(43, 158);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(116, 19);
            this.lblCompanyName.TabIndex = 13;
            this.lblCompanyName.Text = "Company Name";
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(194, 150);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(185, 27);
            this.cmbCompanyName.TabIndex = 14;
            this.cmbCompanyName.SelectedIndexChanged += new System.EventHandler(this.cmbCompanyName_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(43, 273);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 19);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(194, 270);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(185, 49);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // frmModelRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 381);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.dgvModel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.lblModelRegistration);
            this.Controls.Add(this.lblModelName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModelRegistration";
            this.Text = "frmModelRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label lblModelRegistration;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}