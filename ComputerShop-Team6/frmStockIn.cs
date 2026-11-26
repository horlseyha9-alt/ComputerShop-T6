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
    public partial class frmStockIn : Form
    {
        SqlConnection conn = DbConnection.GetSqlConnection();
        public frmStockIn()
        {
            InitializeComponent();
        }
        private void Show_StockIn()
        {
            SqlCommand cmd = new SqlCommand("sp_show_stockin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "Stocks");
            dgviewStockIn.DataSource = ds.Tables["Stocks"];
            dgviewStockIn.Columns[2].Visible = false;
            dgviewStockIn.Columns[4].Visible = false;
            dgviewStockIn.Columns[6].Visible = false;
            dgviewStockIn.ClearSelection();
        }
        private void Show_Product(int status)
        {
            // Uses your existing 'conn' object directly
            SqlCommand cmd = new SqlCommand("sp_show_product", conn);
            cmd.Parameters.AddWithValue("@status", status); // Assuming you want to show active products
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@status", status); // Assuming you want to show active categories

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            // Bind data to the ComboBox
            cboProduct.DataSource = dt;
            cboProduct.DisplayMember = "ProductName";
            cboProduct.ValueMember = "ProductId";

            cboProduct.SelectedIndex = -1; // Optional: leaves it unselected by default
        }
        private void Show_Supplier()
        {
            // Uses your existing 'conn' object directly
            SqlCommand cmd = new SqlCommand("sp_show_supplier", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@status", status); // Assuming you want to show active categories

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            // Bind data to the ComboBox
            cboSupplier.DataSource = dt;
            cboSupplier.DisplayMember = "SupplierName";
            cboSupplier.ValueMember = "SupplierId";

            cboSupplier.SelectedIndex = -1; // Optional: leaves it unselected by default
        }
        private void Show_Employee(int status)
        {
            // Uses your existing 'conn' object directly
            SqlCommand cmd = new SqlCommand("sp_show_emp", conn);
            cmd.Parameters.AddWithValue("@status", status); // Assuming you want to show active products
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@status", status); // Assuming you want to show active categories

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            // Bind data to the ComboBox
            cboEmployee.DataSource = dt;
            cboEmployee.DisplayMember = "EmpName";
            cboEmployee.ValueMember = "EmpId";

            cboEmployee.SelectedIndex = -1; // Optional: leaves it unselected by default
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(btnAddNew.Text =="Add New"){
                btnAddNew.Text = "Save";
                btnUpdate.Enabled = false;
                btnDelete.Text = "Cancel";
                cboEmployee.SelectedIndex = -1;
                cboProduct.SelectedIndex = -1;
                cboSupplier.SelectedIndex = -1;
            }
            else
            {
                if (string.IsNullOrEmpty(txtUnitPrice.Text))
                {
                    MessageBox.Show("Please enter UnitPrice!", "Required UnitPrice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitPrice.Focus();
                }
                if (string.IsNullOrEmpty(txtQty.Text))
                {
                    MessageBox.Show("Please enter Quantity!", "Required Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQty.Focus();
                }
                else
                {
                    try
                    {
                        //MemoryStream stream = new MemoryStream();
                        //pbProductPicture.Image.Save(stream, pbProductPicture.Image.RawFormat);
                        //create cmd object for excute Sql Statement
                        SqlCommand cmd = new SqlCommand("sp_insert_stockin", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        //set values for parameter of stored procedure
                        cmd.Parameters.AddWithValue("@ProductId", cboProduct.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@SupplierID", cboSupplier.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@EmpId", cboEmployee.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@UnitPrice", int.Parse(txtUnitPrice.Text));
                        cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQty.Text));
                        cmd.Parameters.AddWithValue("@TotalAmount", int.Parse(txtTotal.Text));
                        cmd.Parameters.AddWithValue("@StockDate", dtpStockDate.Value);
                        cmd.Parameters.AddWithValue("@Remark", txtRemark.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        Show_StockIn();
                        btnAddNew.Text = "Add New";
                        btnUpdate.Enabled = true;
                        btnDelete.Text = "Delete";

                        MessageBox.Show("Stock added successfully", "Stock Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ClearText();
                        //pbProductPicture.Image = Properties.Resources.upload__2_;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(btnDelete.Text == "Cancel")
            {
                btnAddNew.Text = "Add New";
                btnUpdate.Enabled = true;
                btnDelete.Text = "Delete";
            }
            else
            {
                if (dgviewStockIn.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure, You want delete Stock", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //int libid = int.Parse(txtStockInId.Text);
                        // UpdateStatus(libid, 0, "Librarian deleted successfully", "Librarian Deleted", 1);
                        try
                        {
                            SqlCommand cmd = new SqlCommand("sp_delete_stockin", conn);
                            //cmd.Parameters.AddWithValue("@status", SqlDbType.Int).Value = 0;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@stockinid", int.Parse(txtStockInId.Text));
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            Show_StockIn();

                            MessageBox.Show("Stock deleted successfully", "Stock Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Please select a Stock ", "No Stock selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmStockIn_Load(object sender, EventArgs e)
        {
            txtStockInId.Enabled = false;
            txtTotal.Enabled = false;
            txtTotal.Text = "0";
            Show_Product(1);
            Show_Supplier();
            Show_Employee(1);
            Show_StockIn();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            double unitPrice = 0;
            int quantity = 0;

            if (double.TryParse(txtUnitPrice.Text.Trim(), out unitPrice) &&
                int.TryParse(txtQty.Text.Trim(), out quantity))
            {
                double total = unitPrice * quantity;
                txtTotal.Text = total.ToString("0.##");
            }
            else
            {
                txtTotal.Text = "0";
            }
        }

        private void dgviewStockIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgviewStockIn.Rows[e.RowIndex];
            txtStockInId.Text = row.Cells[0].Value.ToString();
            cboProduct.SelectedValue = row.Cells[2].Value.ToString();
            cboSupplier.SelectedValue = row.Cells[4].Value.ToString();
            cboEmployee.SelectedValue = row.Cells[6].Value.ToString();
            txtUnitPrice.Text = row.Cells[7].Value.ToString();
            txtQty.Text = row.Cells[8].Value.ToString();
            txtTotal.Text = row.Cells[9].Value.ToString();
            dtpStockDate.Text = row.Cells[10].Value.ToString();
            txtRemark.Text = row.Cells[11].Value.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgviewStockIn.SelectedRows.Count > 0)
            {

                try
                {
                    //MemoryStream stream = new MemoryStream();
                    //pbProductPicture.Image.Save(stream, pbProductPicture.Image.RawFormat);
                    //create cmd object for excute Sql Statement
                    SqlCommand cmd = new SqlCommand("sp_update_stockin", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    //set values for parameter of stored procedure
                    cmd.Parameters.AddWithValue("@stockinid", txtStockInId.Text);
                    cmd.Parameters.AddWithValue("@productid", cboProduct.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@supplierid", cboSupplier.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@empid", cboEmployee.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@unitPrice", int.Parse(txtUnitPrice.Text));
                    cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQty.Text));
                    cmd.Parameters.AddWithValue("@totalamount", int.Parse(txtTotal.Text));
                    cmd.Parameters.AddWithValue("@stockdate", dtpStockDate.Value);
                    cmd.Parameters.AddWithValue("@remark", txtRemark.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    Show_StockIn();
                    MessageBox.Show("stock updated successfully", "Stock Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // ClearText();
                   // pbProductPicture.Image = Properties.Resources.upload__2_;
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
                if (string.IsNullOrEmpty(txtUnitPrice.Text))
                {
                    MessageBox.Show("Please enter Unit Price!", "Required Unit Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitPrice.Focus();
                }
                if (string.IsNullOrEmpty(txtQty.Text))
                {
                    MessageBox.Show("Please enter Quantity!", "Required Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQty.Focus();
                }
            }
        }
    }
}
