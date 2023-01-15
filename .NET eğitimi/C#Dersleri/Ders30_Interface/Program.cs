using Ders30_Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi k = new Kisi();
            k.Name = "Ali";
            k.LastName = "durmaz";
            k.Yazdir();


            Ogrenci o = new Ogrenci();
            o.Name = "Hasan";
            o.LastName = "Kaçar";
            o.N1 = 45;
            o.N2 = 56;
            o.F = 65;
            o.Yazdir();
            Console.ReadLine();
        }
    }
}
