namespace ComputerShop_Team6
{
    partial class frmProduct
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
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQtyInStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbProductPicture = new System.Windows.Forms.PictureBox();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnBrowe = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkInactive = new System.Windows.Forms.CheckBox();
            this.dgviewProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SKU";
            // 
            // txtSKU
            // 
            this.txtSKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSKU.Location = new System.Drawing.Point(140, 8);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(251, 39);
            this.txtSKU.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(140, 53);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(251, 39);
            this.txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Location = new System.Drawing.Point(140, 98);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(251, 39);
            this.txtBarcode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Supplier";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitPrice.Location = new System.Drawing.Point(518, 53);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(251, 39);
            this.txtUnitPrice.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Unit Price";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalePrice.Location = new System.Drawing.Point(518, 98);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(251, 39);
            this.txtSalePrice.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sale Price";
            // 
            // txtQtyInStock
            // 
            this.txtQtyInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtyInStock.Location = new System.Drawing.Point(518, 143);
            this.txtQtyInStock.Name = "txtQtyInStock";
            this.txtQtyInStock.Size = new System.Drawing.Size(251, 39);
            this.txtQtyInStock.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Qty in Stock";
            // 
            // pbProductPicture
            // 
            this.pbProductPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProductPicture.Location = new System.Drawing.Point(796, 8);
            this.pbProductPicture.Name = "pbProductPicture";
            this.pbProductPicture.Size = new System.Drawing.Size(158, 129);
            this.pbProductPicture.TabIndex = 16;
            this.pbProductPicture.TabStop = false;
            // 
            // cboSupplier
            // 
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(518, 8);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(251, 39);
            this.cboSupplier.TabIndex = 17;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(140, 143);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(251, 39);
            this.cboCategory.TabIndex = 18;
            // 
            // btnBrowe
            // 
            this.btnBrowe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowe.Location = new System.Drawing.Point(796, 143);
            this.btnBrowe.Name = "btnBrowe";
            this.btnBrowe.Size = new System.Drawing.Size(158, 39);
            this.btnBrowe.TabIndex = 19;
            this.btnBrowe.Text = "Browe...";
            this.btnBrowe.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Location = new System.Drawing.Point(983, 8);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(188, 53);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(983, 67);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 56);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(983, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(188, 53);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 31);
            this.label9.TabIndex = 23;
            this.label9.Text = "FIlter:";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkActive.Location = new System.Drawing.Point(75, 188);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(79, 35);
            this.chkActive.TabIndex = 24;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // chkInactive
            // 
            this.chkInactive.AutoSize = true;
            this.chkInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInactive.Location = new System.Drawing.Point(160, 188);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.Size = new System.Drawing.Size(93, 35);
            this.chkInactive.TabIndex = 25;
            this.chkInactive.Text = "InActive";
            this.chkInactive.UseVisualStyleBackColor = true;
            // 
            // dgviewProduct
            // 
            this.dgviewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewProduct.Location = new System.Drawing.Point(12, 224);
            this.dgviewProduct.Name = "dgviewProduct";
            this.dgviewProduct.RowHeadersWidth = 51;
            this.dgviewProduct.RowTemplate.Height = 24;
            this.dgviewProduct.Size = new System.Drawing.Size(1158, 406);
            this.dgviewProduct.TabIndex = 26;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 646);
            this.Controls.Add(this.dgviewProduct);
            this.Controls.Add(this.chkInactive);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnBrowe);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.pbProductPicture);
            this.Controls.Add(this.txtQtyInStock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQtyInStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbProductPicture;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnBrowe;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkInactive;
        private System.Windows.Forms.DataGridView dgviewProduct;
    }
}