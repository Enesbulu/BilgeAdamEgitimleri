using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders20_RecurciveFunctions
{
    internal class Program
    {
        #region Recursive Funcions (Özyinelemeli Fonksiyonlar)
        //Özyinelemeli fonksiyonlar kendi kendini çağıran fonksiyonlardır. Bu fonksiyonlar çalışırken tekrar tekrar kendilerini çağırırlar ve tab ki fonksiyon içerisindeki komutla da her seferinde çalıırlar.
        //Kendi kendine çağıran bir fonksiyon yapısı olduğundan dolayı, çalışma yapıları döngü mekanizmalarına benzemektedir.
        //Belirli bir koşulu yerinegetirene kadar sürekli olarak çalışır.

        //Syntax
        //--------------
        //<erisimTuru> <donusTipi> <metotAdi> (<parametre|ler>){
        //    komut satırları
        //      <metotAdi>(<parametre|ler>);
        //    komut satırları
        //}

        //Recurcive Fonksiyonunun Avantajları
        //-------------------------------
        //-Recursive fonksiyonlar ile çok daha az kod ile işlevi yüksek kodlar yazabilirsiniz.
        //-Yazılan kodlar daha okunabilir ve anlaşılabilir olur.

        //Recursive Fonksiyonun Dezavantajları
        //------------------
        //-Bazı durumlarda çok yavaş çalışır.
        //-Ufak bir sorgu hatasında sonsuz döngüye girme durumu söz konusudur.
        //-Yine bazı durumlarda bellek sorunu ile karşılaşılabilir.

        #endregion

        #region Ornek1
        //1'den 5'e kadar olan sayıların toplamını alan bir fonksiyon yazalım.
        static int Toplam(int baslangic, int bitis)
        {
            int sonuc = 0;
            for (int i = baslangic; i <= bitis; i++)
            {
                sonuc += i;
            }
            return sonuc;
        }


        public static int Topla_Recursive(int baslangic, int bitis, int toplam = 0)
        {
            if (baslangic > bitis)
            {
                return toplam;

            }

            toplam += baslangic;
            return Topla_Recursive(baslangic + 1, bitis, toplam);

        }


        #endregion

        #region Faktörriyel Hesaplama
        static int Faktoriyel(int sayi)
        {
            int fakt = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fakt *= i;
            }
            return fakt;
        }

        static int Faktoriyel_Recursive(int sayi)
        {
            if (sayi ==0)
            {
                return 1;
            }
            else
            {
                return sayi * Faktoriyel_Recursive(sayi - 1);
            }
        }

        #endregion

        static void Main(string[] args)
        {
            /*int deger = Toplam(1, 5);
            int deger2 = Topla_Recursive(1, 5);
            Console.WriteLine("Sayıların toplamı:" + deger);
            Console.WriteLine("Sayıların toplamı:" + deger2);
            */

            int fDeger1 = Faktoriyel(12);
            int fDeger2 = Faktoriyel_Recursive(12);
            Console.WriteLine(fDeger1);
            Console.WriteLine(fDeger2);



            Console.ReadKey();
        }
    }
}
