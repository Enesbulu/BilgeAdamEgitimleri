using System;
using System.Threading;

namespace Ders20_Metotlar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan en ve boy bilgisi talep edelim.
            //Talep edilen dikdörtgen bilgisine göre çevre ve alan hesaplaması yapan iki farklı metot oluşturup, ekrana sonucu yazdıralım.
            Console.WriteLine("lütfen en ve boy bilgilsi giriniz.");

            int enBilgisi = GetInt("Lütfen en bilgisini giriniz: ",1,100);
            int boyBilgisi = GetInt("Lütfen boy bilgisini giriniz: ",1,50);

            int alan = Alan(enBilgisi, boyBilgisi);
            int cevre = Cevre(enBilgisi, boyBilgisi);
            Console.WriteLine($"Dörtgenin alanı: {alan}\nDörtgenin Çevresi: {cevre}");

            Thread.Sleep(2500);

        }
        public static int Alan(int en, int boy)
        {
            int alan = en * boy;
            return alan;
        }

        public static int Cevre(int en, int boy)
        {
            int cevre = en * 2 + boy * 2;
            return cevre;
        }
        public static int GetInt(string metin,int min, int max )
        {
            int uzunluk = 0;
            bool hata;
            do
            {
                try
                {
                    Console.Write(metin);
                    uzunluk = Convert.ToInt32(Console.ReadLine());
                    if (uzunluk > min && uzunluk < max)
                    {
                        
                        hata = false;
                    }
                    else
                    {
                        hata = true;
                        Console.WriteLine($"Lütfen {min} degeri ile {max} degeri arasında bir deger giriniz. \n");
                    }
                    

                }
                catch (Exception)
                {
                    hata = true;
                    Console.WriteLine("\nHatalı giriş. Lütfen geçerli bir sayi giriniz!\n");
                }

            } while (hata);
            return uzunluk;
        }
    }
}
