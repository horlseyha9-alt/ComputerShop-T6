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
        }
    }
}
