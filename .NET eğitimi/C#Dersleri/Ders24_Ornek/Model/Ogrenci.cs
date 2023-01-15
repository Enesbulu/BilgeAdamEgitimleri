using System;


namespace Ders24_Ornek
{
    internal class Ogrenci
    {
        public string ad;
        public string soyad;
        public byte not1;
        public byte not2;
        public byte fNot;
        

        public void Yazdir()
        {
            Console.WriteLine("\nÖğrenci Bilgileri");
            Console.Write("\nAdi: "+ad  );
            Console.Write("\nSoyad: "+soyad);
            Console.Write("\nNot1: " +not1);
            Console.Write("\nNot2: " + not2);
            Console.Write("\nFinal Not: " + fNot);
        }
    }
}
