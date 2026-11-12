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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void OpenForm(Form frm)
        {
            paMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            paMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            //OpenForm(new frmProduct());
        }
    }
}
