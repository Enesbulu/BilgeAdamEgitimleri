using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SayiTahminOyunu_6HaftaOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sayı Tahmin Oyunu
         /* ---------------------------
            Program ilk açıldığında 1 - 100 arasında rastgele bir sayı üretsin ve 250 puanı olsun.
            Sayı tahmin etmeye başlamadan önce 50 puan bakiyeden düşsün. (Yeni oyuna başladı.)
            Sayıyı tahmin etmesi için toplam 5 hakkı bulunsun.
            Kullanıcı her tahminde bulunduğunda kullanıcıyı yönlendirin.
            5 hak dahilinde sayıyı tahmin edemezse puan kazanamasın.
            Tahmin ederse Ekrana kaç seferde tahmin ettiğini yazsın ve 100 puan kazansın.

            Oyun bittiğinde kullanıcıya yeni oyuna başlamak istedmisiniz? diye sorsun.Evet derse oyuna devam etsin.
            Demezse uygulama sonlansın.
         */
            #endregion
            bool oyunDurumu=false;
            Random rndSayi = new Random();
            int tuttugumSayi = 0;
            short puan = 250;
            do
            {
                tuttugumSayi = (rndSayi.Next(1, 100));
                puan-=50;
                Console.WriteLine("Puan -50");
                Console.Write("Oyunumuza Hoşgeldiniz...\nBen bir sayı tuttum 5 tahmin hakkın var, hadi  tahmin et.\nTahminin nedir? : ");
                byte tahminiSayi=0;
                for (int i = 0; i < 5; i++)
                {   
                    
                    try
                    {
                         tahminiSayi= byte.Parse(Console.ReadLine());
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Lütfen 1 ila 100 arası bir sayi giriniz.");
                        i--; //Hatalı deger girildiğinde verilen 5 hakdan düşmemesi için 
                    }
                    catch (Exception e)
                    {
                        i--;
                        Console.WriteLine("Lütfen sadece 1 ila 100 arası sayı giriniz!!",e);
                    }


                    if (tahminiSayi < tuttugumSayi)
                    {
                        Console.WriteLine($"Kalan hakkın {4 - i}");
                        Console.Write("\nBiraz daha yukarı tahmin et: ");
                    }
                    else if (tahminiSayi > tuttugumSayi)
                    {
                        Console.WriteLine($"Kalan hakkın {4 - i}");
                        Console.Write("\nBiraz daha aşagı tuttum : ");
                    }
                    else if (tahminiSayi == tuttugumSayi)
                    {
                        Console.WriteLine("_____ Tebrikler Doğru Tahmin !!!!! ___");
                        puan += 100;
                        Console.WriteLine($"{i+1} denemede tahmin ettin.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı bir durum oldu tekrar deniyelim.");
                    }
                    
                }

                Console.WriteLine($"Tuttuğum sayı {tuttugumSayi}'dı.");
                Console.WriteLine($"\nŞuanda Puanın : {puan}");

                //yeni oyuna başlamak durumu sorulması
                do
                {
                    Console.Write("Yeni Oyuna Başlamak İster misiniz? (e/h)");
                    char tercihGirilmesi = char.Parse(Console.ReadLine());
                    //oyunDurumu = ('e' == char.Parse(Console.ReadLine())) ? true : false;

                    if ('e' == tercihGirilmesi)
                    {
                        oyunDurumu= true;
                        break;
                    }
                    else if ('h' == tercihGirilmesi)
                    {
                        oyunDurumu = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yatınız lütfen uygun tercihi giriniz!");
                    }

                } while (true);
                
            } while (oyunDurumu);
            Console.WriteLine("Sonra Görüşmek üzere.. :)");
            Thread.Sleep(2000);

        }
    }
}
