namespace Ders29_AbstractClass.Model
{
    internal class HumanResourcesManager : EmployeBaseManager
    {
        private decimal standartZamMiktari = 750;
        public HumanResourcesManager()
        {
            base.SetUnvan("İnsan Kaynakları");
            
        }
        /// <summary>
        /// Departman içerisinde tanımlı olan standart zam miktarı kadar arttırır.
        /// </summary>
        /// <param name="zamOrani"></param>
        public override void ZamYap()
        {
            base.Maas += 500;
        }
       
        
        
       
        /// <summary>
        /// Personel maaşını belirtilen yüzdelik oran kadar arttıralım.
        /// </summary>
        /// <param name="zamOrani">Yüzdelik oranda deger giriniz</param>
        public override void ZamYap(decimal zamOrani)
        {
            base.Maas += ((zamOrani / 100) * zamOrani);
        }
        
    }
}
