using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_Interface.Model
{
    internal class Ogrenci : IOgrenci
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int F { get; set ; }
        public string FullName => Name+" "+LastName;
        public double Ortalama => (N1+N2+F)/3.0;

        public string Name { get; set; }
        public string LastName { get; set; }

        

        public void Yazdir()
        {
            //Console.WriteLine("Ad Soyad: "+FullName);
            Console.WriteLine($"Notlar {N1},{N2},{F}");
            Console.WriteLine("Ortalama: " +Ortalama);
            Console.WriteLine();
        }
    }
}
