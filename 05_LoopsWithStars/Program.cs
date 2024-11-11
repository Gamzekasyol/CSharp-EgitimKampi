namespace YildizOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma.
            //for (int i = 1; i<= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            //Console.ReadLine(); 

            #endregion

            #region Yan yana 10 tane yıldız oluşturma.
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun.
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("");
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //}
            #endregion


            #region Dik üçgen şeklinde yıldız.
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine( "");
            //}
            #endregion

            #region Ters dik üçgen

            //for (int i = 5; i>=1; i--)
            //{
            //    for (int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region Dik üçgen ve tersi 

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}
            //for (int k = 4; k>=1; k--)
            //{
            //    for (int m=1; m<=k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion


            #region Bakalavamsı şekil
            //int n = 5;
            //for (int i =1; i<= n; i++)
            //{
            //    for (int j = n-1; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k =1; k <= 2 * i -1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i =n- 1; i>=1; i--)
            //{
            //    for (int j=n-1; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k =1; k<= i*2 -1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region Pramit 
            //int n = 5;
            //for (int i=1; i<=n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k=1; k<=2*i -1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ters Pramit
            int n = 5;
            for (int i=n; i>=1; i--)
            {
                for (int j=n-i; j> 0; j--)
                {
                    Console.Write(" ");
                }
                for(int k =1; k<= i*2 -1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion












            Console.Read();

        }
    }
}
