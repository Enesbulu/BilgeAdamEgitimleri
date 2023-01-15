using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_Interface.Model
{
    internal class Kisi : IKisi
    {
        public string Name { get; set ; }
        public string LastName { get; set; }

        //public string FullName => Name + " " + LastName;    //Sadece get olarak işlem yapıyor.
        public string FullName
        {
            get { return Name + " " + LastName; }
        }

        public void Yazdir()
        {
            Console.WriteLine("Tam Ad: "+ FullName); 

        }
    }
}
