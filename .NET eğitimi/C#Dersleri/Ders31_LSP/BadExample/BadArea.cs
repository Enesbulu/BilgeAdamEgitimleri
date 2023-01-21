using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_LSP.BadExample
{
    internal class BadArea: BadRectangle
    {
        int _length;
        public override int Length { 
            get => _length;
            set => _length= value; 
        }

        int _whidth;
        public override int Width 
        { 
            get =>_whidth; 
            set => _whidth= value; }
    }
}
