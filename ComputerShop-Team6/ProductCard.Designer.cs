namespace ComputerShop_Team6
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnShowProduct = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSKU = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pbProductPhoto = new System.Windows.Forms.PictureBox();
            this.pnShowProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnShowProduct
            // 
            this.pnShowProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnShowProduct.BorderColor = System.Drawing.Color.Black;
            this.pnShowProduct.BorderRadius = 10;
            this.pnShowProduct.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnShowProduct.Controls.Add(this.pbProductPhoto);
            this.pnShowProduct.Controls.Add(this.label1);
            this.pnShowProduct.Controls.Add(this.btnDetail);
            this.pnShowProduct.Controls.Add(this.lblStock);
            this.pnShowProduct.Controls.Add(this.lblSalePrice);
            this.pnShowProduct.Controls.Add(this.lblProductName);
            this.pnShowProduct.Controls.Add(this.lblSKU);
            this.pnShowProduct.Controls.Add(this.lblCategory);
            this.pnShowProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnShowProduct.Location = new System.Drawing.Point(0, 0);
            this.pnShowProduct.Name = "pnShowProduct";
            this.pnShowProduct.Size = new System.Drawing.Size(279, 250);
            this.pnShowProduct.TabIndex = 4;
            this.pnShowProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.pnShowProduct_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnDetail.Size = new System.Drawing.Size(259, 45);
            this.btnDetail.TabIndex = 5;
            this.btnDetail.Text = "Detail";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(17, 143);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(58, 25);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.Location = new System.Drawing.Point(15, 99);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(101, 30);
            this.lblSalePrice.TabIndex = 3;
            this.lblSalePrice.Text = "SalePrice";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(14, 58);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(172, 32);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "ProductName";
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Location = new System.Drawing.Point(87, 18);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(41, 25);
            this.lblSKU.TabIndex = 1;
            this.lblSKU.Text = "sku";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(17, 18);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(48, 25);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "cate";
            // 
            // pbProductPhoto
            // 
            this.pbProductPhoto.Location = new System.Drawing.Point(171, 18);
            this.pbProductPhoto.Name = "pbProductPhoto";
            this.pbProductPhoto.Size = new System.Drawing.Size(105, 106);
            this.pbProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductPhoto.TabIndex = 7;
            this.pbProductPhoto.TabStop = false;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnShowProduct);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(279, 250);
            this.pnShowProduct.ResumeLayout(false);
            this.pnShowProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnShowProduct;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbProductPhoto;
    }
}
