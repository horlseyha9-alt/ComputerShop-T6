namespace ComputerShop_Team6
{
    partial class frmSale
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
            this.txtSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.flpProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.pnShowProduct = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbSalePrice = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbSKU = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.flpProduct.SuspendLayout();
            this.pnShowProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale Product";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BackColor = System.Drawing.Color.White;
            this.txtSearchProduct.BorderColor = System.Drawing.Color.Black;
            this.txtSearchProduct.BorderRadius = 8;
            this.txtSearchProduct.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchProduct.DefaultText = "";
            this.txtSearchProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProduct.FillColor = System.Drawing.Color.DarkGray;
            this.txtSearchProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.txtSearchProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchProduct.IconLeft = global::ComputerShop_Team6.Properties.Resources.search;
            this.txtSearchProduct.Location = new System.Drawing.Point(20, 102);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtSearchProduct.PlaceholderText = "Seach product by name, SKU or barcode";
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.Size = new System.Drawing.Size(834, 36);
            this.txtSearchProduct.TabIndex = 1;
            // 
            // flpProduct
            // 
            this.flpProduct.Controls.Add(this.pnShowProduct);
            this.flpProduct.Location = new System.Drawing.Point(20, 144);
            this.flpProduct.Name = "flpProduct";
            this.flpProduct.Size = new System.Drawing.Size(834, 590);
            this.flpProduct.TabIndex = 3;
            // 
            // pnShowProduct
            // 
            this.pnShowProduct.BackColor = System.Drawing.Color.Silver;
            this.pnShowProduct.BorderColor = System.Drawing.Color.Black;
            this.pnShowProduct.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnShowProduct.Controls.Add(this.btnDetail);
            this.pnShowProduct.Controls.Add(this.lbStock);
            this.pnShowProduct.Controls.Add(this.lbSalePrice);
            this.pnShowProduct.Controls.Add(this.lbProductName);
            this.pnShowProduct.Controls.Add(this.lbSKU);
            this.pnShowProduct.Controls.Add(this.lbCategory);
            this.pnShowProduct.Location = new System.Drawing.Point(3, 3);
            this.pnShowProduct.Name = "pnShowProduct";
            this.pnShowProduct.Size = new System.Drawing.Size(274, 244);
            this.pnShowProduct.TabIndex = 3;
            // 
            // btnDetail
            // 
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.FillColor = System.Drawing.Color.Black;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(7, 182);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(253, 45);
            this.btnDetail.TabIndex = 5;
            this.btnDetail.Text = "Detail";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(27, 149);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(41, 17);
            this.lbStock.TabIndex = 4;
            this.lbStock.Text = "Stock";
            // 
            // lbSalePrice
            // 
            this.lbSalePrice.AutoSize = true;
            this.lbSalePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalePrice.Location = new System.Drawing.Point(15, 99);
            this.lbSalePrice.Name = "lbSalePrice";
            this.lbSalePrice.Size = new System.Drawing.Size(92, 25);
            this.lbSalePrice.TabIndex = 3;
            this.lbSalePrice.Text = "SalePrice";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(17, 60);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(92, 17);
            this.lbProductName.TabIndex = 2;
            this.lbProductName.Text = "ProductName";
            // 
            // lbSKU
            // 
            this.lbSKU.AutoSize = true;
            this.lbSKU.Location = new System.Drawing.Point(78, 18);
            this.lbSKU.Name = "lbSKU";
            this.lbSKU.Size = new System.Drawing.Size(29, 17);
            this.lbSKU.TabIndex = 1;
            this.lbSKU.Text = "sku";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(17, 18);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(33, 17);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "cate";
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 746);
            this.Controls.Add(this.flpProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSale";
            this.Text = "frmSale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.flpProduct.ResumeLayout(false);
            this.pnShowProduct.ResumeLayout(false);
            this.pnShowProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchProduct;
        private System.Windows.Forms.FlowLayoutPanel flpProduct;
        private Guna.UI2.WinForms.Guna2Panel pnShowProduct;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbSalePrice;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbSKU;
        private System.Windows.Forms.Label lbCategory;
    }
}