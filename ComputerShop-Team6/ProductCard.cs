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
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
            // Trigger selection when clicking the Detail button or anywhere on the card
            btnDetail.Click += (s, e) => OnSelectProduct?.Invoke(this, e);
            pnShowProduct.Click += (s, e) => OnSelectProduct?.Invoke(this, e);
        }
        public event EventHandler OnSelectProduct;

        public int ProductId { get; set; }

        public string Category
        {
            get => lblCategory.Text;
            set => lblCategory.Text = value;
        }

        public string Sku
        {
            get => lblSKU.Text;
            set => lblSKU.Text = value;
        }

        public string _ProductName
        {
            get => lblProductName.Text;
            set => lblProductName.Text = value;
        }

        private decimal _salePrice;
        public decimal SalePrice
        {
            get => _salePrice;
            set
            {
                _salePrice = value;
                lblSalePrice.Text = value.ToString("C2"); // Formats as $0.00
            }
        }

        private int _stock;
        public int Stock
        {
            get => _stock;
            set
            {
                _stock = value;
                lblStock.Text = $"Stock: {value}";
            }
        }
        private Image Photo;
        public Image ProductImage
        {
            get => pbProductPhoto.Image;
            set => pbProductPhoto.Image = value;
        }


        private void pnShowProduct_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
