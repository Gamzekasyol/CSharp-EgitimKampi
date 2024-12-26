using Dapper;
using SCharpEgitimKampi301_501.Context;
using SCharpEgitimKampi301_501.Dtos;
using SCharpEgitimKampi301_501.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCharpEgitimKampi301_501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DapperContext dapperContext = new DapperContext();
        private async void btnList_Click(object sender, EventArgs e)
        {
            var productService = new ProductRepository();
            var products = await productService.GetAllPRoductAsync();
            dataGridView1.DataSource = products;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var productService = new ProductRepository();
            var createProductDto = new CreateProductDto
            {
                ProductName = txtProductName.Text,
                ProductStok = int.Parse(txtProductStok.Text),
                ProductPrice = decimal.Parse(txtProductPrice.Text),
                ProductCategory = txtProductCategory.Text,
            };
            await productService.CreateProductAsync(createProductDto);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var productService = new ProductRepository();
            var product = new ResultProductDto
            {
                ProductId = int.Parse(txtProductId.Text)
            };
            await productService.DeleteProductAsync(product.ProductId);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var productService = new ProductRepository();
            var updateProduct = new UpdateProductDto
            {
                ProductName = txtProductName.Text,
                ProductStok = int.Parse(txtProductStok.Text),
                ProductPrice = int.Parse(txtProductPrice.Text),
                ProductCategory = txtProductCategory.Text,
                ProductId = int.Parse(txtProductId.Text),
            };
            await productService.UpdateProductAsync(updateProduct);
        }

        private async void btnGetById_Click(object sender, EventArgs e)
        {
            var productService = new ProductRepository();
            var productResult = new ResultProductDto
            {
                ProductId = int.Parse(txtProductId.Text),
            };
            await productService.GetByProductIdAsync(productResult.ProductId);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT COUNT(*) FROM TblProduct";
            var connection = dapperContext.CreateConnection();
            var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query1);
            lblTotalProductCount.Text = productTotalCount.ToString();

            string query2 = "SELECT ProductName FROM TblProduct WHERE ProductPrice=(SELECT MAX(ProductPrice) FROM TblProduct)";
            var productMaxPrice = await connection.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxProductPrice.Text = productMaxPrice.ToString();

            string query3 = "SELECT COUNT(Distinct(ProductCategory)) FROM TblProduct";
            var productCountCategory = await connection.QueryFirstOrDefaultAsync<int>(query3);
            lblcategoryCount.Text = productCountCategory.ToString();

        }
    }
}
