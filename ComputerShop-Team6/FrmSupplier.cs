using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop_Team6
{
    public partial class FrmSupplier : Form
    {
        public FrmSupplier()
        {
            InitializeComponent();
        }
        Functions myfunction = new Functions();
        Controller.ControllerSupplier mysupplier = new Controller.ControllerSupplier();
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            myfunction.DisableAllTextAndCombobox(this);
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            dgvsupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;   // ជ្រើសទាំងជួរ
            dgvsupplier.MultiSelect = false;                                       // ជ្រើសបានតែ ១ ជួរ
            dgvsupplier.ReadOnly = true;                                           // មិនឱ្យកែក្នុង Grid
            dgvsupplier.AllowUserToAddRows = false;                                // លុបជួរទទេខាងក្រោម


            LoadSupplier();
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            if (btnaddnew.Text == "Add New")
            {
                myfunction.EnableAllTextAndCombobox(this);
                btnaddnew.Text = "Insert Data";
                btnupdate.Text = "Clear";
                btnupdate.Enabled = true;
                txtsupplierid.Enabled = false;
            }
            else if (btnaddnew.Text == "Insert Data")
            {
                mysupplier.CompanyName = txtcompayname.Text;
                mysupplier.SupplierName = txtsuppliername.Text;
                mysupplier.DOB = DateTime.Parse(txtdob.Text);
                mysupplier.POB = txtpob.Text;
                mysupplier.Address = txtaddress.Text;
                mysupplier.PhoneNumber = txtphonenumber.Text;
                mysupplier.InsertSupplier();
                LoadSupplier();
                MessageBox.Show("Supplier Has Been Inserted", "Insert Data",MessageBoxButtons.OK, MessageBoxIcon.Information);
                myfunction.ClearField(this);
                myfunction.DisableAllTextAndCombobox(this);
                btnaddnew.Text = "Add New";
                btnupdate.Enabled = false;
                btnupdate.Text = "Update";
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (btnupdate.Text == "Clear")
            {
                myfunction.ClearField(this);
                btnaddnew.Text = "Add New";
                btnupdate.Text = "Update";
                btnupdate.Enabled = false;
                myfunction.DisableAllTextAndCombobox(this);
            }
            else if (btnupdate.Text == "Update")
            {
                mysupplier.SupplierID = int.Parse(txtsupplierid.Text);
                mysupplier.CompanyName = txtcompayname.Text;
                mysupplier.SupplierName = txtsuppliername.Text;
                 

                DateTime dob;
                if (!DateTime.TryParse(txtdob.Text, out dob))
                {
                    MessageBox.Show("Please enter a valid Date of Birth (e.g. 2003-02-12)", "Invalid Date",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                mysupplier.DOB = dob;


                mysupplier.POB = txtpob.Text;
                mysupplier.Address = txtaddress.Text;
                mysupplier.PhoneNumber = txtphonenumber.Text;

                mysupplier.UpdateSupplier();
                LoadSupplier();   // Refresh Grid

                MessageBox.Show("Supplier Has Been Updated", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myfunction.ClearField(this);
                myfunction.DisableAllTextAndCombobox(this);
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
            }
        }
        
        private void LoadSupplier()
        {
            mysupplier.ViewData();
            dgvsupplier.DataSource = mysupplier.dt;
            dgvsupplier.AutoGenerateColumns = false;
  
        }

        private void dgvsupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvsupplier.Rows[e.RowIndex];
            txtsupplierid.Text = row.Cells[0].Value?.ToString();
            txtcompayname.Text = row.Cells[1].Value?.ToString();
            txtsuppliername.Text = row.Cells[2].Value?.ToString();
            txtdob.Text = (row.Cells[3].Value == null || row.Cells[3].Value == DBNull.Value)
                ? ""
                : Convert.ToDateTime(row.Cells[3].Value).ToString("dd-MM-yyyy");
            txtpob.Text = row.Cells[4].Value?.ToString();
            txtaddress.Text = row.Cells[5].Value?.ToString();
            txtphonenumber.Text = row.Cells[6].Value?.ToString();

            myfunction.EnableAllTextAndCombobox(this);
            txtsupplierid.Enabled = false;
            btnupdate.Text = "Update";
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
            btnaddnew.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsupplierid.Text))
            {
                MessageBox.Show("Please select a supplier to delete.", "Delete Data",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this supplier?", "Delete Data",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    mysupplier.SupplierID = int.Parse(txtsupplierid.Text);
                    mysupplier.DeleteSupplier();
                    LoadSupplier();

                    MessageBox.Show("Supplier Has Been Deleted", "Delete Data",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    myfunction.ClearField(this);
                    myfunction.DisableAllTextAndCombobox(this);
                    btnupdate.Enabled = false;
                    btndelete.Enabled = false;
                    btnaddnew.Text = "Add New";
                    btnupdate.Text = "Update";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Cannot delete this supplier. It may be used in other records.\n\n" + ex.Message,"Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvsupplier_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null && e.Value != DBNull.Value)
            {
                if (e.Value is DateTime dt)
                {
                    e.Value = dt.ToString("dd-MM-yyyy");
                    e.FormattingApplied = true;
                }
            }
        }
        private void dgvsupplier_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvsupplier.ClearSelection();
            dgvsupplier.CurrentCell = null;
        }

        private void dgvsupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
