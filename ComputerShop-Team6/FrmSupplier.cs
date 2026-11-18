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
        
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            txtaddress.Enabled = false;
            txtcompayname.Enabled = false;
            txtdob.Enabled = false;
            txtid.Enabled = false;
            txtphonenumber.Enabled = false;
            txtpob.Enabled = false;
            txtsuppliername.Enabled = false;
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            if(btnaddnew.Text == "Add New")
            {
                btnaddnew.Text = "Save";
                txtaddress.Enabled = true;
                txtcompayname.Enabled = true;
                txtdob.Enabled = true;
                txtid.Enabled = true;
                txtphonenumber.Enabled = true;
                txtpob.Enabled = true;
                txtsuppliername.Enabled = true;
                btndelete.Enabled = false;
                btnupdate.Enabled = false;
            }
            else
            {
                btnaddnew.Text = "Add New";
                txtaddress.Enabled = false;
                txtcompayname.Enabled = false;
                txtdob.Enabled = false;
                txtid.Enabled = false;
                txtphonenumber.Enabled = false;
                txtpob.Enabled = false;
                txtsuppliername.Enabled = false;
                btndelete.Enabled = false;
                btnupdate.Enabled = false;
            }
        }
    }
}
