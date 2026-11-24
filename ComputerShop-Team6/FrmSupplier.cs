using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            {
                mysupplier.SupplierID = int.Parse(txtsupplierid.Text);
                mysupplier.CompanyName = txtcompayname.Text;
                mysupplier.SupplierName = txtsuppliername.Text;
                mysupplier.DOB = DateTime.Parse(txtdob.Text);
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
            txtsupplierid.Text = row.Cells[0].Value.ToString();
            txtcompayname.Text = row.Cells[1].Value.ToString();
            txtsuppliername.Text = row.Cells[2].Value.ToString();
            txtdob.Text = Convert.ToDateTime(row.Cells[3].Value).ToString("yyyy-MM-dd");
            txtpob.Text = row.Cells[4].Value.ToString();
            txtaddress.Text = row.Cells[5].Value.ToString();
            txtphonenumber.Text = row.Cells[6].Value.ToString();

            myfunction.EnableAllTextAndCombobox(this);
            txtsupplierid.Enabled = false;
            btnupdate.Text = "Update";
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
            btnaddnew.Text = "Add New";

        }
    }
}
