using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirinlenSayınınRakamlarToplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayının rakamlar toplamı
            Console.WriteLine("Bir Sayı Giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;

            while (sayi > 0)
            {
                sayac +=(sayi % 10);
                sayi = sayi / 10;
            }     
            Console.WriteLine("Girilen sayının rakamlar toplamı : {0}",sayac);
            Console.ReadLine();
        }

    }
}
