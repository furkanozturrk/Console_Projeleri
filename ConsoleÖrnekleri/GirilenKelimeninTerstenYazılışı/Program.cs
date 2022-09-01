using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenKelimeninTerstenYazılışı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen kelimenin tersten yazılışı
            Console.WriteLine("Kelime giriniz : ");
            string kelime = Console.ReadLine();
            Console.WriteLine("Kelimenin tersi : ");
            for (int i = kelime.Length - 1 ; i >= 0; i--)
            {
                Console.Write(kelime[i]);
            }
            Console.ReadLine();
        }                
    }
}
