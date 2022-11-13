using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* --Try Catch -- Syntax
             * ------------------
            try
            {
                Hata verebilcek olan komut satırı bu alan içerisine yazılır. Hata veriyorsa catch bloğu içerisine girer, hata vermezse catch bloğu içerisine girmez.
            }
            catch (Exception)
            {   
                Try bloğu içerisinde yakalanılan hata cath bloğunu tetikler. Tektiklenirse bu blok içerisine yazılan kod çalıştırılır. Hata yakalanmazsa catch bloğu çalışmaz.
            }
            finally
            {
                Hata olsa da olmasa da bu blok her şekilde çalışır.
            }
            */
            /*Console.WriteLine("Bir sayi giriniz: ");
            int sayi;
            try
            {
                sayi = int.Parse(Console.ReadLine());
                Console.WriteLine("Girilen sayi : "+ sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();*/

            //Exception Turleri
            //-----------
            //Uygulama içerisinde yakalamış olduğunuz hataları türlere göre ayırabilirsiniz. Bunun için Exception türlerini bilmeniz gerekir. Bir Try-Catch mekanizması içerisinde birden fazla hata türüne göre catch  bloğu yazabilirsiniz.

            //FormatException => Format hatalarını yakalamak için kullanılır;
            //DivideByZeroException => Sıfıra bölme işlemine oluşan hataları yakalar;
            //OverflowException  => Veri tipi boyutunun aşması durumunun aşması durumunda oluşan hataları yakalar;
            //Exception => Tüm hataları yakalar.

            /* Console.WriteLine("Bir sayi giriniz: ");
             int sayi;
             try
             {
                 sayi = int.Parse(Console.ReadLine());
                 sayi /= 0;
                 Console.WriteLine("Girilen sayi : " + sayi);
             }
             catch (FormatException ex)
             {
                 Console.WriteLine("Format Hatası.. " + ex.Message);
             }
             catch (OverflowException ex)
             {
                 Console.WriteLine("Boyut Hatası.. " + ex.Message);
             }
             catch (DivideByZeroException ex)
             {
                 Console.WriteLine("Bölme Hatası.. " + ex.Message);
             }
             catch (Exception ex)
             {
                 Console.WriteLine("Hata Mesajı.. " + ex.Message);
             }
             Console.ReadKey();
             */
            /*kullanıcıdan 2 adet sayi alıp toplama işlemini ekrana yazdıralım. Kullanıcı hatalı bşr giriş yaptığında kullanıcıya hata mesajı bilgisini çıkaralım ve girilen sayıyı 0 (sıfır) olarak kabul edelim.
             */
            
            Console.WriteLine("Lütfen 2 adet sayi girinniz..");
            int sayi1, sayi2;
            Console.WriteLine("1. Sayi : ");
            try
            {
                sayi1 = int.Parse(Console.ReadLine());
                
            }
            catch (Exception ex )
            {
                Console.WriteLine("Hata.." + ex.Message);
                sayi1 = 0;
                //sayi1 = 0;
            }
            
            Console.WriteLine("2. Sayi : ");
            try
            {
                sayi2 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata.." + ex.Message);
                sayi2 = 0;
            }
            Console.WriteLine("Sayiların toplamı : "+(sayi1 + sayi2));
            Console.ReadKey();


        }
    }
}
