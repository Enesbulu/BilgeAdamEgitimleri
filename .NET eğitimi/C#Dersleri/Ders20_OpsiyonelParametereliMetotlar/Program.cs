using System;
using System.Threading;

namespace Ders20_OpsiyonelParametereliMetotlar
{
    internal class Program
    {
        #region Opsiyonel Parametreli Metotlar
        //Programlama Dilleri içerisinde bazı durumlrda fonksiyonları daha kullanışlı hale getirmek için içerisinde tanımlanan parametrelere default olarak deşer ataması  yapabilirsiniz.
        //Default  olarak değer ataması yapılan fonksiyonlarda, ilgili parametrede deger gönderme zorunluluğunuz bulunmamaktadır.
        //Bu sayede duruma bağlı  olarak kullanım kolaylığı sağlamaktadır.
        //Parametre içeriisnde default  deger tanımlama işlemini, parametre tanımlaması yaparken = operatörünü kullanarak yapabilirsiniz.
        #endregion
        static int GetInt(string metin, int min = 1, int max = 1000)
        {
            int sayi = 0;
            bool hata;
            do
            {
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;

                    }
                    else
                    {
                        hata = true;
                        Console.WriteLine($"Lütfen {min} ile {max} arası bir sayı degeri giriniz. \n");
                    }
                }
                catch
                {
                    Console.WriteLine("Lütfen geçerli bir deger giriniz.");
                    hata = true;
                }

            } while (hata);
            return sayi;
        }



        static void Main(string[] args)
        {
            int deger1 = GetInt("Lütfen bir sayi giriniz:");
            int deger2 = GetInt("Lütfen bir sayı daha giriniz", 5, 6000);

            Thread.Sleep(2500);

        }
    }
}

