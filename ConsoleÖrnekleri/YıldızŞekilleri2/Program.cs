using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YıldızŞekilleri2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgenin kenar uzunlugunu giriniz : ");
            int kenar = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= kenar; i++)
            {
                for (int k = i; k <= kenar; k++) 
                {
                    Console.Write(" ");
                }
                for (int t = 0; t <= i; t++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


