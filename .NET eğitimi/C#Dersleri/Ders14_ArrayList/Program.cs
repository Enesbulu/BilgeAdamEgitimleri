using System;
using System.Threading;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ders14_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays(Diziler)
            /*Syntax
             * ---------
             * <veriTipi>[] <degiskenAdi> = new <veriTipi>[<adet>];
             */
            /*
            //İçerisinde  adet eleman bsrındıran int[] oluşturalım.
            int[] sayilar = new int[5];

            //Syntax
            //<degiskenAdi>[<index>] = <deger>;
            sayilar[0] = 1;
            sayilar[3] = 2;
            sayilar[1] = 3;
            sayilar[2] = 4;
            sayilar[4] = 5;

            //Dizi içerisindeki elemanları ekrana yazdıralım.
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i}. indexdeki eleman {sayilar[i]}");
            }

            //II. Array tanımlaması
            string[] sehirler = { "İstanbul", "Manisa", "İzmir", "Mersin", "Antalya" };

            //III. Tanımlama Yöntemi
            char[] karakterler = new char[4] {'a','b','c','d'};

            Console.WriteLine("Karakterler arrayi içerisindeki ilk eleman: " + karakterler[0]);
            Console.WriteLine("Karakterler arrayi içerisindeki son eleman : " + karakterler[karakterler.Length - 1]);


            */


            #endregion

            #region Ornek1
            //Kullanıcıdan 5 adet sayı isteyelim ve talep edilen sayıları ekrana yazdıralım
            int[] sayilar = new int[5];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"{i+1}. sayiyi giriniz: ");
                sayilar[i] = int.Parse( Console.ReadLine() );
            }
            Console.WriteLine("\nGirilen Sayılar: ");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i] + " ");
            }

            #endregion


            Thread.Sleep(3000);
        } 
    }
}
