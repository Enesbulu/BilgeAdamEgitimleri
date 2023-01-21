using Ders31_ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_ISP.BadExample.Concrete
{
    internal class Chichen : IBird
    {
        public string Fly() => "Hayır ben uçamam";

        public string Walk() => "Evet, ben yürüyebilirim.";
    }
}
