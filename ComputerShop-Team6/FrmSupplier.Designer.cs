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
            this.dgvsupplier = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsupplier
            // 
            this.dgvsupplier.AllowUserToAddRows = false;
            this.dgvsupplier.AllowUserToDeleteRows = false;
            this.dgvsupplier.AllowUserToOrderColumns = true;
            this.dgvsupplier.AllowUserToResizeColumns = false;
            this.dgvsupplier.AllowUserToResizeRows = false;
            this.dgvsupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvsupplier.Location = new System.Drawing.Point(12, 569);
            this.dgvsupplier.Name = "dgvsupplier";
            this.dgvsupplier.RowHeadersWidth = 51;
            this.dgvsupplier.RowTemplate.Height = 24;
            this.dgvsupplier.Size = new System.Drawing.Size(1549, 332);
            this.dgvsupplier.TabIndex = 29;
            this.dgvsupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsupplier_CellClick);
            this.dgvsupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsupplier_CellContentClick);
            this.dgvsupplier.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvsupplier_CellFormatting);
            this.dgcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcustomer.Location = new System.Drawing.Point(47, 462);
            this.dgcustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgcustomer.Name = "dgcustomer";
            this.dgcustomer.RowHeadersWidth = 51;
            this.dgcustomer.RowTemplate.Height = 24;
            this.dgcustomer.Size = new System.Drawing.Size(1142, 270);
            this.dgcustomer.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SupplierID";
            this.Column1.HeaderText = "Supplier Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CompanyName";
            this.Column2.HeaderText = "Compay Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SupplierName";
            this.Column3.HeaderText = "Supplier Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DOB";
            this.Column4.HeaderText = "Date of Brith";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "POB";
            this.Column5.HeaderText = "Place of Brith";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Address";
            this.Column6.HeaderText = "Address";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PhoneNumber";
            this.Column7.HeaderText = "Phone Number";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Blue;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(1073, 444);
            this.btndelete.Location = new System.Drawing.Point(757, 366);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(164, 59);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Blue;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(738, 444);
            this.btnupdate.Location = new System.Drawing.Point(501, 366);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(164, 59);
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
            this.btnaddnew.Location = new System.Drawing.Point(257, 370);
            this.btnaddnew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(164, 55);
            this.btnaddnew.TabIndex = 26;
            this.btnaddnew.Text = "Add New";
            this.btnaddnew.UseVisualStyleBackColor = false;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsuppliername.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsuppliername.Location = new System.Drawing.Point(498, 268);
            this.txtsuppliername.Multiline = true;
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(262, 45);
            this.txtsuppliername.TabIndex = 23;
            this.txtctphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtctphone.Location = new System.Drawing.Point(268, 192);
            this.txtctphone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtctphone.Multiline = true;
            this.txtctphone.Name = "txtctphone";
            this.txtctphone.Size = new System.Drawing.Size(197, 37);
            this.txtctphone.TabIndex = 23;
            // 
            // txtcompayname
            // 
            this.txtcompayname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcompayname.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompayname.Location = new System.Drawing.Point(498, 187);
            this.txtcompayname.Multiline = true;
            this.txtcompayname.Name = "txtcompayname";
            this.txtcompayname.Size = new System.Drawing.Size(262, 44);
            this.txtcompayname.TabIndex = 22;
            this.txtctname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtctname.Location = new System.Drawing.Point(268, 145);
            this.txtctname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtctname.Multiline = true;
            this.txtctname.Name = "txtctname";
            this.txtctname.Size = new System.Drawing.Size(197, 36);
            this.txtctname.TabIndex = 22;
            // 
            // txtsupplierid
            // 
            this.txtsupplierid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsupplierid.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupplierid.Location = new System.Drawing.Point(498, 108);
            this.txtsupplierid.Multiline = true;
            this.txtsupplierid.Name = "txtsupplierid";
            this.txtsupplierid.Size = new System.Drawing.Size(262, 44);
            this.txtsupplierid.TabIndex = 21;
            this.txtctid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtctid.Location = new System.Drawing.Point(268, 93);
            this.txtctid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtctid.Multiline = true;
            this.txtctid.Name = "txtctid";
            this.txtctid.Size = new System.Drawing.Size(197, 36);
            this.txtctid.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(792, 108);
            this.label6.Location = new System.Drawing.Point(94, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 34);
            this.label6.Size = new System.Drawing.Size(59, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "Place of Brith";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 364);
            this.label5.Location = new System.Drawing.Point(94, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 278);
            this.label4.Location = new System.Drawing.Point(94, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 193);
            this.label3.Location = new System.Drawing.Point(94, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Compay Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 108);
            this.label2.Location = new System.Drawing.Point(94, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = " Supplier Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(496, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 46);
            this.label1.Size = new System.Drawing.Size(211, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Supplier Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(792, 193);
            this.label7.Location = new System.Drawing.Point(488, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 27);
            this.label7.TabIndex = 30;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(792, 365);
            this.label8.Location = new System.Drawing.Point(488, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 27);
            this.label8.TabIndex = 31;
            this.label8.Text = "Phone Number";
            // 
            // txtdob
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(488, 304);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 27);
            this.label9.TabIndex = 32;
            this.label9.Text = "Satus";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1079, 280);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 21);
            this.label10.TabIndex = 33;
            this.label10.Text = "Photo";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(268, 240);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 38);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(268, 295);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 37);
            this.textBox2.TabIndex = 35;
            // 
            // textBox3
            // 
            this.txtdob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdob.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdob.Location = new System.Drawing.Point(498, 353);
            this.txtdob.Multiline = true;
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(262, 46);
            this.txtdob.TabIndex = 34;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(661, 93);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(251, 99);
            this.textBox3.TabIndex = 36;
            // 
            // txtpob
            // 
            this.txtpob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpob.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpob.Location = new System.Drawing.Point(1022, 97);
            this.txtpob.Multiline = true;
            this.txtpob.Name = "txtpob";
            this.txtpob.Size = new System.Drawing.Size(334, 45);
            this.txtpob.TabIndex = 35;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(661, 232);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(251, 37);
            this.textBox4.TabIndex = 37;
            // 
            // txtaddress
            // 
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(1022, 183);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(334, 121);
            this.txtaddress.TabIndex = 36;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(661, 297);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(251, 37);
            this.textBox5.TabIndex = 38;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphonenumber.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphonenumber.Location = new System.Drawing.Point(1022, 354);
            this.txtphonenumber.Multiline = true;
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(334, 45);
            this.txtphonenumber.TabIndex = 37;
            this.pictureBox1.Location = new System.Drawing.Point(1014, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 213);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 773);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtpob);
            this.Controls.Add(this.txtdob);
            this.ClientSize = new System.Drawing.Size(1282, 628);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvsupplier);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmSupplier";
            this.Text = "FrmSupplier";
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsupplier;
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
    }
}