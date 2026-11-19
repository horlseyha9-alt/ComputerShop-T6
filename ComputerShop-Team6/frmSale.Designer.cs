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
            this.flpProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
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
            // flpProduct
            // 
            this.flpProduct.Location = new System.Drawing.Point(20, 144);
            this.flpProduct.Name = "flpProduct";
            this.flpProduct.Size = new System.Drawing.Size(873, 590);
            this.flpProduct.TabIndex = 3;
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
            this.txtSearchProduct.Size = new System.Drawing.Size(873, 36);
            this.txtSearchProduct.TabIndex = 1;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchProduct;
        private System.Windows.Forms.FlowLayoutPanel flpProduct;
    }
}