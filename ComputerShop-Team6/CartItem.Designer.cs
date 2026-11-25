namespace ComputerShop_Team6
{
    partial class CartItem
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
            this.lblProductname = new System.Windows.Forms.Label();
            this.lblProductprice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductname
            // 
            this.lblProductname.AutoSize = true;
            this.lblProductname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductname.Location = new System.Drawing.Point(15, 11);
            this.lblProductname.Name = "lblProductname";
            this.lblProductname.Size = new System.Drawing.Size(136, 25);
            this.lblProductname.TabIndex = 0;
            this.lblProductname.Text = "ProductName";
            // 
            // lblProductprice
            // 
            this.lblProductprice.AutoSize = true;
            this.lblProductprice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductprice.ForeColor = System.Drawing.Color.Gray;
            this.lblProductprice.Location = new System.Drawing.Point(16, 36);
            this.lblProductprice.Name = "lblProductprice";
            this.lblProductprice.Size = new System.Drawing.Size(104, 21);
            this.lblProductprice.TabIndex = 1;
            this.lblProductprice.Text = "ProductPrice";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(211, 31);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Qty";
            // 
            // btnMinus
            // 
            this.btnMinus.Image = global::ComputerShop_Team6.Properties.Resources.minus;
            this.btnMinus.Location = new System.Drawing.Point(174, 23);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(31, 34);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::ComputerShop_Team6.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(278, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Image = global::ComputerShop_Team6.Properties.Resources.plus;
            this.btnPlus.Location = new System.Drawing.Point(240, 23);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(32, 34);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblProductprice);
            this.Controls.Add(this.lblProductname);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(334, 68);
            this.Load += new System.EventHandler(this.CartItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductname;
        private System.Windows.Forms.Label lblProductprice;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblQty;
    }
}
