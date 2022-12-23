using System;

namespace Ders20_ExtensionMetods.Model
{
    internal static class Metodlar
    {
        public static void TersineCevir(this string metin)  //Sadece string metodlar için kullnım sağlayan extenstion metod oluyor 'This' ile. Bundan sonra ___. dedikten sonra metoda erişim sağlayabiliriz.
        {
            for (int i = metin.Length -1; i >= 0; i--)
            {
                Console.Write(metin[i]);
            }
            Console.WriteLine();
        }

        public static int GetInt(this string metin, int min = int.MinValue,int max=int.MaxValue)
        {
            int sayi = 0;
            bool hata = true;
            do
            {
                Console.WriteLine(metin);
                try
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi>=min && sayi <=max)
                    {
                        hata=false;
                    }
                    else
                    {
                        hata = true;
                        Console.WriteLine($"Lütfen {min} ile {max} degerler arasında bir deger giriniz.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hata Mesajı:\t" + e);
                }
            } while (hata);




            return sayi;
        }


        public static int Topla(this int s1, int s2)
        {
            return s1 + s2;
        }
        public static double Topla(this double d1, double d2)
        {
            return d1 + d2;
        }

    }
}
