using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_GenericType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            o.Ad = "Ali";
            o.Soyad = "Veli";
            o.N1 = 46;
            //o1.N2 = 46.5; //Property içerisinde int tanımlamadığımız için double sayı girişi yapılamaz.
            o.N2 = 56;
            o.F = 65;


            Ogrenci2<double> o2= new Ogrenci2<double>();
            o2.Ad = "Ayşe";
            o2.Soyad = "Gelir";
            o2.N1 = 35.5;
            o2.N2 = 56.9;
            o2.F = 60;

        }
    }
}
