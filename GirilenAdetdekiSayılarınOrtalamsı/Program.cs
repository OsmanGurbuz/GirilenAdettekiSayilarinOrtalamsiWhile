using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenAdetdekiSayılarınOrtalaması

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            int adet = 0;
            int sayi = 0;
            int toplam = 0;
            int ortalama = 0;

            Console.WriteLine("Kaç adet sayı gireceksiniz ?");
            adet = Convert.ToInt32(Console.ReadLine());

            while (sayac<= adet)
            {
                Console.Write("Sayı giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
                sayac++;

            }
            ortalama = toplam / adet;
            Console.WriteLine("Sayıların Ortalaması : {0}",ortalama);
            Console.ReadKey();
        }
    }
}
