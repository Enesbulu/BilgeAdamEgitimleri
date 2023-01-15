using Ders24_Class.Model;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;

namespace Ders24_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program içerisinde oluşturulan bir sınıf yapısını uygulama içerisindef kullanılabilmesi için instance işlemi uygulanması gerekmektedir.Instance işlemi çağırılan nesneyi referans olarak tannımlanmasını yapıp kullanılabilmesini sağlar.

            //Kişi sınıfını instance edelim.
            Kisi k = new Kisi();
            k.Ad = "Ali";
            k.Soyad = "Kaçar";
            k.DogumTarihi = new DateTime(2000, 11, 25);
            k.Sehir = "İstanbul";
            k.Adres = "Sariyer";

            Console.WriteLine("Kişi Bilgileri:");
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Ad: "+k.Ad);
            //Console.WriteLine("Soyad: "+k.Soyad);
            //Console.WriteLine("Doğum Tarihi: "+ k.DogumTarihi.ToShortDateString());
            //Console.WriteLine("Şehir: " + k.Sehir);
            //Console.WriteLine("Adres: "+k.Adres);
            //k.Yazdır();

            Kisi k2 = new Kisi();
            k2.Ad = "Ayşe";
            k2.Soyad = "Korkmaz";
            k2.DogumTarihi = DateTime.Parse("10.09.2001");
            k2.Sehir = "İzmir";
            k2.Adres = "Alaçatı";

            //k2.Yazdır();

            Kisi k3 = new Kisi();
            k3.Ad = "Hasan";
            k3.Soyad = "Kaya";
            k3.DogumTarihi = DateTime.Parse("12.05.1998");
            k3.Sehir = "Ankara";
            k3.Adres = "Gaziosmanpaşa";

            //Kişi sınıfı barındıran bir koleksiyon oluşturuldu.
            List<Kisi> kisiler = new List<Kisi>();
            //Kişiler koleksiyonu içerisine öğe ekleyelim.
            kisiler.Add(k);
            kisiler.Add(k2);
            kisiler.Add(k3);

            ////for ile yazdırma
            //for (int i = 0; i < kisiler.Count; i++)
            //{
            //    kisiler[i].Yazdır();
            //}


            ////Foreach ile yazdırma
            //foreach (var kisi in kisiler)
            //{
            //    kisi.Yazdır();
            //}

            ////foreach extension metod ile kişileri yazdırma
            //kisiler.ForEach(x=>k.Yazdır());



            Kisi k4 = new Kisi();
            Console.Write("Ad Giriniz: ");
            k4.Ad = Console.ReadLine();
            Console.Write("Soyad Giriniz:");
            k4.Soyad = Console.ReadLine();
            Console.Write("Doğum Tarihi giriniz: ");
            k4.DogumTarihi=DateTime.Parse(Console.ReadLine());
            Console.Write("Şehir giriniz: ");
            k4.Sehir = Console.ReadLine();
            Console.Write("Adres Giriniz: ");
            k4.Adres = Console.ReadLine();

            kisiler.Add(k4);
            kisiler.ForEach(x=>x.Yazdır());
            Console.ReadKey();
        }
    }
}
