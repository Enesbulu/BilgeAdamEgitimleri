using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ders15_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ornek

            /*//kullanıcıdan kaç adet sayı girmek istediğini soralım.
            //sayıları talep edip bir array içerisinde barındıralım.
            //girilen ayıları içeriisnde en küçük olan sayı ile en büyük olan sayıyı yazdıralım.
            Console.Write("Kaç Adet sayı girmek istersiniz: ");
            byte adet = byte.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sayilar);
            //Console.WriteLine("Girilen en küçük sayi {sayilar[0]} \nEn büyük sayi {sayilar[sayilar.Length()-1]} ");
            Console.WriteLine("Girilen en küçük sayi: " + sayilar[0]);

            Console.WriteLine("Girilen en Büyük sayi: " + sayilar[sayilar.Length - 1]);
            //Array.Reverse(sayilar);
            //Console.WriteLine("Girilen en üçük sayi: " + sayilar[0]);
            */
            #endregion


            Thread.Sleep(3000);
        }
    }
}
