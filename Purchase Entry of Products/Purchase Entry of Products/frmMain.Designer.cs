namespace Purchase_Entry_of_Products
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.companyRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductInforamationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyRegistrationToolStripMenuItem,
            this.modelRegistrationToolStripMenuItem,
            this.supplierRegistrationToolStripMenuItem,
            this.newProductInforamationToolStripMenuItem,
            this.billingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // companyRegistrationToolStripMenuItem
            // 
            this.companyRegistrationToolStripMenuItem.Name = "companyRegistrationToolStripMenuItem";
            this.companyRegistrationToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.companyRegistrationToolStripMenuItem.Text = "Company Registration";
            this.companyRegistrationToolStripMenuItem.Click += new System.EventHandler(this.companyRegistrationToolStripMenuItem_Click);
            // 
            // modelRegistrationToolStripMenuItem
            // 
            this.modelRegistrationToolStripMenuItem.Name = "modelRegistrationToolStripMenuItem";
            this.modelRegistrationToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.modelRegistrationToolStripMenuItem.Text = "Model Registration";
            this.modelRegistrationToolStripMenuItem.Click += new System.EventHandler(this.modelRegistrationToolStripMenuItem_Click);
            // 
            // supplierRegistrationToolStripMenuItem
            // 
            this.supplierRegistrationToolStripMenuItem.Name = "supplierRegistrationToolStripMenuItem";
            this.supplierRegistrationToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.supplierRegistrationToolStripMenuItem.Text = "Supplier Registration";
            this.supplierRegistrationToolStripMenuItem.Click += new System.EventHandler(this.supplierRegistrationToolStripMenuItem_Click);
            // 
            // newProductInforamationToolStripMenuItem
            // 
            this.newProductInforamationToolStripMenuItem.Name = "newProductInforamationToolStripMenuItem";
            this.newProductInforamationToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.newProductInforamationToolStripMenuItem.Text = "New Product Inforamation";
            this.newProductInforamationToolStripMenuItem.Click += new System.EventHandler(this.newProductInforamationToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.billingToolStripMenuItem.Text = "Billing";
            this.billingToolStripMenuItem.Click += new System.EventHandler(this.billingToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem companyRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProductInforamationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
    }
}