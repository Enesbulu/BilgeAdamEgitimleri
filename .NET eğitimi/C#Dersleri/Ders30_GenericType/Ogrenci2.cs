using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_GenericType
{
    internal class Ogrenci2<NotType>    // <...> ile Belirtilen veri tipinde kulanım sağlanabilir.
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public NotType N1 { get; set; }         //Program.cs içerisinde kullanırken belirttiğimiz veri tipini referans olarak alır.
        public NotType N2 { get; set; }
        public NotType F { get; set; }
    }
}
