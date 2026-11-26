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
    public partial class CartItem : UserControl
    {
        public event EventHandler QuantityOrItemChanged;
        public event EventHandler RemoveRequested;
        public CartItem()
        {
            InitializeComponent();
        }
        public int ProductId { get; set; }
        public decimal SalePrice { get; set; }
        public int Stock { get; set; }

        private int _qty = 1;
        public int Qty
        {
            get => _qty;
            set
            {
                _qty = value < 1 ? 1 : value;
                lblQty.Text = _qty.ToString();
                QuantityOrItemChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public decimal LineTotal => SalePrice * Qty;

        public void SetItem(int productId, string name, decimal salePrice, int stock)
        {
            ProductId = productId;
            lblProductname.Text = name;
            lblProductprice.Text = salePrice.ToString("C2");
            Stock = stock;
            _qty = 1;
            lblQty.Text = "1";
        }
        private void CartItem_Load(object sender, EventArgs e)
        {

        }
    }
}
