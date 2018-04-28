using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen N değerini giriniz::");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] dizi= new string[] {"S","Ü","M","E","Y","Y","E"};
            int sayi=0;
            int sayac=0 ;
            for(int i=0;i<=(n-1);i++)
            {
                for(int j=0;j<(n-i);j++)
                {
                    Console.Write(" ");

                }
                for(int k=0;k<(2*i+1);k++)
                {
                 if(sayi==6)
                    {
                        sayi-=6;
                        Console.Write(dizi[sayi]);
                        sayi+=1;
                       
                     
                    }
                 else
                 {
                     Console.Write(dizi[sayi]);
                     sayi+=1;
                    
                     
                 }
                 sayac += 1;

                
                }
                Console.WriteLine(" ");

            }
           
            Console.ReadKey();
                  
            
        }
    }
}
