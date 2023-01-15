using System;

namespace Ders29_AbstractClass.Model
{
    internal class EngineerManager : EmployeBaseManager
    {
        private decimal standartZamMiktari = 1500;
        public EngineerManager()
        {
            base.SetUnvan("Mühendis");
        }
        public override void ZamYap()
        {
            base.Maas += this.standartZamMiktari;

        }

        public override void ZamYap(decimal zamOrani)
        {
            decimal hzo = (base.Maas / 100) * zamOrani;

            if (this.standartZamMiktari < hzo)
            {
                base.Maas += hzo;
            }
            else
            {
                Console.WriteLine($"{this.standartZamMiktari} tutarından daha az zam apamazsınız.");
                Console.WriteLine();
            }
        }
    }
}
