using System;
using System.Threading;

namespace ArrayLists_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Lists
            /*Array içerisinde bulunan metodu kullanarak array içerisindeki sıralama yapabiliriz. 
             * short metodu mertinsel ifadelerde alfabetik sıraya göre a^dan z'ye doğru sıralar
             */

            string[] sehirler = new string[] { "Ankara", "izmir", "konya", "Elazığ", "Ankara", "Sivas", "Trabzon", "Zonguldak", "İStanbul","Van","Bursa" };
            Console.WriteLine("Orjinal Dizi Şekli\n----------------");
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            #region Short Metodu
            //şehirler dizisi içerisindeki ögeleri sıralayalım.
            Array.Sort(sehirler);
            Console.WriteLine("Short Metodu\n----------------------");
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine();
            #endregion


            #region Revers
            //Short metodunun tersine çalışan, array içerisindeki elemanları büyükten küçüğe doğru sıralamaya yarar.
            Array.Reverse(sehirler);
            Console.WriteLine("Reverse Metodu\n-----------------");
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine();

            #endregion

            #region IndexOf Metodu
            //Dizi içerisinde aradığımız elemanın index numarasını geriyedöndüren metoddur. Aranılan elema bulunamıyorsa -1 degerini döndürür. Eğer Aranılan elemandan birden fazla var ise sadece ilk elemanın index numarasını döndürür.
            //içerisine iki adet deger alır
            //İlk parametre aranılacak olan dizi,
            //ikinci parametre aranılacak deger.

            //Console.WriteLine("Aramak istediğiniz deger: ");
            //string deger =Console.ReadLine();
            //int index = Array.IndexOf(sehirler, deger);

            ////int index = Array.IndexOf(sehirler, "Adıyaman");
            //Console.WriteLine(index < 0 ? "aradığınız deger bulunamdaı." : $"Aranılan deger {index}. indextedir");

            #endregion

            #region LastIndexOf Metodu
            //IndexOf metodu ile aynı işlemi yapar. Fakat Aralarındaki fark IndexOf metou baştan aramaya başlar, LastIndexOf metodu sondan aramaya başlar.
            //Console.WriteLine("Aramak istediğiniz deger: ");
            //string deger = Console.ReadLine();
            //int index = Array.LastIndexOf(sehirler, deger);
            //Console.WriteLine(index < 0 ? "aradığınız deger bulunamdaı." : $"Aranılan deger {index}. indextedir");


            #endregion

            Console.Clear();

            #region Clear
            //Array içerisindeki elemanları silmek için kullanılan metoddur.
            //İçerisine 3 adet parametre alır.
            //1. Parametre kaynak dizi
            //2. Parametre başlangıç index degeri
            //3. Parametre silinece eleman sayısı

            //Console.WriteLine("Clear MEtodu\n-----------------");
            //foreach (var sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}
            //Console.WriteLine();

            //Şehirler dizisi içerisindeki 3. index ile 6. index arasındaki elemanları silelim.
            //Array.Clear(sehirler, 1, 4);

            //Şehirler dizisi içerisindeki tüm elemanları temizleyelim.
            //Array.Clear(sehirler, 0, sehirler.Length);
            //foreach (var sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}
            //Console.WriteLine();

            #endregion

            #region Copy Metodu
            //Bir diziden, başka bir diziye eleman kopyalamak için kullanılır.
            //Copy metodu kendi içerisinde farklı overloadları vardır.

            string[] yeniDizi = new string[4];

            Array.Copy(sehirler, yeniDizi, 4);
            Array.Copy(sehirler, 1, yeniDizi, 0, 4);
            ////(1=KaynakDizi ,  2= Kaynak Dizinin Kaçıncı İndeksinden Başlanacak , 3=Hedef Dizi ,  4=Hedef dizinin Kaçıncı indexinden eklemeye başlanacak , 5=Kaç Adet Eleman Eklenecek)


            //Console.WriteLine("Copy Metodu\n--------------");
            foreach (var dizi in yeniDizi)
            {
                Console.WriteLine(dizi);
            }
            Console.WriteLine();

            #endregion

            #region Resize Metodu
            //Tanımlanan dizinin boyutunu yeniden ayarlamak için kullanılır.

            Array.Resize(ref sehirler,5);

            Console.WriteLine("Resize Metodu\n--------------"); 
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine();



            #endregion


            Thread.Sleep(3000);
        }
    }
}
