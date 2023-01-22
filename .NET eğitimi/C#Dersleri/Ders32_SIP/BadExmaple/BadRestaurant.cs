using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders32_SIP.BadExmaple
{
    public class BadRestaurant
    {
        BadFish badFish = new BadFish();
        BadChichen badChichen= new BadChichen();

        public string GetAllMenu() => $"{badFish.BadFishMenu()}-{badChichen.GetChickenMenu()}";
    }
}
