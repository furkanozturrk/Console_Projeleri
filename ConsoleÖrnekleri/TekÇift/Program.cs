using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekÇift
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayının tek ve çift durumu
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int tek = 0;
            int çift = 0;
            Console.WriteLine("--------------");
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}   çift sayıdır.", i);
                    çift++;


                }
                else
                {
                    Console.WriteLine("{0}   tek sayıdır.", i);
                    tek++;
                }
            }
            Console.WriteLine("--------------");
            Console.WriteLine("{0} tane tek {1} tane çift sayı vardır.", tek, çift);
            Console.ReadLine();
        }
    }
}
