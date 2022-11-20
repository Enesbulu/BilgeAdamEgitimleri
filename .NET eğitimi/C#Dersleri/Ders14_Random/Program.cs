using System;
using System.Threading;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ders14_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Random
            //Random(Rastgele)
            //-------------------------------------
            //Rastgele sayı üretme işlemi Random sınıfı kullanarak içerisinde bulunan metotlar yardımı ile oluşturulurlar.
            //Syntax
            //Random <degiskenAdi> = new Random();  //Bu yazım kuralı ile Random yazım kuralı ile Random sayı üretmek için gerekli olan nesneyi program içerisinde tanımlamış oluruz.
            /*  Random rnd = new Random();

              //Rastgele tam sayı oluşturma.
              int rsayi = rnd.Next(); // Next() metodu 0 ile 2.147.483.647 sayı aralığında bir tam sayı üretmek için kullanılır. Geriye int türünde deger döndürür.

              //Belirtilen sayıya kadar random deger oluşturma.
              int rsayi2 = rnd.Next(50);  //0 ile 50 sayısına kadar (50 hariç) olan degerler arasında rastgele bir tam sayı üretir. Geriye int deger döndürür.

              //Belirtilen aralıkta tam sayı oluşturma.
              int rsayi3 = rnd.Next(50,100);  //50 ile 100 arasında (100 hariç) rastgele bir tam sayı üretir.

              //Ondalıklı sayi oluşturma
              double rsayı4 = rnd.NextDouble();   //0.0 ile 1.0 (1.0 hariç) arasında rastgele olarak ondalık sayı üretir. Geriye double türünde bir deger döndürür.

              Console.Clear();    //Consol ekranında yazılan metinleri siler.

              */
            #endregion

            #region Ornek1

            //5 adet rastgele sayı üretip ekrana yazdıralım.
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                //1 ila 10 arasında rastgele sayı elde etme
                Console.WriteLine(random.Next(1,11));

            }

            Console.Clear();
            #endregion

            #region Ornek2

            //A karakterinden Z karakteri arasında rastgele bir harf oluşturalım.

            /*int rsayi5 = random.Next(65,91);
            char karakter = Convert.ToChar(rsayi5);
            Console.WriteLine("Oluşturulan rastgele karakter: "+ karakter);
            int baslangic = Convert.ToInt32('A');
            int bitis = Convert.ToInt32('Z');
            int sayi6 = random.Next(baslangic,bitis+1);
            Console.WriteLine("Oluşturulan rastgele karakter: " + sayi6);
            Console.WriteLine("Oluşturulan rastgele karakter: " +(Convert.ToString(random.Next(baslangic, bitis + 1))));
            Console.WriteLine("Oluşturulan rastgele karakter: " + (Convert.ToString(sayi6)));
            */
            #endregion




            Thread.Sleep(3000);
        }
    }
}
