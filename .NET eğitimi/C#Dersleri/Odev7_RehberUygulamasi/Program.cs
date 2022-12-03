using System;
using System.Collections.Generic;
using System.Threading;
namespace Odev7_RehberUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Rehber Uygulaması
            ---------------------------------
            E- Kişi Ekle (Sadece ad soyad bilgisi alınarak string olarak kayıt edilecek.)
            L- Kişileri Listele (Koleksiyon içerisindeki isimler listelenecek.)
            S- Kişi Sil (Koleksiyon içerisindeki kişiler index numarasına göre silinecek.)
            A- Kişi Ara (Aramak istediğiniz metni girdikten sonra kişi adında bu değerleri barındıran kişiler varsa onlar listelenecek.)
            T- Silinen Kişiler (Silinen kişiler görüntülenecek.)
            X- Programdan Çık (Programda çıkılacak)
            */
            Console.WriteLine("Rehber Uygulamasına Hoşgeldiniz.");
            List<string> adSoyad = new List<string>();
            List<string> silinenKisiler = new List<string>();
            bool durum = true;

            do
            {
                Console.WriteLine("\n\nE- Kişi Ekle\nL- Kişileri Listele\nS- Kişi Sil\nA- Kişi Ara\nT- Silinen Kişiler\nX- Programdan Çık");
                Console.Write("Yapmak İstediğiniz İşlemi Seçiniz: ");
                char islem=' ';
                try
                {
                    islem = char.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine("Hata!! >> " + e);
                }
                
                switch (islem)
                {
                    #region Kisi Ekle
                    case 'e':
                    case 'E':
                        Console.Clear();
                        Console.WriteLine("--Bir Üst menüye dönmek için (x) 'e basınız.--");
                        for (; ; )
                        {
                            Console.Write("İsin - Soyisim Giriniz : ");
                            string temp = Console.ReadLine();
                            if ("x" == temp)
                            {
                                break;
                            }
                            adSoyad.Add(temp);
                        }
                        adSoyad.Sort();
                        break;
                    #endregion

                    #region Kisi Listele
                    case 'l':
                    case 'L':
                        Console.Clear();
                        foreach (var kisi in adSoyad)
                        {
                            Console.WriteLine(kisi);
                        }
                        break;
                    #endregion

                    #region Kisi Sil
                    case 's':
                    case 'S':
                        Console.Clear();
                        for (int i = 0; i < adSoyad.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + adSoyad[i]);
                        }
                        Console.Write("Silemek istediğiniz kişinin sıra numarasını giriniz: ");
                        short sira = short.Parse(Console.ReadLine());
                        silinenKisiler.Add(adSoyad[sira-1]);
                        adSoyad.RemoveAt(sira - 1);
                        Console.WriteLine("\nKayıt başarıyla silindi.");
                        break;

                    #endregion

                    #region Kisi Arama
                    case 'a':
                    case 'A':
                        Console.Clear();
                        Console.Write("Aramak istediğiniz Kişiyi yazınız: ");
                        string isim = Console.ReadLine();
                        int sirasi = (adSoyad.IndexOf(isim));
                        if (sirasi >= 0)
                        {
                            Console.WriteLine($"\nAranan Kişi bulundu.\n{sirasi + 1}-{adSoyad[sirasi]}");
                        }
                        else if (sirasi < 0)
                        {
                            Console.Write("\nAradığınız isim bulunamadı.");
                        }
                        else
                        {
                            Console.WriteLine("\nBir hatayla karşılaşılı!");
                        }

                        break;
                    #endregion

                    #region Silinen Kisiler
                    case 't':
                    case 'T':
                        Console.Clear();
                        foreach (var silinenler in silinenKisiler)
                        {
                            Console.WriteLine("Silinen Kişiler:\n-----------\n" + silinenler);
                        }
                        
                        break;
                    #endregion

                    #region Cıkıs
                    case 'x':
                    case 'X':
                        Console.Clear();
                        Console.WriteLine("Çıkış Yapılıyor..");
                        durum = false;
                        break;

                        #endregion

                    default: Console.WriteLine("Hatalı Bir giriş yapıldı!!");
                        break;
                    
                }
                

            } while (durum);



            Thread.Sleep(2000);
        }
    }
}
