using System;
using Ders20_Kutuphanem;


namespace Ders20_LibraryOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string deger = "Adınız: ".GetString();
            Console.WriteLine("Girilen ad: "+deger);

            int sayi1 = "1. sayiyi giriniz: ".GetInt();//?
            int sayi2 = "2. sayiyi giriniz: ".GetInt(1, 100);
            double sayi3 = "3. sayıyı giriniz: ".Getdouble();
            double sayi4 = "4.sayiyi giriniz: ".Getdouble(1, 50);
            int toplam = Aritmetik.Toplam(sayi1 + sayi2);
            int carpim = Aritmetik.Carp(sayi1,sayi2);
            Console.WriteLine("Çarpım: "+carpim);
            Console.WriteLine("Toplam: "+toplam);

            Console.ReadKey();
        }
    }
}
