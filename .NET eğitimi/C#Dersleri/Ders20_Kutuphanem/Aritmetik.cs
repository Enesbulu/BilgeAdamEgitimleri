using System;

namespace Ders20_Kutuphanem
{
    public static class Aritmetik
    {
        public static int Toplam(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }
        public static double Toplam(params double[] sayilar)
        {
            double toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        public static int Carp(int s1, int s2)
        {
            return s1 * s2;
        }

        public static double Bol(double s1, double s2)
        {
            try
            {
                return s1 / s2;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static void BolveYaz(int s1, int s2)
        {
            try
            {
                Console.WriteLine("Sonuc: " + ((double)s1 / s2));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sıfıra bölme hatası");
            }
            catch (Exception e)
            {
                Console.WriteLine("hata: " + e);
            }
        }






    }
}
