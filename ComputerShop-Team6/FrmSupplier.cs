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
