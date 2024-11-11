namespace _03_Karar_Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}

            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil!");
            //}


            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez!");

            //}
            //else
            //    Console.WriteLine("Hoş geldiniz!");


            //Console.Read();

            #endregion

            #region Mod İşlemleri

            //int number;
            //Console.Write( "Bir sayı giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("Birinci sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalanı: "+ result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Girilen sayı  çift sayıdır!");
            //}
            //else
            //    Console.WriteLine("Girilen sayı  tek sayıdır.");



            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Takımınızın sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if (team == 'g' | team == 'G')
            //{
            //     Console.WriteLine("Galatasaray");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();


            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("------------Çorbalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------İçecekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------Tatlılar------------");

            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.Write("January");
            //        break;
            //    case 2:
            //        Console.Write("Fabruary");
            //        break;
            //    case 3:
            //        Console.Write("March");
            //        break;
            //    case 4:
            //        Console.Write("April");
            //        break;
            //    case 5:
            //        Console.Write("May");
            //        break;
            //    case 6:
            //        Console.Write("June");
            //        break;
            //    case 7:
            //        Console.Write("July");
            //        break;
            //    case 8:
            //        Console.Write("Agust");
            //        break;
            //    case 9:
            //        Console.Write("Semtember");
            //        break;
            //    case 10:
            //        Console.Write("October");
            //        break;
            //    case 11:
            //        Console.Write("November");
            //        break;
            //    case 12:
            //        Console.Write("December");
            //        break;
            //    default:
            //        Console.WriteLine("Geçerli bir sayı giriniz.");
            //         break;

            //}
            #endregion

            #region Switch Case Hesap Makinası


            int number1, number2, result;
            char symbol;

            Console.Write("Birinci sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());    

            Console.Write("İstediğin işlemin sembolünü giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.Write("Toplama işeminizin sonucu: "+ result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.Write("Çıkarma işelminizin sonucu: " +        result);
                    break;
                case '*':   
                    result = number1 * number2;
                    Console.Write("Çarpma işleminizin sonucu: "+          result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.Write("Bölme işleminizin sonucu: " + result);
                    break;

                default:
                    Console.Write("Geçerli bir işlem seçiniz!");
                    break;
            }

            #endregion







            Console.Read();
       

        }
    }
}
