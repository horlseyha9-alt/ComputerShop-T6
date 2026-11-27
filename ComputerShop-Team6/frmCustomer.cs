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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        Functions myfunction = new Functions();
        Controller.ControllerCustomer mycustomer = new Controller.ControllerCustomer();
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            myfunction.DisableAllTextAndCombobox(this);
            btndelete.Enabled = false;
            btnupdate.Enabled = false;

            dgvcustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvcustomer.MultiSelect = false;
            dgvcustomer.ReadOnly = true;
            dgvcustomer.AllowUserToAddRows = false;

            LoadCustomer();
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            if (btnaddnew.Text == "Add New")
            {
                myfunction.EnableAllTextAndCombobox(this);
                btnaddnew.Text = "Insert Data";
                btnupdate.Text = "Clear";
                btnupdate.Enabled = true;
                txtcustomerid.Enabled = false;
            }
            else if (btnaddnew.Text == "Insert Data")
            {
                mycustomer.CustomerName = txtcustomername.Text;
                mycustomer.Phone = txtphonenumber.Text;
                mycustomer.Address = txtcustomeraddress.Text;
                mycustomer.Email = txtcustomeremail.Text;
                mycustomer.InsertCustomer();
                LoadCustomer();
                MessageBox.Show("Customer Has Been Inserted", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myfunction.ClearField(this);
                myfunction.DisableAllTextAndCombobox(this);
                btnaddnew.Text = "Add New";
                btnupdate.Enabled = false;
                btnupdate.Text = "Update";
            }
        }
        private void LoadCustomer()
        {
            mycustomer.ViewData();
            dgvcustomer.AutoGenerateColumns = false;
            dgvcustomer.Columns[0].DataPropertyName = "CustomerId";
            dgvcustomer.Columns[1].DataPropertyName = "CustomerName";
            dgvcustomer.Columns[2].DataPropertyName = "Phone";
            dgvcustomer.Columns[3].DataPropertyName = "Address";
            dgvcustomer.Columns[4].DataPropertyName = "Email";
            dgvcustomer.DataSource = mycustomer.dt;
        }

        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                mycustomer.CustomerID = int.Parse(txtcustomerid.Text);
                mycustomer.CustomerName = txtcustomername.Text;
                mycustomer.Phone = txtphonenumber.Text;
                mycustomer.Address = txtcustomeraddress.Text;
                mycustomer.Email = txtcustomeremail.Text;

                mycustomer.UpdateCustomer();
                LoadCustomer();

                MessageBox.Show("Customer Has Been Updated", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myfunction.ClearField(this);
                myfunction.DisableAllTextAndCombobox(this);
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
            }
        }

        private void dgvcustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvcustomer.Rows[e.RowIndex];
            txtcustomerid.Text = row.Cells[0].Value?.ToString();
            txtcustomername.Text = row.Cells[1].Value?.ToString();
            txtphonenumber.Text = row.Cells[2].Value?.ToString();

            txtcustomeraddress.Text = row.Cells[3].Value?.ToString();
            txtcustomeremail.Text = row.Cells[4].Value?.ToString();

            myfunction.EnableAllTextAndCombobox(this);
            txtcustomerid.Enabled = false;
            btnaddnew.Enabled = false;
            btnupdate.Text = "Update";
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcustomerid.Text))
            {
                MessageBox.Show("Please select a customer to delete.", "Delete Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this customer?", "Delete Data",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    mycustomer.CustomerID = int.Parse(txtcustomerid.Text);
                    mycustomer.DeleteCustomer();
                    LoadCustomer();

                    MessageBox.Show("Customer Has Been Deleted", "Delete Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    myfunction.ClearField(this);
                    myfunction.DisableAllTextAndCombobox(this);
                    btnupdate.Enabled = false;
                    btndelete.Enabled = false;
                    btnaddnew.Text = "Add New";
                    btnupdate.Text = "Update";
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Cannot delete this customer. It may be used in other records.\n\n" + ex.Message,"Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
