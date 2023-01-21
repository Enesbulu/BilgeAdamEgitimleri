using Ders31_ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_ISP.BadExample.Concrete
{
    public class Hawk : IBird
    {
        public string Fly() => "Evet ben uçabilirim.";

        public string Walk() => "Evet ben yürüyebilirim.";
    }
}
