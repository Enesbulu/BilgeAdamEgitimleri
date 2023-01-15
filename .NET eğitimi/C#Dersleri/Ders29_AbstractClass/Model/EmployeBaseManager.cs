using System;

namespace Ders29_AbstractClass.Model
{
    /*Abstract Class (Soyut Class)
     * ------------------------
     * OOP'nin içersisindeki öneml ikavramlardan bir tanesidir. Programlarımız içerisinde bulunan faaliyet ögelerini gizleyerek sadece sınıfın sahip olduğu işlevleri gösterir. Bu durum projelerimize esneklik, güvenlik ve hızlı kontrol yapısı sağlar.
     * 
     * Abstract sınıfı kullanarak, nesne üretirken kullanacağınız bir şablon yapısı oluşturabilirsiniz.
     * 
     * Abstract sınıflr içerisinde bulunan bazı temel yapıları yeniden oluşturmak için 'override'(aşırı yükleme) işlemini uygular ve sınıf yapılarına göre özel bir hale getirebilirsiniz.
     * 
     * Abstract Class (Soyut Sınıf) oluştururken dikkat edilmesi gerekenler:
     * ---------------------------------------------------------------
     * - Bir abstract sınıfı oluşturuyorsak sınıf içerisinde muhakkak bir abstract metod, eğer bir abstract metod oluşturuyorsak muhakkak sınıf yapısında abstract olması gerekmektedir.
     * - Abstract sınıfı kullanrak türetilen sınıf içerisindeki abstract metod içerisideki abstract metot yapısı override edilerek içerisinin doldurulması gerekir.
     * 
     * Syntax
     * ---------------
     * <erisimTürü> abstract class <classAdi>{
     *  <ozellikler..>
     * }
     */
    internal abstract class EmployeBaseManager
    {
        private string isim, soyisim, unvan;
        private decimal maas;
        private int yillikIzin;
        

        //Hem kendi classı ierisinden hem de  miras ettiği yerde erişim yetkisi veriliyor.
        protected decimal Maas
        {
            get { return maas; }
            set
            {
                if (value >= 8500)
                {
                    maas = value;
                }
                else
                {
                    Console.WriteLine("Çalışan maasşı olarak min. asgari ücret belirtilmesi zorunludur.");
                    Console.WriteLine();
                }
            }
        }

        public string TamAd { get { { return isim + " " + soyisim; } } }
        //Sadece deger ataması yapılarbilir
        public void SetInfo(string isim, string soyisim, decimal maas)
        {
            if (isim.Length >= 3 && soyisim.Length >= 2)
            {
                if (maas >= 8500)
                {
                    //this ile class içerisineki fieldı alır.
                    this.isim = isim;
                    this.soyisim = soyisim;
                    this.maas = maas;
                    if (maas <= 10000)
                    {
                        this.unvan = "acemi " + unvan;
                        this.yillikIzin = 14;
                    }
                    else if (maas > 10000 && maas <= 15000)
                    {
                        this.unvan = "Deneyimli " + unvan;
                        this.yillikIzin = 20;

                    }
                    else if (maas > 15000 && maas <= 20000)
                    {
                        this.unvan = "Kıdemli " + unvan;
                        this.yillikIzin = 24;

                    }
                    else if (maas > 20000 && maas <= 25000)
                    {
                        this.unvan = "Uzman" + unvan;
                        this.yillikIzin = 30;
                    }
                }
                else
                {
                    Console.WriteLine("Çalışan maasşı olarak min. asgari ücret belirtilmesi zorunludur.");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("İsim ve soyisim bilgileri yeterli değil.");
                Console.WriteLine("Lütfen isim min. 3, soyisim min 2 karakter giriniz.");
                Console.WriteLine();
            }

        }

        public void GetInfo()
        {
            Console.WriteLine("Ad Soyad: " + this.TamAd);
            Console.WriteLine("Unvan: " + this.unvan);
            Console.WriteLine("Maas: " + this.maas);
            Console.WriteLine("Yıllık izin: " + this.yillikIzin);
            Console.WriteLine();

        }

        //Hem kendi classı ierisinden hem de  miras ettiği yerde erişim yetkisi veriliyor.
        protected void SetUnvan(string unvan)
        {
            this.unvan = unvan;

        }

        //Her sınıf için özel zam seçenekleri olabileceğinden dolayı soyut metot tanımlaması yapıldı.
        public abstract void ZamYap();
        public abstract void ZamYap(decimal zamOrani);

    }
}
