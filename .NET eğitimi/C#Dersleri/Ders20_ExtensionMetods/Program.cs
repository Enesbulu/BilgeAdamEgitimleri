using System;
using Ders20_ExtensionMetods.Model;

namespace Ders20_ExtensionMetods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static olarak tanımlı olan class içerisindeki sstatic fonksiyonlara erişim sağlamak için <ClassAdi>.<fonksiyonAdi>(); komutu ile erişim sağlayabilirsiniz.
            /*string deger = "Merhaba Dünya";
            //Metodlar.TersineCevir(deger);
            deger.TersineCevir();
             */

            int sayi1 = Metodlar.GetInt("1. Sayiyi giriniz: ", 0, 100);
            int sayi2 = "2. Sayiyi Giriniz: ".GetInt(1,100);

            int toplam1 = Metodlar.Topla(sayi1, sayi2);
            int toplam2 = sayi1.Topla(sayi2);
            Console.WriteLine("Sayıların toplamı: "+toplam2);

            







            Console.ReadKey();
        }
    }
}
