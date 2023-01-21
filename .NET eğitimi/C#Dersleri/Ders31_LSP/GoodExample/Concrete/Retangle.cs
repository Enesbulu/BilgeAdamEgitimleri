using Ders31_LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_LSP.GoodExample.Concrete
{
    internal class Retangle : BaseShape
    {
        public int Width { get; set; }

        public override int CalculateArea() => base.Edge * this.Width;

        public override int CalculateRegion() => (base.Edge + this.Width) * 2;
    }
}
