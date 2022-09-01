using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleÖrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girinlen sayıya kadar asal sayıları bulan program

            Console.WriteLine("Bir sayı giriniz.");
            int deger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------");
            for (int i = 0; i <= deger; i++)
            {
                int say = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        say++;
                    }
                }
                if (say == 2)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}

