namespace ComputerShop_Team6
{
    partial class frmCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtctid = new System.Windows.Forms.TextBox();
            this.txtctname = new System.Windows.Forms.TextBox();
            this.txtctphone = new System.Windows.Forms.TextBox();
            this.txtctaddress = new System.Windows.Forms.TextBox();
            this.txtctemail = new System.Windows.Forms.TextBox();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dgcustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(463, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(543, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // txtctid
            // 
            this.txtctid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtctid.Location = new System.Drawing.Point(236, 100);
            this.txtctid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtctid.Multiline = true;
            this.txtctid.Name = "txtctid";
            this.txtctid.Size = new System.Drawing.Size(251, 35);
            this.txtctid.TabIndex = 6;
            // 
            // txtctname
            // 
            this.txtctname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtctname.Location = new System.Drawing.Point(236, 149);
            this.txtctname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtctname.Multiline = true;
            this.txtctname.Name = "txtctname";
            this.txtctname.Size = new System.Drawing.Size(251, 35);
            this.txtctname.TabIndex = 7;
            // 
            // txtctphone
            // 
            this.txtctphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtctphone.Location = new System.Drawing.Point(236, 209);
            this.txtctphone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtctphone.Multiline = true;
            this.txtctphone.Name = "txtctphone";
            this.txtctphone.Size = new System.Drawing.Size(251, 35);
            this.txtctphone.TabIndex = 8;
            // 
            // txtctaddress
            // 
            this.txtctaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtctaddress.Location = new System.Drawing.Point(636, 100);
            this.txtctaddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtctaddress.Multiline = true;
            this.txtctaddress.Name = "txtctaddress";
            this.txtctaddress.Size = new System.Drawing.Size(251, 75);
            this.txtctaddress.TabIndex = 9;
            // 
            // txtctemail
            // 
            this.txtctemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtctemail.Location = new System.Drawing.Point(638, 209);
            this.txtctemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtctemail.Multiline = true;
            this.txtctemail.Name = "txtctemail";
            this.txtctemail.Size = new System.Drawing.Size(249, 35);
            this.txtctemail.TabIndex = 10;
            // 
            // btnaddnew
            // 
            this.btnaddnew.BackColor = System.Drawing.Color.Blue;
            this.btnaddnew.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddnew.Location = new System.Drawing.Point(963, 58);
            this.btnaddnew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(164, 55);
            this.btnaddnew.TabIndex = 11;
            this.btnaddnew.Text = "Add New";
            this.btnaddnew.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Blue;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(963, 120);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(164, 59);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Blue;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(963, 184);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(164, 59);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // dgcustomer
            // 
            this.dgcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcustomer.Location = new System.Drawing.Point(22, 266);
            this.dgcustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgcustomer.Name = "dgcustomer";
            this.dgcustomer.RowHeadersWidth = 51;
            this.dgcustomer.RowTemplate.Height = 24;
            this.dgcustomer.Size = new System.Drawing.Size(1142, 270);
            this.dgcustomer.TabIndex = 14;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 583);
            this.Controls.Add(this.dgcustomer);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.txtctemail);
            this.Controls.Add(this.txtctaddress);
            this.Controls.Add(this.txtctphone);
            this.Controls.Add(this.txtctname);
            this.Controls.Add(this.txtctid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtctid;
        private System.Windows.Forms.TextBox txtctname;
        private System.Windows.Forms.TextBox txtctphone;
        private System.Windows.Forms.TextBox txtctaddress;
        private System.Windows.Forms.TextBox txtctemail;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dgcustomer;
    }
}