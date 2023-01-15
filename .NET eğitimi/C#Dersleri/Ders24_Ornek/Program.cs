using System;
using System.Collections.Generic;
using Ders24_Ornek;
namespace Ders24_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oğrenci(Ad,Soyad,Not1,Not2,Fnot)
            //Kullanıcıdan kaç adet çğrenci girileceğini soralım.
            //o kadar öğrencinini bilgilerini alp, öğrencileri bir koleksiyon içerisinde tutalım.
            //Koleksiyon içerisindeki öğrencilerin bilgilerini ekrana yazdıralım.
            
            List<Ogrenci> ogrList = new List<Ogrenci>();
            Console.Write("Kaç adet öğrenci girişi yapılacak?: ");
            short girileceksayi = short.Parse((Console.ReadLine()));
            for (int i = 0; i < girileceksayi; i++)
            {
                Ogrenci ogr = new Ogrenci();
                Console.WriteLine($"{i+1}. Öğrencinini");
                Console.Write("Adı: ");
                ogr.ad =Console.ReadLine();
                Console.Write("Soyadı: ");
                ogr.soyad = Console.ReadLine();
                Console.Write("Not1: ");
                ogr.not1=byte.Parse(Console.ReadLine());
                Console.Write("Not2: ");
                ogr.not2=byte.Parse(Console.ReadLine());
                Console.Write("Final not:");
                ogr.fNot=byte.Parse(Console.ReadLine());
                ogrList.Add((ogr));
            }

            ogrList.ForEach(x=>x.Yazdir());
            Console.ReadKey();
        }
    }
}
