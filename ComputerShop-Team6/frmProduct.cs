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
            dgviewProduct.Columns[0].Visible = false;
            dgviewProduct.Columns[5].Visible = false;
            dgviewProduct.Columns[7].Visible = false;
            dgviewProduct.Columns[11].Visible = false;
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
                ShowProduct(0);
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
                        ShowProduct(1);
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
            if (dgviewProduct.SelectedRows.Count > 0)
            {

                try
                {
                    MemoryStream stream = new MemoryStream();
                    pbProductPicture.Image.Save(stream, pbProductPicture.Image.RawFormat);
                    //create cmd object for excute Sql Statement
                    SqlCommand cmd = new SqlCommand("sp_update_product", conn);
                    
                    cmd.CommandType = CommandType.StoredProcedure;

                    //set values for parameter of stored procedure
                    cmd.Parameters.AddWithValue("@productId", txtProductId.Text);
                    cmd.Parameters.AddWithValue("@sku", txtSKU.Text);
                    cmd.Parameters.AddWithValue("@productName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@categoryId", cboCategory.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@supplierId", cboSupplier.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@unitPrice", int.Parse(txtUnitPrice.Text));
                    cmd.Parameters.AddWithValue("@saleprice", int.Parse(txtSalePrice.Text));
                    cmd.Parameters.AddWithValue("@qtyinstock", int.Parse(txtQtyInStock.Text));
                    cmd.Parameters.AddWithValue("@photo", stream.ToArray());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    ShowProduct(1);
                    MessageBox.Show("product updated successfully", "Product Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                if (string.IsNullOrEmpty(txtSKU.Text))
                {
                    MessageBox.Show("Please enter Product SKU!", "Required Product SKU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSKU.Focus();
                }
                if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("Please enter Product name!", "Required Product Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductName.Focus();
                }
            }
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
            else
            {
                if (dgviewProduct.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure, You want delete Product", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int libid = int.Parse(txtProductId.Text);
                       // UpdateStatus(libid, 0, "Librarian deleted successfully", "Librarian Deleted", 1);
                        try
                        {
                            SqlCommand cmd = new SqlCommand("update_product_status", conn);
                            cmd.Parameters.AddWithValue("@status", SqlDbType.Int).Value = 0;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@productid", int.Parse(txtProductId.Text));
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            ShowProduct(1);

                            MessageBox.Show("Product deleted successfully", "Product Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                else
                {
                    MessageBox.Show("Please select a Product ", "No Product selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgviewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgviewProduct.Rows[e.RowIndex];
            object img_value = row.Cells[11].Value;
            if (img_value == null || img_value == DBNull.Value)
            {
                pbProductPicture.Image = Properties.Resources.upload__2_;
            }
            else
            {
                Byte[] img = (byte[])row.Cells[11].Value;
                MemoryStream ms = new MemoryStream(img);
                pbProductPicture.Image = Image.FromStream(ms);
            }
            txtProductId.Text = row.Cells[0].Value.ToString();
            txtSKU.Text = row.Cells[1].Value.ToString();
            txtProductName.Text = row.Cells[2].Value.ToString();
            txtBarcode.Text = row.Cells[3].Value.ToString();
            cboCategory.SelectedValue = row.Cells[5].Value.ToString();
            cboSupplier.SelectedValue = row.Cells[7].Value.ToString();
            txtUnitPrice.Text = row.Cells[8].Value.ToString();
            txtSalePrice.Text = row.Cells[9].Value.ToString();
            txtQtyInStock.Text = row.Cells[10].Value.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            //btnAddNew.Text = "Cancel";
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            ShowProduct(1);
            Show_Category(1);
            Show_Supplier(1);
            txtProductId.Visible = false;
            txtUnitPrice.Text = 0.ToString();
            txtQtyInStock.Text = 0.ToString();
        }
    }
}
