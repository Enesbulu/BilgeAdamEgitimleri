using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading;
//using System.Threading.Tasks;

namespace Odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region soru1
            #region  
            /*Yönergeler
                    Soru
                    Kullanıcıdan En ve Boy bilgisi talep edelim.
                    En ve Boy bilgisine göre bir dikdörtgen çizelim(içi boş olsun)
                    Örnek çıktı
                    --------
                    - -
                    - -
                    - -
                    --------
                   */

            #endregion
           /* 
            bool hataDurumu = false;
            byte kenar1 = 0,kenar2 = 0;

            do
            {
                hataDurumu = false;
                Console.Write("Dikdörtgenin yatay kenarını giriniz..: " );
                //Kenar1 (yatay) için girdi kontrolü

                try  //Hata beklenen yer
                {
                     kenar1 = byte.Parse(Console.ReadLine());
                    //hataDurumu = false;
                }
                catch (FormatException) //Format hatası yakalama
                {
                    hataDurumu = true;
                    Console.WriteLine("Lütfen sayı giriniz!!");
                }
                catch(OverflowException)    //veri limiti taşma yakalama
                {
                    hataDurumu = true;
                    Console.WriteLine($"Lütfen {Byte.MinValue} degeri ile {Byte.MaxValue} arası bir değer giriniz!");
                }
                catch (Exception ex)    //Genel hata yakalama
                {
                    hataDurumu = true;
                    Console.WriteLine(ex);
                }

                //Kenar2(Dikey) için girdi kontrolü
                Console.Write("Dikdörtgenin dikey kenarını giriniz..: ");
                try  //Hata beklenen yer
                {
                    kenar2 = byte.Parse(Console.ReadLine());
                    //hataDurumu = false;
                }
                catch (FormatException) //Format hatası yakalama
                {
                    hataDurumu = true;
                    Console.WriteLine("Lütfen sayı giriniz!!");
                }
                catch (OverflowException)    //veri limiti taşma yakalama
                {
                    hataDurumu = true;
                    Console.WriteLine($"Lütfen {Byte.MinValue} degeri ile {Byte.MaxValue} arası bir değer giriniz!");
                }
                catch (Exception ex)    //Genel hata yakalama
                {
                    hataDurumu = true;
                    Console.WriteLine(ex);
                }

                byte i =0;
                while (i < kenar1)   //üst kenar yıldızları
                {
                    Console.Write("*");
                    i++;
                }
                i = 0;
                Console.WriteLine();
                while (i< (kenar2 -2))    //orta kenar yıldızları
                {
                    int j = 0;
                    Console.Write("*");
                    while (j<(kenar1 - 2))   //iç boşluk yıldızları
                    {
                        Console.Write(" ");
                        j++;
                    }
                    Console.WriteLine("*");
                    i++;
                }
                i = 0;
                while (i < kenar1)   //alt kenar yıldızları
                {
                    Console.Write("*");
                    i++;
                }

            } while (hataDurumu);
            

            */

            #endregion

            #region soru2
            #region 
            /*
              Kullanıcıdan iki adet sayı talep edin.küçük sayıdan büyük sayıyıa kadar olan sayılardan 3'e ve 5'e bölünebilen sayıların toplamını ve ortalamasını alıp ekrana yazdıralım.
            */
            #endregion
            /*
             bool hataDurumu = false;
            int kucukSayi=0, buyukSayi=0;
            do
            {
                //Kucuk sayı için girdi kontrolü
                do
                {
                    hataDurumu = false;
                    Console.Write("Küçük sayiyi giriniz : ");
                    try  //hata vermesi olası bölüm
                    {
                        kucukSayi = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException) //format kontrolü
                    {
                        Console.WriteLine("Lütfen sadece sayi giriniz!");
                        hataDurumu=true;
                    }
                    catch (OverflowException)   //veri kapasite kontrolü
                    {
                        Console.WriteLine($"Lütfen {int.MinValue} ile {int.MaxValue} arası bir deger giriniz!");
                        hataDurumu = true;
                    }
                    catch (Exception ex)    //genel hata yakalama bölümü
                    {
                        hataDurumu=true;
                        Console.WriteLine("Hata!!", ex);
                    }

                } while (hataDurumu);

                //Büyük sayi için girdi kontrolü
                do
                {
                    hataDurumu = false;
                    Console.Write("Büyük sayiyi giriniz : ");
                    try  //Olası hata yeri
                    {
                        buyukSayi = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException) //Format hatası yakalama
                    {
                        Console.WriteLine("Lütfen sadece sayi giriniz!");
                        hataDurumu = true;
                    }
                    catch (OverflowException)   //Veri tipi kapasite aşımı kontorlü 
                    {
                        Console.WriteLine($"Lütfen {int.MinValue} ile {int.MaxValue} arası bir deger giriniz!");
                        hataDurumu = true;
                    }
                    catch (Exception ex)    //Genel hata yakalama
                    {
                        hataDurumu = true;
                        Console.WriteLine("Hata!!", ex);
                    }

                } while (hataDurumu);
                
                //girilen sayıların buyuk-küçük kontrolününü yapılması
                if (kucukSayi > buyukSayi)
                {
                    int gecici = buyukSayi;
                    buyukSayi = kucukSayi;
                    kucukSayi = gecici;
                }
                
                Console.WriteLine($"Kucuk Sayı : {kucukSayi}, buyuk sayi : {buyukSayi}");
                int toplam = 0, sayac=0;
                float ort = 0;

                while (kucukSayi <= buyukSayi)  //3 ve 5 e bölünene sayıların bulunması
                {
                    if (kucukSayi % 3 == 0 & kucukSayi %5 ==0)
                    {
                        Console.WriteLine(kucukSayi);
                        toplam = toplam + kucukSayi;
                        sayac++;
                    }
                    kucukSayi++;
                }
                //ort degerin NaN deger almaması için durum kontrolü
                if (sayac > 0)
                    ort = toplam / (float)sayac;

                Console.WriteLine($"Toplam : {toplam}, Ortalama : {ort}");
                Console.WriteLine($"Toplam : {toplam}, Ortalama : {(float)toplam/sayac}");


            } while (hataDurumu);
            */

            #endregion

            #region soru3
            #region 
            /*
             Kullanıcı 0'a basana kadar girilen tek çift sayıların toplamı ve ortalamasını ekrana yazdıralım. 
             
            */
            #endregion
            /*
            bool hataDurumu = false;
            bool cikisDenetimi = true;
            int geciciSayi = 0,tekToplam=0,ciftToplam=0,sayacTek=0,sayacCift=0;
            do
            {
                hataDurumu = false;
                
               
                do
                {
                    try
                    {
                        Console.Write("Sayi Giriniz: ");
                        geciciSayi = int.Parse(Console.ReadLine());
                        if (geciciSayi == 0)
                        {
                            cikisDenetimi = false;
                            break;
                        }
                            
                    }
                    catch (Exception ex)
                    {
                        hataDurumu = true;
                        Console.WriteLine(ex);
                        
                        ;
                    }

                } while (hataDurumu);
                
                
                
                if (geciciSayi %2 ==0)  //Tek çift sayı kontrolü
                {
                    ciftToplam = ciftToplam + geciciSayi;
                    sayacCift++;
                }
                else
                {
                    tekToplam = tekToplam + geciciSayi;
                    sayacTek++;
                }

            } while (cikisDenetimi);

            Console.WriteLine($"Tek Sayıların toplamı : {tekToplam}, \t Tek sayıların ortalaması : {tekToplam/(float)sayacTek}   \nÇift Sayiların Toplamı : {ciftToplam}, \tÇift Sayıların Ortalaması: {ciftToplam/(Double)sayacCift} ");
           */

            #endregion

            #region soru4
            #region Soru
            /* z karakterinden a karakterine kadar olan harfleri ekrana yazdıralım.*/
            #endregion
            #region Cozum

            /*char i = 'z';
            while (i>='a')
            {
                Console.Write(i+ " ");
                i--;
            }
            */

            #endregion

            #endregion

            /*
            Genel Not: Kullanıcının gireceği tüm değerler kontrol edilecek. Hatalıo bir değer girdiğinde doğru değer girene kadar kullanıcıdan talep edilecek.*/

            Thread.Sleep(5000);



        }
    }
}
