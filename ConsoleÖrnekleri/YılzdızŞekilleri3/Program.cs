using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YılzdızŞekilleri3
{
    class Program
    {
        static void Main(string[] args)
        {
            //İçi boş kare
            Console.WriteLine("En Giriniz :");
            int en = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boy Giriniz :");
            int boy = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < boy; i++)
            {
                if (i == 0 || i == boy - 1)
                {
                    for (int j = 0; j < en; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int k = 0; k < en - 2; k++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("*");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}
