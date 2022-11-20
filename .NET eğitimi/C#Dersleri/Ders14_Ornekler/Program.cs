using System;
using System.Threading;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ders14_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ornek1
            /*
            //Kullanıcıdan 2 adet sayı talep edelim. Büyük sayidan küçük sayıya kadar 3'er 3'er ekrana yazıralım
            Console.Write("Bir sayı giriniz: ");
            short sayi1 = short.Parse(Console.ReadLine());
            Console.Write("Bir sayı giriniz: ");
            short sayi2 = short.Parse(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                short temp = sayi1;
                sayi1 = sayi2;
                sayi2 = temp;
            }
            Console.WriteLine($"Büyük Sayı: {sayi2}, Küçük sayi: {sayi1}");
            for (int i = sayi2; i >= sayi1; i -= 3)
            {
                Console.Write(i + " ");
            }
            */
            #endregion

            #region Ornek2
            //kullanıcıcan 10 adet sayı talep edelim. Talep edilen sayıların toplamını ekranan yazdıralım.
            /* short toplam = 0;
             for (int i = 1; i <= 10; i++)
             {
                 Console.Write($"\nLütfen {i}. sayı giriniz: ");
                 toplam += short.Parse(Console.ReadLine());
             }
             Console.WriteLine("Toplam: "+toplam);

             */

            #endregion

            #region Ornek3

            //kullanıcıya kaç adet sayı girmek isteğini sorun. Girmek istediği sasyı kadar kullanıcıdan deger talep edin. girilen degerlerden en küçüğünü ve en büyüğünü ekrana yazdırın.
            /* Console.Write("Kaç adet sayı girmek istiyorsunız? : ");
             short donguayisi = short.Parse(Console.ReadLine());
             short enBuyuk = 0, enKucuk = 0, temp = 0;
             for (int i = 0; i < donguayisi; i++)
             {
                 if (i == 0)
                 {
                     Console.Write((i + 1) + ". Sayıyı giriniz: ");
                     temp = short.Parse(Console.ReadLine());
                     enKucuk = temp;
                     enBuyuk = enKucuk;
                 }
                 else
                 {
                     Console.Write((i + 1) + ". Sayıyı giriniz: ");
                     temp = short.Parse(Console.ReadLine());
                     if (enBuyuk < temp)
                     {
                         enBuyuk = temp;
                     }
                     if (enKucuk > temp)
                     {
                         enKucuk = temp;
                     }
                 }


             }
             Console.WriteLine($"En küçük sayı: {enKucuk}");
             Console.WriteLine($"En büyük sayı: {enBuyuk}");
             */
            #endregion

            #region Ornek4

            //Kullanıcıdan 2 adet sayı talep edelim. 1. sayının 2. sayıya üssünü hesaplayalım.
            /* Console.Write("Taban degerini giriniz: ");
             short taban = short.Parse(Console.ReadLine());
             Console.Write("Üs sayısını giriniz: ");
             short usSayısı= short.Parse(Console.ReadLine());
             int sonuc = 1;
             for (int i = 0; i < usSayısı; i++)
             {
                 sonuc *= taban;
             }
             Console.WriteLine($"{taban} sayısnın {usSayısı}. kuvveti : {sonuc}");*/
            #endregion

            #region Ornek5
           /* //Belirtilen en ve boy degerine göre dikdörtgen degerini çizdiriniz.
            Console.Write("En bilgisi giriniz: ");
            byte enBilgisi = byte.Parse(Console.ReadLine());
            Console.Write("Boy Bilgisi Giriniz: ");
            byte boyBilgisi = byte.Parse(Console.ReadLine());

            for (int i = 0; i < boyBilgisi; i++)
            {
                for (int j = 0; j < enBilgisi; j++)
                {
                    if (i == 0 || i ==boyBilgisi-1)
                    {
                        for (int l = 0; l < enBilgisi-1; l++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();                        
                    }
                    else
                    {
                        Console.WriteLine();
                        for (int k = 0; k < (enBilgisi-2); k++)
                        {
                            Console.Write("* ");
                        }
                    }
                    
                }
            }

          
            */
            #endregion

            #region Ornek6
            //Belirtilen en ve boy bilgisine göre satranç tahtası çizelim.
           /* Console.Write("Yatay kutucuk sayısı giriniz: ");
            byte yatay = byte.Parse(Console.ReadLine());
            Console.Write("Düşey kutucuk sayısı giriniz: ");
            byte dusey = byte.Parse(Console.ReadLine());
            for (int i = 0; i < dusey; i++)
            {
                for (int j = 0; j < yatay; j++)
                {
                    if (i %2 ==0 && j %2 ==0)
                    {
                        Console.BackgroundColor= ConsoleColor.Black;
                        Console.Write("  ");
                    }
                    else if (i %2 ==0 &&   j % 2 ==1 )
                    {
                        Console.BackgroundColor= ConsoleColor.White;
                        Console.Write("  ");
                    }
                    else if (i %2 ==1 && j%2==0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }*/

            #endregion



            Thread.Sleep(5000);
        }
    }
}
