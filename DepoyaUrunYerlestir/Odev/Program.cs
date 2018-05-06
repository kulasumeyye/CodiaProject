using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Depo Boyutunu Giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ürün Adetini Giriniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());
         
            int sayac = 0;
            int[,] dizi = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (adet % (n * n) == 0)
                    {
                        dizi[i, j] = adet / (n * n);
                         Console.Write( Convert.ToString(dizi[i, j]) + " ");

                    }

                    else
                    {

                        int kalan = adet % (n * n);
                        dizi[i, j] = (adet / (n * n));
                        if (sayac < kalan)
                        {
                            dizi[i, j] += 1;
                            sayac++;

                        }

                       Console.Write( Convert.ToString(dizi[i, j]) + " ");


                    }

                }

                Console.WriteLine(); 
            }

            Console.ReadKey();



        }
    }
}
