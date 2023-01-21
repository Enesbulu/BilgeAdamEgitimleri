using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders31_OCP.GoogExample.Concrete
{
    internal class LatteCampaing: Latte
    {
        public double Campaing(double amount)
        {
            double totalPrice =amount * price;
            if (amount >= 5)
            {
                totalPrice = totalPrice * (1 - 0.30);
            }
            return totalPrice;
        }
    }
}
