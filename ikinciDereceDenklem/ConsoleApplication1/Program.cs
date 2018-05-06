using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            
           double delta,kok1,kok2;

            Console.Write("ax^2+bx+c 2.derece Denklem Çözümü:\n");
            do{
               
             Console.Write("a katsayı değerini giriniz:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
                Console.Write("0 degerini giremezsiniz\n");
            }while(a==0);
            do
            {

                Console.Write("b katsayı değerini giriniz:");

                b = Convert.ToInt32(Console.ReadLine());
                if (b == 0)
                    Console.Write("0 degerini giremezsiniz\n");
            } while (b == 0);
            do
            {
                Console.Write("c sabit değerini giriniz:");
                c = Convert.ToInt32(Console.ReadLine());
                if (c == 0)
                    Console.Write("0 degerini giremezsiniz\n");
            } while (c == 0);

           
            delta = (b * b) - 4 * a * c;
            if (delta == 0)
            {
                kok1 = -b / (2 * a);
            
                Console.Write("Çakışık İki Kök vardır ve sonuç:{0}",kok1);
            }
               
            else if(delta<0)
            {

                 Console.Write("Çözüm Kümesi Boş Kümedir");

            }
          
            else
            {   delta=Math.Sqrt(delta);
                kok1= (-b + delta) / 2 * a;
                kok2=(-b - delta) / 2 * a;
                Console.Write("Kok1:{0}\n",kok1);
                Console.Write("Kok2:{0}\n", kok2);


            }
            Console.ReadKey();




        }

           
    }
}
