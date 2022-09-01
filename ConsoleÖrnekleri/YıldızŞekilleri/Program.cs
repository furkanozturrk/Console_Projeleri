using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YıldızŞekilleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Satır uzunlugu : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun uzunlugu : ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
