using Ders29_Struct.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders29_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tanımlamış olduğumuz struct yapısını kullanarak dikdörtgen hesaplaması yapalım.
            //Struct yapıları Sealed Class oalrak da geçmektedir. Miras almas miras bırakmaz!

            Dikdortgen dikdortgen= new Dikdortgen();
            dikdortgen.UK = 45;
            dikdortgen.KK = 20;
            Console.WriteLine("Alan: ", dikdortgen.Alan);
            Console.WriteLine("Çevre: ", dikdortgen.Cevre);

            Console.ReadKey();
        }
    }
}
