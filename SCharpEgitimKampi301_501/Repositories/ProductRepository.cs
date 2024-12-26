using SCharpEgitimKampi301_501.Dtos;
using SCharpEgitimKampi301_501.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using Dapper;
using System.ComponentModel;
using System.Data.SqlClient;

namespace SCharpEgitimKampi301_501.Repositories
{

    public class ProductRepository : IProductRepository
    {
        DapperContext dapperContext = new DapperContext();
        public ProductRepository()
        {
            dapperContext = new DapperContext();
        }


        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {

            var connection = dapperContext.CreateConnection();
            try
            {
                connection.Open();
                string query = "INSERT INTO TblProduct (ProductName, ProductStok, ProductPrice, ProductCategory) VALUES (@productName, @productStok, @productPrice, @productCategory)";
                var parameters = new DynamicParameters();// Parametrelere atama yapacağımızı bildirdik.
                parameters.Add("@productName", createProductDto.ProductName);
                parameters.Add("@productStok", createProductDto.ProductStok);
                parameters.Add("@productPrice", createProductDto.ProductPrice);
                parameters.Add("@productCategory", createProductDto.ProductCategory);
                var result = await connection.ExecuteAsync(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("İşlem başarılı!");
                }
                else
                {
                    MessageBox.Show("İşlem başarısız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası!", ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public async Task DeleteProductAsync(int id)
        {
            string query = "DELETE FROM Tblproduct WHERE ProductId = @productId";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@productId", id);
            using (var connection = dapperContext.CreateConnection())
            {
                var result = await connection.ExecuteAsync(query, parameters);
                if (result > 0)
                {

                    MessageBox.Show("İşlem Başarılı!");
                }
                else
                {
                    MessageBox.Show("İşlem başarısız");
                }
            }
        }

        public async Task<List<ResultProductDto>> GetAllPRoductAsync()
        {
            string query = "SELECT * FROM TblProduct";
            var connection = dapperContext.CreateConnection();
            try
            {
                connection.Open();
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList(); // QueryAsync IEnumerable döner, bunu list'e çeviriyoruz.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning).ToString();
                return new List<ResultProductDto>(); // Listeyi boş döndürür.

            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();

                }
            }
            // Burası yukarıda ki işlemin farklı bir yapılış şeklidir. using bağlantı işleminin kontrolünü otomatik gerçekleştirir.
            //using( connection = dapperContext.CreateConnection())
            //{
            //    var values = await connection.QueryAsync<ResultProductDto>(query);
            //     return values.ToList();
            //}
        }

        public async Task GetByProductIdAsync(int id)
        {
            string query = "SELECT * FROM TblProduct WHERE ProductId=@productId";
            var parameter = new DynamicParameters();
            parameter.Add("@productId", id);
            var connection = dapperContext.CreateConnection();
            var values =await connection.ExecuteAsync(query, parameter);
            values.ToString();
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            string query = "UPDATE TblProduct SET  ProductName=@productName,ProductStok=@productStok, ProductPrice=@productPrice, ProductCategory=@productCategory WHERE ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", updateProductDto.ProductName);
            parameters.Add("@productStok", updateProductDto.ProductStok);
            parameters.Add("@productPrice", updateProductDto.ProductPrice);
            parameters.Add("@productCategory", updateProductDto.ProductCategory);
            parameters.Add("@productId", updateProductDto.ProductId);
            using (var connection = dapperContext.CreateConnection()) 
            {
                await connection.ExecuteAsync(query, parameters);
                MessageBox.Show("İşlem başarılı");
            }

        }
    }
}
