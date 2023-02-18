using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace Ders33_DataAccess.Model
{
    public class Product : BaseClassWithDate
    {
        [StringLength(150)] //Max karakter uzunluğu
        public string Name { get; set; }

        [Min(0)]    //UnitPrice için min sınırı.
        public decimal UnitPrice { get; set; } = 0;

        [Min(0)]    //UnitStock için min sınırı
        public int UnitInStock { get; set; } = 0;
        
        public string UnitType { get; set; }

        [Range(0.0,1)]  //Discount içi aralık ksıtlaması.
        public double Discount { get; set; } = 0;

    }
}
