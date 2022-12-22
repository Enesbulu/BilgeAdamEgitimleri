using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Odev9_CommandLine_Uygulamasi
{

    internal static class Program
    {
        /*Yönergeler
        -- Kendi CommandLine uygulamamızı yazacağız.
        -- Uygulama ilk açıldığında sistem içerisinde tanımlı olan ilk local sürücü içerisinde girecek.

        -- Uygulama içerisinde kullanılacak komut satırları:
        -- enter <klasorAdi> => ilgili klasör içerisine girecek.
        -- back => bir üst dizine dönecek.
        -- list => ilgili dizin içerisindeki klasör ve dosyalar listelenecek.
        -- create folder <klasorAdi> => ilgili dizinde klasör oluşturulacak.
        -- delete folder <klasorAdi> => ilgili dizin içerisindeki klasor silinecek.
        -- info folder <klasorAdi> => ilgili dizin içerisindeki klasörün bilgileri listelenecek.
        -- create file <dosyaAdi> => ilgili dizin içerisinde dosya oluşacak.
        -- delete file <dosyaAdi> => ilgili dizin içerisindeki belirtilen dosya silinecek.
        -- info file<dosyaAdi> => ilgili dizin içerisindeki dosyanın bilgileri listelenecek.
        -- help => uygulama içerisinde kullanılabilecek komut satırlarının listesi görüntülenecek.
        -- exit => uygulama kapanacak.*/

        #region Sık Kullanılan fonksiyonlar

        /// <summary>
        /// Dosyaların ismini girilen terminal ekranından doğrru bir şekilde almak için kullanılır. String döndürür.
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns></returns>
        public static string DosyaAdiDuzenleme(this string[] dizi)
        {
            string dosyaAdi = String.Empty;
            for (int i = 2; i < dizi.Length; i++)
            {
                dosyaAdi += dizi[i] + ' ';
            }
            return dosyaAdi;
        }

        /// <summary>
        /// Klasör ismini girilen terminal ekranından doğru bir şekilde almak için kullanılır. String döndürür.
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns></returns>
        public static string KlasorAdiDuzenleme(this string[] dizi)
        {
            string klasorAdi = String.Empty;
            for (int i = 2; i < dizi.Length; i++)
            {
                klasorAdi += dizi[i] + ' ';
            }
            return klasorAdi;
        }

        /// <summary>
        /// SYntax ERror hatalarında ekrana uyarı yazdırır. Deger döndürmez.
        /// </summary>
        public static void YazimHatasi()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------Syntax Error!!------");
            Console.ResetColor();
        }

        #endregion

        static void Main(string[] args)
        {
            string kokDizin = BasicDriverCommand(); //Kok dizinleri almak işlemi. 
            bool durum = true;  //Konsolu kapatma isteği için durum değişkeni oluşturuldu
            string result = string.Empty;
            string[] komut; //Girilecek default komutları almak için oluşturulmuş değişken.
            string dizin = kokDizin; // Varsayılan olarak oluşturulmuş dizini korumak için oluşturulmuş değişken dizin.
            dizin = @"D:\";
            kokDizin = dizin;
            do
            {
                string adi = String.Empty;
                //Console.Write(kokDizin);
                Console.Write(dizin);

                result = Console.ReadLine();    //Konsoldan girilen bütün yazıyı alma.
                komut = result.Split(' ');  //yazıdan ilk komutu ayıklama.

                switch (komut[0])
                {
                    case "enter":
                        for (int i = 1; i < komut.Length; i++)
                        {
                            adi += komut[i] + " ";
                        }
                        dizin = EnterCommand(dizin, adi.Trim());
                        break;
                    case "back":
                        dizin = BackCommand(dizin, kokDizin);
                        break;
                    case "list":
                        ListCommand(dizin); //Tamamlandı!
                        break;
                    case "creat":   //Tamamlandı!
                        switch (komut[1])
                        {
                            case "file":    //erişim reddedildi hatası var!!!! ---> Sebebi disk koruması var!!!
                                adi = DosyaAdiDuzenleme(komut);
                                CreatFileCommand(dizin, adi);
                                break;
                            case "folder":
                                adi = KlasorAdiDuzenleme(komut);
                                CreatFolderCommand(dizin, adi);
                                break;
                            default:
                                YazimHatasi();
                                break;
                        }
                        break;
                    case "delete":  //Tamamlandı!
                        switch (komut[1])
                        {
                            case "file":
                                adi = DosyaAdiDuzenleme(komut); //erişim reddedildi hatası var!!!!--->Sebebi disk koruması var!!!
                                DeleteFileCommand(dizin, adi);
                                break;
                            case "folder":
                                adi = KlasorAdiDuzenleme(komut);
                                DeleteFolderCommand(dizin, adi);
                                break;
                            default:
                                YazimHatasi();
                                break;
                        }
                        break;
                    case "info":    //Tamamlandı!
                        switch (komut[1])
                        {
                            case "file":
                                InfoFileCommand(dizin, adi);
                                break;
                            case "folder":  //Komut tam çalışmıyor sonra geri dön bak!
                                InfoFolderCommand(dizin, adi);
                                break;
                        }
                        break;
                    case "help":    //Tamamlandı!
                        HelpCommand();
                        break;
                    case "exit":    //Zaten Tamam!
                        durum = ExitCommand(durum);
                        break;
                    case "cls": //Ekstra olarak tamamlandı!
                        Console.Clear();
                        break;
                    default:
                        YazimHatasi();  //Burası da tamam!
                        break;
                }
            } while (durum);

            Console.WriteLine("Konsol kapatılıyor.");
            Thread.Sleep(950);
        }



        #region Commands
        /// <summary>
        /// Temel sürücü yolunu string olarak geri döndürür.
        /// </summary>
        /// <returns></returns>
        public static string BasicDriverCommand()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string yol = allDrives[0].Name;
            //Console.Write(dizin);
            return yol;
        }

        public static string EnterCommand(string dizin, string klasorAdi)
        {
            string yeniDizin = string.Empty;
            string tamYol = dizin + klasorAdi;
            try
            {
                if (Directory.Exists(tamYol))
                {
                    Console.WriteLine("enter command");
                    yeniDizin = dizin + klasorAdi + '\\';
                    dizin = yeniDizin;
                }
                else
                {
                    Console.WriteLine("Dosya Bulunamadı!");
                    return dizin;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata:" + e.Message);
            }
            return dizin;
        }

        /// <summary>
        /// Bir üst dizine döndürür. Geriye string değer olarak dizin bilgisini döndürür.
        /// </summary>
        /// <param name="dizin"></param>
        /// <param name="kokDizin"></param>
        /// <returns></returns>
        public static string BackCommand(string dizin, string kokDizin)
        {
            string yeniDizin = string.Empty;
            try
            {
                if (!(dizin == kokDizin))
                {
                    string[] temp = dizin.Split('\\');
                    for (int i = 0; i < temp.Length - 2; i++)
                    {
                        yeniDizin += temp[i] + '\\';
                    }
                }
                else
                {
                    yeniDizin = dizin;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata:" + e.Message);
            }
            return yeniDizin;
        }

        /// <summary>
        /// Dizin içerisindeki dosya ve klasörleri listeler. Geriye değer döndürmez.
        /// </summary>
        /// <param name="dizin"></param>
        public static void ListCommand(string dizin)
        {
            List<string> tempList = new List<string>();
            try
            {
                string[] klasorler = Directory.GetDirectories(dizin);
                string[] dosyalar = Directory.GetFiles(dizin);

                if (klasorler.Length + dosyalar.Length == 0)
                {
                    Console.WriteLine("Listelenecek eleman bulunamadı!");
                }
                else
                {
                    Console.WriteLine("\nFolders:");
                    foreach (var VARIABLE in klasorler)
                    {
                        //string[] temp = VARIABLE.Split('\\');
                        //Console.WriteLine(temp[-1]);
                        Console.WriteLine(VARIABLE);
                    }

                    Console.WriteLine("\nFiles:");
                    foreach (var VARIABLE in dosyalar)
                    {
                        //    string[] temp2 = VARIABLE.Split('\\');
                        //    Console.WriteLine(temp2[temp2.Length-1]);
                        Console.WriteLine(VARIABLE);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata:" + e.Message);
            }

        }

        /// <summary>
        /// Klasör oluşturma metodu. Deger döndürmez.
        /// </summary>
        /// <param name="dizin"></param>
        /// <param name="klasorAdi"></param>    
        public static void CreatFolderCommand(string dizin, string klasorAdi)
        {
            try
            {
                Directory.CreateDirectory(dizin + '\\' + klasorAdi);
                Console.WriteLine("klasör oluşturuldu!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message);
            }

        }

        /// <summary>
        /// Klasör silme fonksiyonu. Deger Döndürmez.
        /// </summary>
        /// <param name="dizin"></param>
        /// <param name="klasorAdi"></param>
        public static void DeleteFolderCommand(string dizin, string klasorAdi)
        {
            string tamYol = dizin + klasorAdi;
            try
            {
                if (Directory.Exists(dizin + klasorAdi))
                {
                    Directory.Delete(dizin + klasorAdi);
                    Console.WriteLine("Klasör silindi!");
                }
                else
                {
                    Console.WriteLine($"{klasorAdi} adında bir klasör bulunamadı.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message);
            }

        }
        public static void InfoFolderCommand(string dizin, string klasorAdi)
        {
            dizin = @"D:\";
            string tamYol = dizin + klasorAdi;
            Console.WriteLine(tamYol);
            try
            {
                if (Directory.Exists((dizin + klasorAdi)))
                {
                    DirectoryInfo klasorBilgi = new DirectoryInfo(dizin + klasorAdi);
                    Console.WriteLine(tamYol + $":\r\nKlasör oluşturulma Tarihi: {klasorBilgi.CreationTime}" + $"\n\rTam Yol : {klasorBilgi.FullName}" + $"\n\rÜst dizin: {klasorBilgi.Parent}");
                }
                else
                {
                    Console.WriteLine($"{klasorAdi} klasörü bulunamadı!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("!Hata: " + e.Message);
            }

        }

        /// <summary>
        /// Mevcut dizin içerisinde uzantıya göre dosya oluşturur.Deger döndürmez.
        /// </summary>
        /// <param name="yol"></param>
        /// <param name="dosyaAdi"></param>
        public static void CreatFileCommand(string yol, string dosyaAdi)
        {
            //yol = @"D:\"; //Disk korumam olduğu için kod ile dosya oluşturma engeli var.!!
            try
            {
                FileStream dosya = File.Create(yol + dosyaAdi);
                dosya.Close();
                Console.WriteLine("Dosya oluşturuldu.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message);
            }
        }

        /// <summary>
        /// Dizin içerisinde belirtilen dosyayı siler. Geriye parametre göndermez.
        /// </summary>
        /// <param name="dizin"></param>
        /// <param name="dosyaAdi"></param>
        public static void DeleteFileCommand(string dizin, string dosyaAdi)
        {
            //dizin = @"D:\";   //Disk koruası olduğu için silme işlemi yetkisiz işleme düşüyor.!!
            try
            {
                if (File.Exists(dizin + dosyaAdi))
                {
                    File.Delete(dizin + dosyaAdi);
                    Console.WriteLine($"{dosyaAdi} dosyası başarıyla silindi.");
                }
                else
                {
                    Console.WriteLine($"{dosyaAdi} bulunamadı!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message);
            }

        }

        /// <summary>
        /// Dizindeki belirtilen dosyanın bilgilerini yazdırır. GEriye deger döndürmez. Disk korumasında erişim yetkisi hatası alınır.
        /// </summary>
        /// <param name="dizin"></param>
        /// <param name="dosyaAdi"></param>
        public static void InfoFileCommand(string dizin, string dosyaAdi)
        {
            //dizin = @"D:\";
            //dosyaAdi = "dene.txt";
            try
            {
                FileInfo dosyaBilgileri = new FileInfo(dizin + dosyaAdi);
                Console.WriteLine($"\n\rDosya Adi: {dosyaBilgileri.Name}" +
                                  $"\r\nDosya boyutu: {dosyaBilgileri.Length}" +
                                  $"\n\rDosya oluşturama tarihi: {dosyaBilgileri.CreationTime}" +
                                  $"\n\rDosya Uzantısı: {dosyaBilgileri.Extension}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message); ;
            }
        }

        /// <summary>
        /// Komutları ve kullanımlarını gösterir. Değer döndürmez.
        /// </summary>
        public static void HelpCommand()
        {
            Console.WriteLine("\r-- enter <klasorAdi> => ilgili klasör içerisine girecek." +
                              "\r\n-- back => bir üst dizine dönecek." +
                              "\r\n-- list => ilgili dizin içerisindeki klasör ve dosyalar listelenecek." +
                              "\r\n-- create folder <klasorAdi> => ilgili dizinde klasör oluşturulacak." +
                              "\r\n-- delete folder <klasorAdi> => ilgili dizin içerisindeki klasor silinecek." +
                              "\r\n-- info folder <klasorAdi> => ilgili dizin içerisindeki klasörün bilgileri listelenecek." +
                              "\r\n-- create file <dosyaAdi> => ilgili dizin içerisinde dosya oluşacak." +
                              "\r\n-- delete file <dosyaAdi> => ilgili dizin içerisindeki belirtilen dosya silinecek." +
                              "\r\n-- info file<dosyaAdi> => ilgili dizin içerisindeki dosyanın bilgileri listelenecek." +
                              "\r\n-- help => uygulama içerisinde kullanılabilecek komut satırlarının listesi görüntülenecek." +
                              "\r\n-- exit => uygulama kapanacak" +
                              "\r\n--cls => Konsolu temizler.");

        }

        /// <summary>
        /// Çıkış işlemi için parametre düzenler. Biliyorum anlamsız ama olsun dursun şimdilik.
        /// </summary>
        /// <param name="durum"></param>
        /// <returns></returns>
        public static bool ExitCommand(this bool durum)
        {
            durum = false;
            return durum;
        }

        #endregion
    }
}
