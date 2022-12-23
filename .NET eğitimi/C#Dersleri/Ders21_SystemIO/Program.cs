using System;
using System.IO;

namespace Ders21_SystemIO
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //System.IO//

            #region Directory Sınıfı

            //System.IO kütüphanesinin içerisinde bulunan Directory, FileDriveInfo sınıfları ile bilgisayar içerisinde klasör, dosya ve sürücüler ile ilgili işlemleri yapabilir ve bilgilerine ulaşabilirsiniz.

            //Directory Sınıfı
            //--------------------
            //Directory Sınıfını kullanabilmek için sayfa içerisine "usingSystem.IO" kütüphanesinin ekli olması gerekmektedir.

            #endregion

            #region CreatDirectory
            //CreatDirectory (<path>) 
            //---------------------------
            //Yeni bir klasör oluşturmak için kullanılır. Parametre olarak olarak oluşturulacak olan klasörün tam yolu ve klasör adı belirtilir.

            #endregion Region

            #region Exists()
            //Exists(<path>)
            //---------------
            //Belirtilen klasör var mı? yok mu? Sorusunu sormamızı sağlar. Geriye boolean tipinde deger döndürür.

            #endregion

            #region Delete()
            //Delete(<path>)
            //---------------
            //Belirtilen dosyayı siler
            #endregion

            #region GetDirectories()
            //GetDirectories(<path>)
            //------------------
            //Belitilen yol içerisindeki bulunan klasörleri listeler. Geriye string[] tipinde deger dondürür.

            #endregion

            #region GetFiles
            //GetFiles
            //-----------
            //Klasor içerisindeki dosyaları string[] tipinde listeler.
            #endregion

            #region GetDirectoryRoot()
            //GetDirectoryRoot(<path>)
            //-----------------------
            //Belirtilen dizinin ana dizinini(sürücü bilgisi) string tipinde geriye döndürür.

            #endregion

            #region GetLogacialDrivers
            //GetLogacialDrivers
            //-------------
            //Sistem içerisindeki sürücüleri string[] tipinde listeler.

            #endregion

            #region Move()
            //Move(<path>,<newpath>)
            //-------------
            //Belirtilen dizindeki klasörü yeni bir dizine taşımak için kullanılır. bu metofu klasör ismini değiştirmek için de kullanılabilir.


            #endregion


            #region DirectoryInfo
            //DirectoryInfo
            //------------
            //

            #endregion


            //string yol= "C:\\";
            string yol = @"C:\YZL5499\";    //Benim yazdığım yazıda kaçış karakteri bulunmuyor anlamında '@ 'işareti kullanılıyor.
            string klasorAdi = "Deneme";
            string tamYol = yol + @"\" + klasorAdi;


            //Exists()
            /*try
            {
                if (Directory.Exists(tamYol))   //klasör var mı? => bool
                {
                    Console.WriteLine("Belirtilen dizin içerisinde "+klasorAdi+" zaten var.");
                }
                else
                {

                    DirectoryInfo info = Directory.CreateDirectory(tamYol); //Klasör oluştur => DirectoryInfo
                    Console.WriteLine(klasorAdi + " klasör oluşturulmuştur.");
                    Console.WriteLine("Klasör Yolu: " + info.FullName);
                    Console.WriteLine("Oluşturma Tarihi: " + info.CreationTime);
                }
                

            }
            catch (Exception e)
            {
                Console.WriteLine("Hata Mesajı: "+e);
                
            }
            */

            //Delete()
            /*try
            {
                Directory.Delete(tamYol);
                Console.WriteLine(tamYol + " klasörü başarıyla silindi.");
            }
            catch (Exception e )
            {
                Console.WriteLine(" Hata Mesajı: "+e.Message);
            }

            */

            //GetDirectories() & GetFiles()
            /*
            string[] klasorler = Directory.GetDirectories(yol);
            string[] dosyalar = Directory.GetFiles(yol);

            Console.WriteLine("Dizin içerisindeki klaösrler ve dosyalar:\n-------------------- ");
            
            if (klasorler.Length+dosyalar.Length==0)
            {
                Console.WriteLine("Listelenecek öğe bulunamadı.");
            }
            else
            {
                //Klasörleri listeler
                foreach (var klasor in klasorler)
                {
                    Console.WriteLine(klasor);
                }

                //Dosyaları listeler
                foreach (var dosya in dosyalar)
                {
                    Console.WriteLine(dosya);
                }
            }
          */

            //GetDirectoryRoot()
            /*string anadizin = Directory.GetDirectoryRoot(yol);
            Console.WriteLine("Ana Dizin: "+anadizin);
            */

            //
            /*
            DirectoryInfo info = new DirectoryInfo(yol);
            Console.WriteLine(yol+" Dizini hakkında bilgiler : ");
            Console.WriteLine("-------------");
            Console.WriteLine("Tam yol: " +info.FullName);
            Console.WriteLine("Üst dizin: "+info.Parent);
            Console.WriteLine("Klasör adı: "+info.Name);
            Console.WriteLine("içinde bulunan klasörler: ");
            DirectoryInfo[] klasorler = info.GetDirectories();
            Console.WriteLine($"Toplam {klasorler.Length} adet dosya vardır.");
            foreach (var VARIABLE in klasorler)
            {
                Console.WriteLine("-"+VARIABLE.Name);
            }
            //info.Refresh(); //Mevcut klasörü yeniler.
            //info.Delete();  //Mevcut klasörü siler
            Console.WriteLine("Oluşturulma tarihi: "+info.CreationTime);
            Console.WriteLine("Son Değiştirme tarihi: "+info.LastWriteTime);
            */


            //
            /* string[] suruculer = Directory.GetLogicalDrives();
             Console.WriteLine("Sistem içerisinde tanımlı olan sürücüler: ");
             foreach (var VARIABLE in suruculer)
             {
                 Console.WriteLine(VARIABLE);

             }
            */

            //Move()
            /* string kaynakKlasor = yol + @"\Deneme2";
             string tasinacakYol = yol + @"\1-SQL\Deneme";   //ismini değiştirirken taşıma
             Directory.Move(kaynakKlasor,tasinacakYol);
            */



            //---------------------------//


            #region -File Sınıfı

            //File Sınıfı
            //------------------
            //System.IO kütüphanesinin içerisinde bulunan dosyalar ile ilgili işlemleri yapmak için kulklanılan bir sınıftır. File sınıfı kullanabilmeniz için "using System.IO;" ibaresini eklemeniz gerekmektedir.
            //Dile sınıfı ile yeni bir dosya oluşturabilir, silebiliri düzenleyebilir yda bilgilerine erişebilirsiniz.

            #endregion

            #region Creat()
            //Creat(<path>)
            //---------------
            //Yeni bir dosya oluşturmak için kullanılır. içerisine dizin yolu ile beraber oluşturulacak olan dosya adı ve uzantısı yazılır. Geriye FileStream tipnde deger döndürür.Dosya oluşturma işlemi tamamlandıktan sonra FileStream tipinde nesne açık kalır. Nesneyi kapatmak için Close() metodu kullanılır. Kapatma işlemi ile ilgili dosya içerisinde daha sonra işlem yapılak istendiğinde açık kalmaması için kullanılır.
            #endregion

            #region Exists()
            //Exists(<path>)
            //---------------
            //Belirtilen dizindeki belirtilen dosya var mı yok mu ? sorusunu sorar. Geriye boolean tipinde değer döndürür.

            #endregion

            #region Delete()
            //Delete(<path>)
            //--------------
            //Belirtilen dosyayı siler.
            #endregion

            #region FileInfo
            //Belirtilen dosya ile ilgili bilgilere erişmenizi sağlar.

            #endregion

            //Creat() & Exists()
            string dosyaAdi = "test.txt";
            string tamDosyaYolu = yol + dosyaAdi;
            /* try
             {
                 if (File.Exists(tamDosyaYolu))
                 {
                     Console.WriteLine(dosyaAdi + " Zaten böyle bir dosya var.");
                     Console.Write("Üzerine yazmak ister misiniz?(e)");
                     ConsoleKeyInfo key = Console.ReadKey();
                     if (key.Key == ConsoleKey.E)
                     {
                         Console.WriteLine("\nDosya başarıyla yeniden oluşturuldu.");
                     }
                     else
                     {
                         Console.WriteLine("Dosya oluşturulmadı.");
                     }
                 }
                 else
                 {
                     FileStream fs = File.Create(tamDosyaYolu);
                     fs.Close();
                     Console.WriteLine(dosyaAdi + " dosyası oluşturuldu.");
                 }

             }
             catch (Exception e)
             {
                 Console.WriteLine("Hata mesajı: " + e);

             }
            */

            //Delete()
            /*try
            {
                if (File.Exists(tamDosyaYolu))
                {
                    File.Delete(tamDosyaYolu);
                    Console.WriteLine(dosyaAdi + " dosyası başarıyla silinmiştir.");
                 }
                else
                {
                    Console.WriteLine(dosyaAdi+" bulunamadı.");
                }

             }
            catch (Exception e)
            {
                Console.WriteLine("Hata mesajı:\t"+e.Message);
            }

             */

            //FileInfo()
            /*try
            {
                FileInfo fi = new FileInfo(tamDosyaYolu);
                Console.WriteLine("Dosya Adi: " + fi.Name);
                Console.WriteLine("Dosya Tam yolu: " + fi.FullName);
                Console.WriteLine("Bulunduğu Klasör: " + fi.DirectoryName);
                Console.WriteLine("Dosya Boyutu: " + fi.Length);
                Console.WriteLine("Dosya Uzantısı: " + fi.Extension);
                Console.WriteLine("Oluşturma tarihi: " + fi.CreationTime);
                Console.WriteLine("Değiştirme tarihi: " + fi.LastWriteTime);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata Mesajı: "+e);
            }
            */




            #region Dosya işlemleri
            #region Dosya İçerisinde Yazma
            //Dosya içerisine yazı yazma
            //----------------------
            //I. Yol
            //Bir txt dosyası içeriisne yazı yazma işlemini FileStream sınıfı içerisinde Writer() fonksiyonu ile yapabilirsiniz. Bu fonksiyon  içerisine byte[] tipinde bir deger almaktadır. Uygulama içerisinde oluşturduğumuz bu tipdeki değeri FileStream...
            #endregion


            #region Dosya içerisinden metin okuma
            //Dosya içerisinden metin okuma
            //-----------------------------------
            //StreamWriter nesnesi ile belirtilen dosya içerisindeki metinleri okuyabilirsiniz. Okuma işlemini ReadLine() ile yapabilirsiniz.

            StreamReader sr = new StreamReader(tamDosyaYolu);
            //string metin = sr.ReadLine();   //Tek bir satırı okur.
            //string metin = sr.ReadToEnd();  //Bütün metinleri alır.

            /* while (!sr.EndOfStream) //Son satır mı? Son satır değilse devam..
             {
                 string satir = sr.ReadLine();
                 Console.WriteLine(satir);
             }
             */

            //File.ReadAllLine(<path>) metodu ile metin dosya yolu içerisindeki tüm satırları okuyabilirsiniz. Geriye string [] tipinde deger döndürür.
            /*string[] satirlar = File.ReadAllLines(tamDosyaYolu);
            foreach (var VARIABLE in satirlar)
            {
                Console.WriteLine(VARIABLE);
            }
            */

            #endregion

            #region Dosya İçerisine Metin Ekleme
            //File.AppendText() fonksiyonu ile ilgili dosya içerisine metin ekleyebilirisiniz. Geriye FileStream nesnesi döndürür. FilseStream  nesnesi içerisinde bulunan WriteLine() ile metin ekleme işlemini yapabilirsiniz. FileStream ile ilgili işlemleriniz bittiğinde Close() ile kapatmayı unutmayınız.

            //StreamWriter sw = File.AppendText(tamDosyaYolu);
            //sw.WriteLine("Deneme");
            //sw.Close();
            #endregion
            
            #endregion
            Console.ReadKey();
        }
    }
}
