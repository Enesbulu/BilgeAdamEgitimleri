using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_OCP.BadExample
{
    public enum CoffeType { Latte=1,Expresso=2,Coffe=3 }
    internal class BadCoffe
    {
        public double GetTotalPrice(double amount, CoffeType coffeType)
        {
            double totalPrice = 0;

            switch (coffeType)
            {
                case CoffeType.Latte:
                    totalPrice += amount * 50;
                    break;
                case CoffeType.Expresso:
                    totalPrice += amount * 42;
                    break;
                case CoffeType.Coffe:
                    totalPrice += amount * 33;
                    break;
            }
            return totalPrice;
        }

    }
}
