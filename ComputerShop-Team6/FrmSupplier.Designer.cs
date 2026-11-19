namespace ComputerShop_Team6
{
    partial class FrmSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            this.txtcompayname = new System.Windows.Forms.TextBox();
            this.txtsupplierid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.txtpob = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(63, 569);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1517, 332);
            this.dataGridView1.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Supplier Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Compay Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Supplier Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date of Brith";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Place of Brith";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Phone Number";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Satus";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Photo";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Blue;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(1073, 444);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(219, 73);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Blue;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(738, 444);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(219, 73);
            this.btnupdate.TabIndex = 27;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnaddnew
            // 
            this.btnaddnew.BackColor = System.Drawing.Color.Blue;
            this.btnaddnew.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddnew.Location = new System.Drawing.Point(407, 449);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(219, 68);
            this.btnaddnew.TabIndex = 26;
            this.btnaddnew.Text = "Add New";
            this.btnaddnew.UseVisualStyleBackColor = false;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsuppliername.Location = new System.Drawing.Point(498, 268);
            this.txtsuppliername.Multiline = true;
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(262, 45);
            this.txtsuppliername.TabIndex = 23;
            // 
            // txtcompayname
            // 
            this.txtcompayname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcompayname.Location = new System.Drawing.Point(498, 187);
            this.txtcompayname.Multiline = true;
            this.txtcompayname.Name = "txtcompayname";
            this.txtcompayname.Size = new System.Drawing.Size(262, 44);
            this.txtcompayname.TabIndex = 22;
            // 
            // txtsupplierid
            // 
            this.txtsupplierid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsupplierid.Location = new System.Drawing.Point(498, 108);
            this.txtsupplierid.Multiline = true;
            this.txtsupplierid.Name = "txtsupplierid";
            this.txtsupplierid.Size = new System.Drawing.Size(262, 44);
            this.txtsupplierid.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(792, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 34);
            this.label6.TabIndex = 20;
            this.label6.Text = "Place of Brith";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 34);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 34);
            this.label4.TabIndex = 18;
            this.label4.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "Compay Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = " Supplier Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(662, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Supplier Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(792, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 34);
            this.label7.TabIndex = 30;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(792, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 34);
            this.label8.TabIndex = 31;
            this.label8.Text = "Phone Number";
            // 
            // txtdob
            // 
            this.txtdob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdob.Location = new System.Drawing.Point(498, 353);
            this.txtdob.Multiline = true;
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(262, 46);
            this.txtdob.TabIndex = 34;
            // 
            // txtpob
            // 
            this.txtpob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpob.Location = new System.Drawing.Point(1022, 97);
            this.txtpob.Multiline = true;
            this.txtpob.Name = "txtpob";
            this.txtpob.Size = new System.Drawing.Size(334, 45);
            this.txtpob.TabIndex = 35;
            // 
            // txtaddress
            // 
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress.Location = new System.Drawing.Point(1022, 183);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(334, 121);
            this.txtaddress.TabIndex = 36;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphonenumber.Location = new System.Drawing.Point(1022, 354);
            this.txtphonenumber.Multiline = true;
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(334, 45);
            this.txtphonenumber.TabIndex = 37;
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 773);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtpob);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.txtsuppliername);
            this.Controls.Add(this.txtcompayname);
            this.Controls.Add(this.txtsupplierid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSupplier";
            this.Text = "FrmSupplier";
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.TextBox txtsuppliername;
        private System.Windows.Forms.TextBox txtcompayname;
        private System.Windows.Forms.TextBox txtsupplierid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.TextBox txtpob;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}