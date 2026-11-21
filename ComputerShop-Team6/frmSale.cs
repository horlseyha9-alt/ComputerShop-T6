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
        frmProduct pd = new frmProduct();
        SqlConnection conn = DbConnection.GetSqlConnection();
        private void frmSale_Load(object sender, EventArgs e)
        {
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
                            //AddToCart(selected.ProductId, selected.ProductName, selected.SalePrice);
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
    }
}
