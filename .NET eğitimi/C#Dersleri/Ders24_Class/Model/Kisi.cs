using System;

namespace Ders24_Class.Model
{
    internal class Kisi
    {
        #region Class
        /*Class
        *
        */


        #endregion

        public string Ad;
        public string Soyad;
        public DateTime DogumTarihi;
        public string Sehir;
        public string Adres;

        public void Yazdır()
        {
            Console.WriteLine("Kişi Bİlgileri");
            Console.WriteLine("------------------");
            Console.WriteLine("Ad: "+Ad);
            Console.WriteLine("Soyad: "+Soyad);
            Console.WriteLine("Doğum Tarihi: "+DogumTarihi.ToShortDateString() );
            Console.WriteLine("Şehir: "+Sehir);
            Console.WriteLine("Adres: " +Adres);
            Console.WriteLine();
        }

    }
}
