using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Değerini Giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());

            int faktoriyel = 1;
            for(int i=1;i<=sayi;i++)
            {
                faktoriyel += faktoriyel * i;
            }
            Console.WriteLine("{0} sayısının Faktoriyeli= {1}", sayi, faktoriyel);
            Console.ReadKey();
        }
    }
}
