using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Ders15_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List
            //List<T> koleksiyonu kendi içerisinde belirtilen tipe göre eleman barındıran bir koleksiyon yapısında sahiptir. Dizilerde olduğu gibi ilk olulturma işlemi esnasında içerisinde kaç adet eleman barınıracağının bilgisinin verilmesine gerek yoktur. Koleksiyon oluşturulduktan sonra içerisine eklenen ve çıkarılan elemanlara göre otomtik olarak boyutunu kendisi ayarlamaktadır. Bu sayede dizilerde olduğu gibi boyut ayarlama işlemine gerek yoktur.
            //List<T> yapısındaki T karakteri programlama dili içerisindeki bir tipi temsil eder. Bu tipler veritipi, sınıfı veya nesne olabilir. T alanı içerisinde tanımlanan türe göre veri barındırabilir. Herhangi bir boyut kısıtlaması yoktur.

            //Syntax
            //----------
            //List<T> <degiskenAdi> = new List<T>();
            #endregion

            #region Kullanımı

            //İçerisinde string türünden degerler barındıran bir list koleksiyonu oluşturalım.
            List<string> sehirler = new List<string>();

            //koleksiyon içerisinde bir eleman ekleme işlemi yapmak için Add() metodu kullanılır. Bu metod içerisine, koleksiyon içerisinde barındıran tipte deger alır.

            //Koleksiyon içerisinde bir eleman eklemek için 
            //<koleksiyonAdi>.Add(<T>);

            sehirler.Add("Ankar");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            sehirler.Add("Antalya");
            sehirler.Add("Manisa");

            //List<T> koleksiyonu içerisinde barındırılan eleman sayısını öğrenmek için count property sini kullanabilirsiniz. Eleman Sayısını tam türünden bilgisini verir.

            //<koleksiyon>.Count
            Console.WriteLine("Sehirler koleksiyonun eleman sayısı : " + sehirler.Count);
            Console.WriteLine();

            //Sehirler koleksiyonunun elemanlarına index numaraları aracılığıyla ulaşım sağlayabilirsiniz.
            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine(i + ". indexteki eleman: " + sehirler[i]);

            }
            #endregion

            #region Propertileri


            //List<T> koleksiyonu içerisindeki bir elemanı silmek için 2 farkı yöntem buunmaktadır.
            //1.Yontem=>RemoveAt(<index>) metodu ile index numarasına bağlı olarak belirtilen indexteki degeri siler.
            //2.Yöntem => Remove(<deger>) metodu ile belirtilen degere göre silme işlemi yapar. koleksiyon içerisindeki ilk veriyi siler.

            sehirler.Add("İzmir");
            Console.WriteLine();
            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine(i + ". indexteki eleman: " + sehirler[i]);

            }
            Console.WriteLine();
            sehirler.RemoveAt(4);

            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine(i + ". indexteki eleman: " + sehirler[i]);

            }
            sehirler.Remove("İzmir");


            //List<T> koleksiyonu içerisindeki bir eleman yeni deger atamak
            sehirler[2] = "Sivas";
            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine(i + ". indexteki eleman: " + sehirler[i]);

            }
            Console.WriteLine();

            //List<T> koleksiyonu içerisindeki elemanları sıralama işlemi
            sehirler.Sort();


            //List<T> koleksiyonu içerisindeki elemanları tersten sıralama işlemi
            sehirler.Reverse();

            //Koleksiyon içerisindeki elemanları siler.
            sehirler.Clear();

            //Koleksiyon içerisinde belirtilen deger arar. Deger var ise true deger yok ise false degeri döner.
            sehirler.Contains("İstanbul");


            //Koleksiyon içerisinde belirtlen indexe belirtilen degeri ekler.
            sehirler.Insert(1, "Manisa");

            //Koleksiyon içerisineki son elemanı veriri
            sehirler.Last();


            //Koleksiyon içerisindeki sayısal degerlerde en büyük degeri geri döndürür.
            Console.WriteLine(sehirler.Max());


            //Koleksiyon içerisindeki sayısal degerlerde en küçük degeri geri döndürür.
            Console.WriteLine(sehirler.Min());

            //Kolaksiyonu array'e çevirir
            sehirler.ToArray();

            //Array'i List<T> yapısına çevirme
            double[] rakamlar = { 12.5, 7.45, 8, 85 };
            List<double> liste = rakamlar.ToList();


            //Koleksiyon içerisinde aranan deger deger yoksa -1 degerini, varsa index numarası döner. Aynı deger birden fazla varsa ilk degeri döndürür.
            sehirler.IndexOf("Ankara");

            //IndexOf() Metodunun tersine arama işlemi yapar.
            sehirler.LastIndexOf("Mersin");
            //Koleksiyon içerisinde tek komut satırlık bir işlem yapılacak ise foreach() metodu kullanılabilir.
            //Foreach metodu içeriisnde bir lambda tanımlaması yapılmaktadır. => ifadesinden sonra komut satırınızı uygulayabilirsiniz.
            //<koleksiyonAdi>ForEACh(<takmaAd> => <komut>);
            sehirler.ForEach(sehir => Console.WriteLine(sehir));



            #endregion

            #region Ornek
            //Kullanıcıdan n adet sayı talep edelim.
            //Girilen sayıları bir koleksiyon içerisinde tutup  en küçük sayı, en büyük sayı, sayıların toplamı ve ortalamasını ekrana yazdıralım.

            Console.Write("Kaç adet sayı grimek istiyorsunuz : ");
            short girilecek = short.Parse(Console.ReadLine());
            List<int> sayilar = new List<int>();
            for (int i = 0; i < girilecek; i++)
            {
                Console.Write((i + 1) + ". Sayıyı Giriniz: ");
                sayilar.Add(int.Parse(Console.ReadLine()));
            }
            sayilar.Sort();

            //Console.WriteLine("En Küçük sayı: " + sayilar[0]);
            Console.WriteLine("En Küçük sayı: " + sayilar.Min());

            //Console.WriteLine("En Büyük sayi: " + sayilar[sayilar.Count-1]);
            Console.WriteLine("En Büyük sayi: " + sayilar.Max());

            int toplam = 0;
            sayilar.ForEach(sayi => toplam += sayi);
            //foreach (var sayi in sayilar)
            //{
            //    toplam += sayi;
            //}

            Console.WriteLine("Sayıların toplamı : " + toplam);
            Console.WriteLine("Sayılaın ortalaması: " + (double)toplam / sayilar.Count);


            #endregion


            Thread.Sleep(3000);
        }
    }
}
