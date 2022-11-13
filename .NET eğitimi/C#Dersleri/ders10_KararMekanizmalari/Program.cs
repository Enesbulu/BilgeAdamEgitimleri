using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders10_KararMekanizmalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 3 adet sayı talep edelim. Sayılardan büyük olanı ekrana yazdıralım.
            Console.WriteLine("3 Adet sayi giriniz.");
            Console.WriteLine("1. Sayi");
            int sayi1 =int.Parse( Console.ReadLine());
            Console.WriteLine("2. Sayi");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3. Sayi");
            int sayi3 = int.Parse(Console.ReadLine());
            int buyukSayi;
            //--1. Yol--
            // 
            // if (sayi1 >= sayi2 && sayi1 >= sayi3)
            // {
            //     //Console.WriteLine("En Büyük sayı: " + sayi1);
            //     buyukSayi = sayi1;
            // }
            // else if (sayi2 >= sayi1 && sayi2 >= sayi3)
            // {
            //     //Console.WriteLine("En Büyük sayı: " + sayi2);
            //     buyukSayi = sayi2;

            // }
            //// else if(sayi3>sayi1 && sayi3 > sayi2)
            //else
            // {
            //     // Console.WriteLine("En Büyük sayı: " + sayi3);
            //     buyukSayi = sayi3;

            // }
            // Console.WriteLine("En büyük sayi : " + buyukSayi);

            //--2. Yol -- 
            if (sayi1 >= sayi2 && sayi1 > sayi3)
            {
                buyukSayi = sayi1;
            }
            else 
            {
                if (sayi2 >= sayi3 && sayi2 > sayi1)
                {
                    buyukSayi = sayi2;
                }
                else
                {
                    buyukSayi = sayi3;
                }
            }
            
            Console.WriteLine("En büyük sayi : " + buyukSayi);
            Console.ReadLine();
        }
    }
}
