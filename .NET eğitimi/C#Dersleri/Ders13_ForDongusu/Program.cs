using System;
using System.Threading;

namespace Ders13_ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For
            /*  For Döngüsü   */

            //Alfabedeki küçük karakterleri yazdıralım.
            /*for (char karakter = 'a'; 'z' >= karakter; karakter++)
            {
                Console.WriteLine(karakter);
            }*/

            //Alfabedeki büyük karakterleri yazdıralım.
            /*for (char karakter = 'Z'; karakter >= 'A'; karakter--)
            {
                Console.WriteLine(karakter + " : "+ (int)karakter);
            }
            */

            //Kullanıcıdan 2 adet sayı talep edelim. Talep edilen küçük olan sayıdan büyük olan sayıya kadar ekrana yazdıralım.
            /* Console.Write("Küçük bir sayı giriniz: ");
             short kucukSayi= short.Parse(Console.ReadLine());
             Console.Write("\nBüyük Sayı giriniz: ");
             short buyukSayi = short.Parse(Console.ReadLine());
             if (kucukSayi>buyukSayi)
             {
                 short temp = kucukSayi;
                 kucukSayi = buyukSayi;
                 buyukSayi= temp;
             }
             short sayac = 0, toplam=0;
             for (; kucukSayi <= buyukSayi; kucukSayi++)
             {
                 Console.Write(kucukSayi + " \n");
                 toplam += kucukSayi;
                 sayac++;
             }
             if (sayac!=0)
             {

                 Console.WriteLine($"toplam : {toplam}");
                 Console.WriteLine($"Ortalama: {toplam/(double)sayac}");

             }
             else
             {
                 Console.WriteLine("Hesaplama işlemi sağlanamadı");
             }

             */


            //Kullanıcıdan bir sayı girmesini isteyelim. Girilen sayının kaç basamaklı olduğunu ekrana yazdıralım.
            Console.Write("Bir sayi Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int basamak = 0;
            for (int i = sayi; i >0;  i/=10)
            {
                basamak++;

            }
            Console.WriteLine(sayi+" degerinini basamak degeri : " + basamak);

            Thread.Sleep(3000);
            #endregion
        }
    }
}
