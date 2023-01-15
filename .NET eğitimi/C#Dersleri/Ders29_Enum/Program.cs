using Ders29_Enum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders29_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gunler gun = (Gunler) 3;

            //Console.WriteLine("Haftanın kaçıncı günü?: ");
            //Gunler secilenGun= (Gunler) int.Parse(Console.ReadLine());

            var secilenGun =Enum.Parse(typeof(Gunler), Console.ReadLine());

            switch ((Gunler)secilenGun)
            {
                case Gunler.Pazartesi:break;
                case Gunler.Sali:
                case Gunler.Carsamba:
                case Gunler.Persembe:
                case Gunler.Cuma:
                    Console.WriteLine("Hafta içi");
                    break;
                case Gunler.Cumartesi:
                case Gunler.Pazar:
                    Console.WriteLine("Geçersiz bir bilgi girildi.");
                    break;
                default: Console.WriteLine("Geçersiz bir bilgi girili.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
