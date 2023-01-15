using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_Interface.Model
{
    internal interface IOgrenci:IKisi
    {
        int N1 { get; set; }
        int N2 { get; set; }
        int F { get; set; }
        double Ortalama { get;}
    }
}
