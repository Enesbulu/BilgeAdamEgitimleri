using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_LSP.BadExample
{
    internal class BadAreaCalculator
    {
        public static int CalculateArea(BadRectangle badRectangle) => badRectangle.Width * badRectangle.Length;

        public static int CalculateArea(BadArea badArea) => badArea.Width * badArea.Length;
    }
}
