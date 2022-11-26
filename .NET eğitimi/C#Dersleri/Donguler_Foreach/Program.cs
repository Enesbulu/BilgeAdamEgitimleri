using System;
using System.Threading;

namespace Donguler_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach
            //-- FOREACH Dongü Mekanizması --
            //----------------
            //Yapı olarak almış olduğu koleksiyonun içerisindeki değerleri teker teker döner. Herhangi bir index numarasına ihtiyaç duymayan bir döngü mekanizmasıdır.
            //Foreach mekanşzması içerisinde index mantığı yoktur. Tip bağımlı döngülerdir.

            //Syntax
            //foreach (var <item> in <collection>)
            //{
            //   komut satırları
            //}

            /*int[] sayilar = { 45, 68, 71, 17, 5, 456, 254698 };
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            */
            #endregion

            #region Ornek1

            //Kullanıcıdan kaç adet sayı gireceğinin bilgisini alalım.
            //Girilen adet kadar kullanıcıdan sayı talep edelim.
            //Talep edilen sayıları array içerisinde barındıralım.
            //Array içerisindeki sayıların toplamını ve ortalamasını ekrana yazdıralım.
            /*
            Console.Write("Girmek istediğiniz sayı miktarını giriniz: ");
            short girilecekMiktar=short.Parse(Console.ReadLine());
            int[] sayilar = new int[girilecekMiktar];
            for (int i = 0; i < girilecekMiktar; i++)
            {
                Console.Write($"\n{i+1}. sayiyi giriniz:");
                sayilar[i] = int.Parse(Console.ReadLine());

            }
            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine($"Sayıların toplamı {toplam},\t Ortalaması: {((double)toplam/sayilar.Length)}");
            */
            #endregion

            #region Ornek2
            //Kullanıcıdan kaç adet sayı oluşturmak istediğini talep edelim.
            //Belirtilen sayı kadar rastgele degr oluşturup bir array içerisinde tanımlayalım.
            //Tanımlanan sayıların tek ve çift olanlarının toplamını ve ortalamasını ekrana yazdıralım.
            //2 Adet döngü mekanizması kullanalım.
            System.Console.Write("Kaç adet sayi girmek istiyorsunuz : ");
            short girdiSayisi= short.Parse(System.Console.ReadLine());
            int[] sayilar = new int[girdiSayisi];
            int ciftToplam = 0, tekToplam = 0,tekSayi=0,ciftSayi=0;
            Random rndSayi = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i]=rndSayi.Next(1,1001);
              
            }

            foreach (var sayi in sayilar)
            {
                if (sayi% 2 == 0)
                {
                    ciftToplam += sayi;
                    ciftSayi++;
                    Console.WriteLine("Çift Sayı:"+sayi);
                }
                else
                {
                    tekToplam += sayi;
                    tekSayi++;
                    Console.WriteLine("Tek SAyi: "+ sayi);
                }
            }
            double tekOrt = (double)tekToplam / tekSayi;
            double ciftOrt =(double)ciftToplam / ciftSayi;

            Console.WriteLine($"Tek Sayıların toplamı: {tekToplam}\t Tek Sayılarn Ortalaması: {tekOrt} \nÇift Sayıların Toplamı: {ciftToplam} \tÇift sayiların Ortalaması: {ciftOrt}");
            

            #endregion

            Thread.Sleep(5000);
        }
    }
}
