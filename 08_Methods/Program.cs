using System.Globalization;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metodlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion


            #region Geriye Değer Döndürmeyen Parametreli Metodlar

            void WriteMethod(string customerName)
            {
                Console.WriteLine(customerName);
            }
            WriteMethod("Mehmet Yıldırım");


            void customerCard(string name , string surName)
            {
                Console.WriteLine("Müşteri: " + name + " " + surName);

            }
            customerCard("Mehmet", "Yılmaz");
            #endregion


            #region Geriye Değer Döndürmeyen Int Parametreli Metodlar
            void Sum(int number1, int number2, int number3)
            {
                Console.WriteLine(number1 + number2 + number3);
            }
            Sum(5, 7, 9);



            #endregion


            #region Geriye Değer Döndüren Metodlar

            string CustomerName()
            {
                return "Buse Yıldız";
            }
            CustomerName();  // Değer dönmez çünkü yazdır komutu yok.

            string strudentCard()
            {
                string name = "Ali";
                string surName = "Kaya";
                
                return name + " "+ surName;
            }
            Console.WriteLine(strudentCard()); // Yazdırma işlemi gerçekleştirdik.


            #endregion

            #region Geriye Değer Döndüren String Metodlar 
            //string CountryCard(string countryName, string capital ,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "- Başkent: " + capital + "- Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını girniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion


            #region Geriye Değer Döndüren Int Parametreli Metotlar

            int Sum2(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }

            Console.WriteLine(Sum2(45, 98));
            Console.WriteLine(Sum2(36, 25));
            Console.WriteLine(Sum2(44, 36));
            Console.WriteLine(Sum2(14, 20));

            #endregion

            #region Örnek Uygulama

            string Examresult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti. " + "Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavı geçemedi. Ortalama: " + result;
                }
            }

            Console.WriteLine(Examresult("Ali", 78, 41, 85));
            Console.WriteLine(Examresult("Ayşe", 25, 41, 32));

            #endregion
            Console.Read();
        }
    }
}
