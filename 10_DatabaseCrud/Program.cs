using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq.Expressions;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Egitim_KampiDb;Integrated Security=True;");
            Console.WriteLine("**** Menü Sipariş İşlem Paneli ****");
            Console.WriteLine();
            Console.WriteLine();

            // Creat 
            #region Kategory Ekleme İşlemi
            //string categoryName;
            //Console.Write("İstediğiniz kategory adını giriniz: ");
            //categoryName = Console.ReadLine();
            //try
            //{

            //    connection.Open();
            //    SqlCommand cmd = new SqlCommand("Insert Into Table_Category (CategoryName) Values (@p1)", connection);
            //    cmd.Parameters.AddWithValue("@p1", categoryName );
            //    cmd.ExecuteNonQuery();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine( "Bağlantı hatası oluştu! "+ ex.Message);
            //}
            //finally { connection.Close();  Console.WriteLine("Başarılı bir şekilde giriş sağlandı!"); }

            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürünün Adını Giriniz: ");
            //productName =Console.ReadLine();
            //Console.Write("Eklemek İstediğiniz Ürünün Fiyatını Giriniz: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //try
            //{
            //    connection.Open();
            //    SqlCommand cmd = new SqlCommand("Insert Into Table_Product(ProductName, ProductPrice, ProductStatus) Values (@p1, @p2, @p3)", connection);
            //    cmd.Parameters.AddWithValue("@p1", productName);
            //    cmd.Parameters.AddWithValue("@p2", productPrice);
            //    cmd.Parameters.AddWithValue("@p3", true);
            //    cmd.ExecuteNonQuery();

            //}
            //catch (Exception ex)
            //{

            //}
            //finally { connection.Close(); Console.WriteLine("Ürün  Ekleme Başarılı!"); }

            #endregion

            // Read 
            #region Ürün Listeleme 
            //try
            //{
            //    connection.Open();
            //    SqlCommand cmd = new SqlCommand("Select * From Table_Product", connection);
            //    cmd.ExecuteNonQuery();
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            //    DataTable dataTable = new DataTable();
            //    dataAdapter.Fill(dataTable);

            //    foreach(DataRow row in dataTable.Rows)
            //    {
            //        foreach(var item in row.ItemArray)
            //        {
            //            Console.Write(item.ToString() +"  ");
            //        }
            //        Console.WriteLine();
            //    }

            //}
            //catch (Exception ex) { }
            //finally { connection.Close();}
            #endregion

            // Delet 
            #region Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün ID: ");
            //int id = int.Parse(Console.ReadLine());

            //try
            //{
            //    connection.Open();
            //    SqlCommand cmd = new SqlCommand("Delete  From Table_Product Where ProductId= @p1", connection);
            //    cmd.Parameters.AddWithValue("@p1", id);
            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception ex) { }
            //finally { connection.Close(); Console.WriteLine("Silme işlemi başarılı!"); }
            #endregion

            // Update 
            #region Ürün Güncellme İŞlemi 
            Console.WriteLine("Ürün Id:");
            int productId= int.Parse(Console.ReadLine());

            Console.WriteLine("Ürün Adı:");
            string productName = Console.ReadLine();

            Console.WriteLine("Ürün Fiyatı: ");
            decimal productPrice= decimal.Parse(Console.ReadLine());

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Update Table_Product Set ProductName= @p1, ProductPrice= @p2 Where ProductId= @p3", connection);
                cmd.Parameters.AddWithValue("@p1", productName);
                cmd.Parameters.AddWithValue("@p2", productPrice);
                cmd.Parameters.AddWithValue("@p3", productId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { Console.WriteLine("Başarıyla güncellendi!"); connection.Close(); }

            

            #endregion
            Console.Read();
        }
        
    }
}
