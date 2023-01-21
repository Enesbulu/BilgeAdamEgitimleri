using Ders31_ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_ISP.GoodExample.Concrete
{
    internal class Flamingo : IFlyBird, ISwimBird, IWalkBird
    {
        public string Fly() => "Evet, ben uçabilirim";

        public string Swim() => "Evet Ben yüzebilirim";

        public string Walk() => "Evet, ben yürüyebilirim.";
    }
}
