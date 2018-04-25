using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasamakBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int kalan=0;
            int i = 1;
            int toplam = 0;


            while (kalan != sayi)
            {

                kalan = sayi % 10;
                sayi = sayi / 10;
               

                    Console.WriteLine("{0} ler basamağı= {1}", i, kalan);
                    toplam = toplam + kalan;
                    i = i * 10;
             }
            Console.WriteLine("toplam={0}", toplam);


            Console.ReadKey();

        }
    }
}
