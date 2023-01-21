using Ders31_OCP.GoogExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_OCP.GoogExample.Concrete
{
    internal class Latte: GoogCoffeShop
    {
        protected double price = 50;
        public override double GetTotalPrice(double amount) => amount * price;
        
    }
}
