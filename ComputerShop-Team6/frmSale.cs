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
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }
        public event EventHandler ProductClicked;
        private void HookClickEvents(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button) continue; // Keep Detail button separate
                c.Click += (s, e) => ProductClicked?.Invoke(this, EventArgs.Empty);
                HookClickEvents(c);
            }
        }
        private void OnProductCardClicked(object sender, EventArgs e)
        {
            if (sender is ProductCard card)
            {
                CartItem item = new CartItem
                {
                    Width = flpProductCard.ClientSize.Width - 6
                };

                item.SetItem(card.ProductId, card.ProductName, card.SalePrice, card.Stock);
                flpProductCard.Controls.Add(item);
            }
        }
        frmProduct pd = new frmProduct();
        SqlConnection conn = DbConnection.GetSqlConnection();
        private void frmSale_Load(object sender, EventArgs e)
        {
            
            ToggleEmptyCartLabel();
            UpdateCartSummary();
            LoadProducts();
        }

        private Image ByteArrayToImage(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void LoadProducts(string searchKeyword = "")
        {
            flpProduct.Controls.Clear();

            string query = @"
        SELECT 
            p.ProductId,
            ISNULL(c.CategoryName, '') AS CategoryName,
            p.SKU,
            p.ProductName,
            p.SalePrice,
            p.QtyInStock,
            p.Photo
        FROM tblProduct p
        LEFT JOIN tblCategory c ON p.CategoryId = c.CategoryId
        WHERE p.Status = 1 AND (p.ProductName LIKE @search OR p.SKU LIKE @search)";

            using (SqlConnection conn = DbConnection.GetSqlConnection()) // or new DbConnection().GetConnection()
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@search", $"%{searchKeyword}%");
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductCard card = new ProductCard
                        {
                            ProductId = Convert.ToInt32(reader["ProductId"]),
                            Category = reader["CategoryName"].ToString(),
                            Sku = reader["SKU"].ToString(),
                            _ProductName = reader["ProductName"].ToString(),
                            SalePrice = Convert.ToDecimal(reader["SalePrice"]),
                            Stock = Convert.ToInt32(reader["QtyInStock"]),
                            ProductImage = reader["Photo"] != DBNull.Value
        ? ByteArrayToImage((byte[])reader["Photo"])
        : null,
                            Margin = new Padding(8)
                        };

                        card.OnSelectProduct += (s, e) =>
                        {
                            ProductCard selected = (ProductCard)s;
                            int itemWidth = Math.Max(150, flpProductCard.ClientSize.Width - flpProductCard.Padding.Horizontal - 6);
                            CartItem item = new CartItem
                            {
                                // = flpProductCard.ClientSize.Width - 6 // Use flpCartItem or flpCartItems to match your designer
                                Width = itemWidth,
                                Margin = new Padding(0, 0, 0, 6)
                            };

                            item.SetItem(selected.ProductId, selected._ProductName, selected.SalePrice, selected.Stock);
                            flpProductCard.Controls.Add(item);
                            lblNoItem.Visible = false;
                            //AddToCart(selected.ProductId, selected.ProductName, selected.SalePrice, selected.Stock);
                        };

                        flpProduct.Controls.Add(card);

                    }
                }
            }
        }
        private void pnShowProduct_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtSearchProduct.Text);
        }
        private void UpdateCartSummary()
        {
            decimal subtotal = 0;

            foreach (Control ctrl in flpProductCard.Controls)
            {
                if (ctrl is CartItem item)
                {
                    subtotal += item.LineTotal;
                }
            }

            decimal.TryParse(txtDiscount.Text, out decimal discount);
            if (discount < 0) discount = 0;
            if (discount > subtotal) discount = subtotal;

            decimal total = subtotal - discount;

            // Replace these label names with the exact names on your frmSale designer
            lblSubTotal.Text = subtotal.ToString("C2");
            lblDiscount.Text = $"-{discount.ToString("C2")}";
            lblTotal.Text = total.ToString("C2");
        }
        private void AddToCart(int productId, string productName, decimal salePrice, int stock)
        {
            if (stock <= 0)
            {
                MessageBox.Show("This product is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If product already exists in Cart panel, increase Qty
            foreach (Control ctrl in flpProductCard.Controls)
            {
                if (ctrl is CartItem existing && existing.ProductId == productId)
                {
                    if (existing.Qty < existing.Stock)
                    {
                        existing.Qty++;
                    }
                    else
                    {
                        MessageBox.Show("Cannot add more than available stock.", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    UpdateCartSummary();
                    return;
                }
            }

            // Create new CartItem row inside flpCartItems (inside Panel Cart)
            CartItem item = new CartItem
            {
                Width = flpProductCard.ClientSize.Width - 6,
                Margin = new Padding(0, 0, 0, 6)
            };
            item.SetItem(productId, productName, salePrice, stock);

            item.QuantityOrItemChanged += (s, e) => UpdateCartSummary();
            item.RemoveRequested += (s, e) =>
            {
                flpProductCard.Controls.Remove(item);
                item.Dispose();
                ToggleEmptyCartLabel();
                UpdateCartSummary();
            };

            flpProductCard.Controls.Add(item);
            ToggleEmptyCartLabel();
            UpdateCartSummary();
        }

        private void ToggleEmptyCartLabel()
        {
            int count = 0;
            foreach (Control ctrl in flpProductCard.Controls)
            {
                if (ctrl is CartItem) count++;
            }
            lblNoItem.Visible = (count == 0);
        }
    }
}
