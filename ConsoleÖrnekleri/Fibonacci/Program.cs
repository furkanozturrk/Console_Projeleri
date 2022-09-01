using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci
            int a = 1;
            int b = 1;
            int c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < 5; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}


