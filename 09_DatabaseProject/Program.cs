using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace _09_DatabaseProject
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("  *** C# Veri Tabanlı Ürün-Kategori Bilgi Listesi ***");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("------------------------");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=Gamze\\SQLEXPRESS;Initial Catalog=Egitim_KampiDb;Integrated Security=True"); ;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * From Table_Category", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach(var item in row.ItemArray)
                    {
                        Console.Write(item.ToString());
                    }
                    Console.WriteLine();
                        
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bağlantı hatası oluştu!", ex);
            }
            finally
            {
                connection.Close();
            }



            Console.Read();


        }
    }
}
