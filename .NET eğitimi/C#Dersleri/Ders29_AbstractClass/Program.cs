using Ders29_AbstractClass.Model;
using System;

namespace Ders29_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IK Departmanı için yeni bir personel oluşturalım.
            HumanResourcesManager employe1 = new HumanResourcesManager();
            employe1.SetInfo("Ayşe", "Durmaz", 8500);
            employe1.GetInfo();
            Console.WriteLine();

            EngineerManager employe2 = new EngineerManager();
            employe2.SetInfo("Ali", "Kaya", 20000);
            employe2.GetInfo();

            employe1.ZamYap(20);
            employe1.GetInfo();

            employe2.ZamYap(30);
            employe2.GetInfo();


            Console.ReadKey();
        }
    }
}
