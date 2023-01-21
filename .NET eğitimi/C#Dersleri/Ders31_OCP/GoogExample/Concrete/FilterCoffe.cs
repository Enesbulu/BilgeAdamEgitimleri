using Ders31_OCP.GoogExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_OCP.GoogExample.Concrete
{
    internal class FilterCoffe: GoogCoffeShop
    {
        public override double GetTotalPrice(double amount) => amount * 33;
      
    }
}
