using Ders31_ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_ISP.GoodExample.Concrete
{
    public class Chichen : IWalkBird,ISwimBird
    {
        public string Swim() => "Evet, ben yüzerim.";

        public string Walk() => "Evet, ben yürüyebilirim. ";
    }
}
