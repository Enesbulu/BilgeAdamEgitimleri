using System;

namespace Ders21_ParamsMethods
{
    internal class Program
    {
        #region Params Methods
        // C# Programlama dili içerisinde bazı durumlarda tanımlamış olduğunuz fonksiyon içerisine kaç adet parametre gönderilmesi gerektiği belli değildir. Böyle durumda "Params" anahtar sözcüğü kullanarak belirtilen türdeki degeri sayı kısıtlaması olmaksızın parametre olarak  gönderebilirsinizç
        //Gönderile bu degerler belirtilen türde bir array  oluşturup otomatik olarak içerisine degerlerin aktarılmını yapar ve bu array içerisinde degerleri okuyup işlem yapabilirsiniz.
        //params anahtar kelimesi tanımlanırken sayılardan öncesinde yazılır.
        #endregion

        /// <summary>
        /// 4 Adet Tam sayının toplamını ekrana yazdırır.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <param name="s4"></param>
        static void Topla(int s1, int s2, int s3, int s4)
        {
            int toplam = s1 + s2 + s3 + s4;
            Console.WriteLine("Sayıların toplamı: " + toplam);
        }

        /// <summary>
        /// n Sayıda gönderilen sayıların toplamını ekrana yazdırır.
        /// </summary>
        /// <param name="sayilar"></param>
        static void Topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
        }

        static void Main(string[] args)
        {
            Topla(45, 74, 85, 65);
            Topla(3, 5);
            Console.ReadKey();
        }
    }
}
