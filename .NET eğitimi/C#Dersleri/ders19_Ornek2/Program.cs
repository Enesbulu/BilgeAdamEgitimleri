using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ders19_Ornek2
{
    internal class Program
    {
        public static double getInt(string metin)
        {
            double sayi = 0;
            bool hata =false;
            do
            {
                Console.WriteLine(metin);
                try
                {
                    sayi = Convert.ToDouble(Console.ReadLine());
                    hata = false;
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hatalı Giriş yaptınız.\nLütfen geçerli bir giriş yapınız.\n");
                    hata= true;
                }
            } while (hata);

            return sayi;
        }
        public static void Ortalama(double[] sayilar)
        {
            double toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            Console.WriteLine("Ortalama: " + toplam/sayilar.Length );
        }
        static void Main(string[] args)
        {
            //Kullanıcıdan 3 adet sayı talep edelim(Hata kontrolü sağlamak için fonksiyon kullanalım.)
            //Sayıların ortalamasını ekrana yazdıralım.
            Console.WriteLine("Lütfen 3 adet sayi giriniz.");
            //int sayi1 = getInt("1.sayiyi giriniz");
            //int sayi2 = getInt("2.sayiyi giriniz");
            //int sayi3 = getInt("3.sayiyi giriniz");
            Double[] sayi = new double[3];
            for (int i = 0; i < 3; i++)
            {
                sayi[i] = getInt($"{i + 1}.sayiyi giriniz");
            }
            Ortalama(sayi);

            Thread.Sleep(2000);
        }    
    }
}
