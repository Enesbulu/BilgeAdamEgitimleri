using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_LSP.GoodExample.Abstract
{
    public abstract class BaseShape
    {
        public int Edge { get; set; }
        public abstract int CalculateArea();
        public abstract int CalculateRegion();
    }
}
