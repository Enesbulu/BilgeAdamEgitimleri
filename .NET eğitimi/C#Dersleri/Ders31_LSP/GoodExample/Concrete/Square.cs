using Ders31_LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_LSP.GoodExample.Concrete
{
    internal class Square : BaseShape
    {
        public override int CalculateArea() => base.Edge * base.Edge;

        public override int CalculateRegion() => base.Edge * 4;
    }
}
