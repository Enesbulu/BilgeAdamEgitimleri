using System;
using System.Threading;

namespace ders19_Metotlar
{
    internal class Program
    {
        //Geriye değer döndürmeyen, parametre almayan metot
        public static void Yazdir()
        {
            Console.WriteLine("Merhaba Dünya");
               
        }
        
        //Parametre Alan, Geriye değer döndürmeyen metot
        public static void Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sayıların toplamı: " + toplam);
        }

        //Parametere alan, değer döndüren metot
        public static double ArrayOrtalamasi(int[] dizi)
        {
            int toplam = 0;
            foreach (var item in dizi)
            {
                toplam += item;
            }
            double ortalama = (double)toplam / dizi.Length;
            //return ortalama;
            return (double)toplam / dizi.Length;
        }
        static void Main(string[] args)
        {
            #region Metotlar

            Yazdir();
            Topla(5, 7);
            int[] dizi = { 5, 7, 9, 12, 25 };
            double ort = ArrayOrtalamasi(dizi);
            Console.WriteLine(ort);

            #endregion
            Thread.Sleep(2000);
        }
    }
}
