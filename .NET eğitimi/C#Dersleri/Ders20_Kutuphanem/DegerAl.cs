using System;

namespace Ders20_Kutuphanem
{
    public static class DegerAl
    {
        public static string GetString(this string metin, bool isnumeric = true)
        {
            string txt = string.Empty;
            bool hata = false;
            do
            {
                Console.Write(metin);
                txt = Console.ReadLine();
                if (string.IsNullOrEmpty(txt))
                {
                    hata = true;
                    Console.WriteLine("Boş bırakılamaz!");
                }
                else if (!isnumeric)
                {
                    for (int i = 0; i < txt.Length; i++)
                    {
                        if (txt[i] >= '0' && txt[i] <= '9')
                        {
                            hata = true;
                            Console.WriteLine("Numeric bir deger giremezsiniz!");
                            break;

                        }
                    }
                }
                else
                {
                    hata = false;
                }

            } while (hata);
            return txt;

        }

        public static int GetInt(this string metin, int min = int.MinValue, int max = int.MaxValue)
        {
            int sayi = 0;
            bool hata = false;
            do
            {
                Console.WriteLine(metin);
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        hata = true;
                        Console.WriteLine($"Lütfen {min} ile {max} arasında bir deger giriniz.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            } while (hata);

            return sayi;
        }

        public static double Getdouble(this string metin, double min = double.MinValue, double max = double.MaxValue)
        {
            double sayi = 0;
            bool hata = false;
            do
            {
                Console.WriteLine(metin);
                try
                {
                    sayi = double.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        hata = true;
                        Console.WriteLine($"Lütfen {min} ile {max} arasında bir deger giriniz.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            } while (hata);

            return sayi;
        }
    }
}
