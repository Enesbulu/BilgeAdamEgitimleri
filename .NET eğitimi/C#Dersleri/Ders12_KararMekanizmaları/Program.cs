using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ders12_KararMekanizmaları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch-Case
            //---Syntax--
            //switch (<deger>)
            //{
            //    case <durum>:
            //            break;
            //    case <>:
            //            break;
            //    default:
            //        break;
            //}

            #endregion

            #region
            /*
            //Mevsime göre ayları ekrana yazdıran uygulamayı ekrana yazdıralım.
            Console.WriteLine("Mevsim giriniz: ");
            string mevsim = Console.ReadLine();
            string mesaj = string.Empty; // boş string oluşturmak için kullanılır \ "";
            switch (mevsim)
            {
                case "Kış":
                    mesaj = "Aralık, Ocak, Şubat";
                    break;
                case "İlkbahar":
                    mesaj = "Mart, Nisan, MAyıs";
                    break;
                case "Yaz":
                    mesaj = "HAziran, Temmuz, Ağustos";
                    break;
                case "Sonbahar":
                    mesaj = "Eylül, Ekimi, Kasım";
                    break;

                default:
                    mesaj = mesaj + " adına sahip mevsim bulunamadı.";
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("'" + mevsim + "' bilgisine ait aylar " + mesaj);
           // Console.ReadKey();
            //Thread.Sleep(1000); //1000 Milisaniye(1 sn) bekleme
            TimeSpan ts = new TimeSpan(0,0,5); // 0 saat 0 dk 5 sn bekleme zamanlayıcı ayarlama
            Thread.Sleep(ts);   // zamanlayıcının çalıştırılması
            */
            #endregion

            #region MyRegion
            //Kullanıcıdan 2 adet sayı ve bir adet işlem türü (+,-,*,/) talep edelim.
            //girilen işlem türüne göre hesaplama sonucunu ekrana yazdıralım.
            //örnek çıktı: 3 * 5 = 15
            /*
            Console.WriteLine("Hadi Hesap Yapalım.. \n 2 Adet sayı giriniz.");
            Console.WriteLine("1. Sayi: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayi: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlem nedir? (+,-,*,/)");
            char islem = char.Parse(Console.ReadLine());
            double sonuc = 0;
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':sonuc = sayi1 - sayi2;
                    break;
                case '*': sonuc = sayi1 * sayi2;
                    break;
                case '/': sonuc = (double)sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("Hatalı Deger girdiniz");
                    break;
            }
            Console.WriteLine(sayi1 + " " + islem + " " + sayi2 + " = " + sonuc);
            Console.WriteLine("Sonuç : {0} {1} {2} = {3} ", sayi1,islem,sayi2,sonuc);
            Console.WriteLine($"Sonuc: {sayi1} {islem} {sayi2} = {sonuc}");
            Thread.Sleep(5000);
            */
            #endregion

            #region 
            //Ay bilgisine göre mevsimleri ekrana yazdıralım.
            /*
            Console.WriteLine("Ay giriniz: ");
            string aylar = Console.ReadLine();
            switch (aylar)
            {
                case "Ocak":
                case "Şubat":
                case "Aralik":
                    Console.WriteLine("Kış Mevsimi");
                    break;
                case "Mart":
                case "Nisan":
                case "Mayıs":
                    Console.WriteLine("İlkbahar Mevsimi");
                    break ;
                case "Haziraz":
                case "Temmuz":
                case "Ağustos":
                    Console.WriteLine("Yaz Mevsimi");
                    break;
                case "Eylül":
                case "Ekim":
                case "Kasım":
                    Console.WriteLine("sonbahar Mevsimi");
                    break;
                default:
                    break;
            }
            Thread.Sleep(5000);
            */
            #endregion


            #region 
            //Kullanıcı adı ve şifre karşılaştırmasıyla login similasyonu yapalım.
            Console.Write("Kullanıcı Giriniz: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifrenizi giriniz: ");
            string parola = Console.ReadLine() ;
            switch (kullaniciAdi)
            {
                case "BilgeAdam":
                    switch (parola)
                    {
                        case "123":
                            Console.WriteLine("Giris Başarılı");
                        break;
                        default:
                            Console.WriteLine("Hatalı Şifre Girişi!");
                            break;
                    } break;
                default:
                    Console.WriteLine(" Hatalı Kullanıcı adı!");
                    break;
            }


            #endregion

            TimeSpan ts = new TimeSpan(0, 0, 5); // 0 saat 0 dk 5 sn bekleme zamanlayıcı ayarlama
            Thread.Sleep(ts);   // zamanlayıcının çalıştırılması
        }
    }
}
