using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutlakDeger
{
    class Program
    {
        static void Main(string[] args)
        {
            //girinlen a ve b dizisinin mutlak farkını bulma.
            int a = 0;
            int b = 0;
            
            Console.Write("a ve b dizisini Giriniz:");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]== 'a' )
                {
                    a++;
                }
                else if (s[i] == 'b' )
                {
                    b++;
                }              
            }
            Console.WriteLine(Math.Abs(a-b));            

            Console.ReadLine();
        }
    }
}
