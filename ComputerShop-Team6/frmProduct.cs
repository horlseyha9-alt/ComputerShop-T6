using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop_Team6
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        SqlConnection conn = DbConnection.GetSqlConnection();
        private void btnBrowe_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            //openFileDialog1.Filter = "Image Files | *.png *.jpg *.jpeg *.bmp;";
            openFileDialog1.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp;*.webp)|*.png;*.JPG;*.JPEG;*.BMP;*.PNG;*.jpg;*.jpeg;*.bmp;*webp";
            openFileDialog1.FilterIndex = 4;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbProductPicture.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void Show_Category(int available)
        {
            // Uses your existing 'conn' object directly
            SqlCommand cmd = new SqlCommand("sp_show_category", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@available", available); // Assuming you want to show active categories

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            // Bind data to the ComboBox
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";

            cboCategory.SelectedIndex = -1; // Optional: leaves it unselected by default
        }
        private void Show_Supplier(int status)
        {
            // Uses your existing 'conn' object directly
            SqlCommand cmd = new SqlCommand("sp_show_supplier", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", status); // Assuming you want to show active categories

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            // Bind data to the ComboBox
            cboSupplier.DataSource = dt;
            cboSupplier.DisplayMember = "SupplierName";
            cboSupplier.ValueMember = "SupplierId";

            cboSupplier.SelectedIndex = -1; // Optional: leaves it unselected by default
        }
        private void ShowProduct(int status)
        {
            SqlCommand cmd = new SqlCommand("sp_show_product", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", status);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "Products");
            dgviewProduct.DataSource = ds.Tables["Products"];
            //dgviewProduct.Columns[3].Visible = false;
            dgviewProduct.Columns[8].Visible = false;
            dgviewProduct.ClearSelection();
        }
        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                chkInactive.Checked = false;
                ShowProduct(1);
            }
        }

        private void chkInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInactive.Checked)
            {
                chkActive.Checked = false;
                ShowProduct(1);
            }
        }
        public void ClearText()
        {
        
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (btnAddNew.Text == "Add New")
            {
                btnAddNew.Text = "Save";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = true;
                btnDelete.Text = "Cancel";
                //ClearText();
                pbProductPicture.Image = Properties.Resources.upload__2_;
                cboCategory.SelectedIndex = -1;
                txtSKU.Focus();
            }
            else if (btnAddNew.Text == "Cancel")
            {
                dgviewProduct.ClearSelection();
                ClearText();
                btnAddNew.Text = "Add New";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                if (string.IsNullOrEmpty(txtSKU.Text))
                {
                    MessageBox.Show("Please enter SKU!", "Required SKU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSKU.Focus();
                }
                if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("Please enter Product Name!", "Required Product Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductName.Focus();
                }
                else
                {
                    try
                    {
                        MemoryStream stream = new MemoryStream();
                        pbProductPicture.Image.Save(stream, pbProductPicture.Image.RawFormat);
                        //create cmd object for excute Sql Statement
                        SqlCommand cmd = new SqlCommand("sp_insert_product", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        //set values for parameter of stored procedure
                        cmd.Parameters.AddWithValue("@sku", txtSKU.Text);
                        cmd.Parameters.AddWithValue("@productname", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                        cmd.Parameters.AddWithValue("@categoryid", cboCategory.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@supplierid", cboSupplier.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@unitPrice", int.Parse(txtUnitPrice.Text));
                        cmd.Parameters.AddWithValue("@saleprice", int.Parse(txtSalePrice.Text));
                        cmd.Parameters.AddWithValue("@qtyinstock", int.Parse(txtQtyInStock.Text));
                        cmd.Parameters.AddWithValue("@photo", stream.ToArray());
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        //ShowItem(1);
                        btnAddNew.Text = "Add New";
                        btnUpdate.Enabled = true;
                        btnDelete.Text = "Delete";

                        MessageBox.Show("Product added successfully", "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearText();
                        pbProductPicture.Image = Properties.Resources.upload__2_;
                        btnAddNew.Text = "Add New";
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        btnDelete.Text = "Delete";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Cancel")
            {
                btnAddNew.Text = "Add New";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnDelete.Text = "Delete";
                ClearText();
            }
        }

        private void dgviewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgviewProduct.Rows[e.RowIndex];
            object img_value = row.Cells[8].Value;
            if (img_value == null || img_value == DBNull.Value)
            {
                pbProductPicture.Image = Properties.Resources.upload__2_;
            }
            else
            {
                Byte[] img = (byte[])row.Cells[6].Value;
                MemoryStream ms = new MemoryStream(img);
                pbProductPicture.Image = Image.FromStream(ms);
            }

            txtSKU.Text = row.Cells[0].Value.ToString();
            txtProductName.Text = row.Cells[1].Value.ToString();
            txtBarcode.Text = row.Cells[2].Value.ToString();
            cboCategory.SelectedValue = row.Cells[3].Value.ToString();
            cboSupplier.SelectedValue = row.Cells[4].Value.ToString();
            txtUnitPrice.Text = row.Cells[5].Value.ToString();
            txtSalePrice.Text = row.Cells[6].Value.ToString();
            txtQtyInStock.Text = row.Cells[7].Value.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAddNew.Text = "Cancel";
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            ShowProduct(1);
            Show_Category(1);
            Show_Supplier(1);
            txtUnitPrice.Text = 0.ToString();
            txtSalePrice.Text = 0.ToString();
        }
    }
}
