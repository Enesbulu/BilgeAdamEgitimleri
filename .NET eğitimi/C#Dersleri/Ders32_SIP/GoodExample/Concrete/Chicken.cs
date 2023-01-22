using Ders32_SIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders32_SIP.GoodExample.Concrete
{
    public class Chicken : IProduct
    {
        public string GetMenu() => "Tavuk Menüsü";
        

    }
}
