using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t ****ÇARPIM TABLOSU****");
            Console.WriteLine("---------------------------------------------");

            for(int i=1;i<=10;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    Console.WriteLine("\t  {0} x {1} = {2}", i, j, i * j);

                }
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
