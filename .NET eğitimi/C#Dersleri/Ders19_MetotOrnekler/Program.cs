using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ders19_MetotOrnekler
{
    internal class Program
    {
        #region İslemler
        public static float Toplama(float[] dizi)
        {
            float toplam = 0;
            foreach (var item in dizi)
            {
                toplam += item;
            }

            return toplam;
        }

        public static float Cikarma(float[] dizi)
        {
            float cikarma = 0;
            cikarma = dizi[0] - dizi[1];
            return cikarma;
        }

        public static float Carpma(float[] dizi)
        {
            float carpma = 1;
            foreach (var item in dizi)
            {
                carpma *= item;
            }

            return carpma;
        }

        public static float Bolme(float[] dizi)
        {
            float bolme = 0;
            bolme= dizi[0] / dizi[1];

            return bolme;
        }
        #endregion

        public static float DortIslem(float[] sayilar,ConsoleKeyInfo islem)
        {
            float sonuc = 0;
            switch (islem.Key)
            {
                case ConsoleKey.Add:
                    sonuc = sayilar[0]+ sayilar[1]; 
                    break;
                case ConsoleKey.Subtract:
                    sonuc = sayilar[0] - sayilar[2];
                    break;
                case ConsoleKey.Multiply:
                    sonuc = sayilar[0] *sayilar[1];
                    break;
                case ConsoleKey.Divide:
                    sonuc = sayilar[0] / sayilar[1];
                    break;
                default:
                    Console.WriteLine("Hatalı giriş");
                    break;
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            //Kullanıcıdan s adet sayı, 1 adet işlem türü isteyelim. 4 işlem isminde fonksiyon oluşturup sonucu geri döndürelim.
            //Main içerisinde sonucu ekrana yazdıralım.
            /*//I. Yol
             
             Console.WriteLine("Lütfen iki adet sayi girini.");
             float[] sayilar=new float[2];
             for (int i = 0; i < sayilar.Length; i++)
             {
                 Console.WriteLine($"{i+1}. sayiyi giriniz: ");
                 sayilar[i]=float.Parse(Console.ReadLine());
             }
             Console.WriteLine("İşlem türünü belirtiniz: " + "\nToplama : +" + "\nÇıkarma: -" + "\nÇarpma: *" + "\nBölme: /" + "");
             ConsoleKeyInfo islem = Console.ReadKey().Key;
             switch (islem)
             {
                 case '+':
                     Console.WriteLine("Sayiların toplamı:" + Toplama(sayilar) ); 
                     break;
                 case '-':
                     Console.WriteLine("Sayiların farkı:" + Cikarma(sayilar));
                     break;
                 case '*':
                     Console.WriteLine("Sayiların çarpımı:" + Carpma(sayilar));
                     break;
                 case '/':
                     Console.WriteLine("Sayiların bölümü:" + Bolme(sayilar));
                     break;
                 default:
                     Console.WriteLine("Hatalı giriş!!");
                     break;
             }*/

            //II. Yol
            Console.WriteLine("Lütfen iki adet sayi girini.");
            float[] sayilar = new float[2];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i + 1}. sayiyi giriniz: ");
                sayilar[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("İşlem türünü belirtiniz: " + "\nToplama : +" + "\nÇıkarma: -" + "\nÇarpma: *" + "\nBölme: ");
            //ConsoleKey islem = Console.ReadKey().Key;
            ConsoleKeyInfo islem = Console.ReadKey();
            
            float sonuc = DortIslem(sayilar, islem);
            Console.WriteLine($"\n{sayilar[0]} {islem.KeyChar} {sayilar[1]} = {sonuc}");

            Thread.Sleep(3000);
        }
    }
}
