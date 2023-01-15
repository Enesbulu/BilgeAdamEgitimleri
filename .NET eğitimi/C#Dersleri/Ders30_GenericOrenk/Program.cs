using Ders30_GenericOrenk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_GenericOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koleksiyon<int> sayilar = new Koleksiyon<int>();
            sayilar.Ekle(45);
            sayilar.Ekle(36);
            sayilar.Ekle(78, 42, 39, 1235, 5687, 45687);
            Console.WriteLine("Eleman Sayısı: " + sayilar.ElemanSayisi);
            sayilar.Yazdır();



            int[] girilenSayılar = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Girmek isteğidiniz Sayı: ");
                //sayilar.Ekle(int.Parse(Console.ReadLine()));
                girilenSayılar[i] = int.Parse(Console.ReadLine());
            }

            sayilar.ArayaEkle(girilenSayılar,2);

            Console.WriteLine();
            sayilar.Yazdır();





            Console.ReadKey();
        }
    }
}
