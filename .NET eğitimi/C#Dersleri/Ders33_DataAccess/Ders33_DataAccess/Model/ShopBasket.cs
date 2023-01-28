using System.ComponentModel.DataAnnotations.Schema;

namespace Ders33_DataAccess.Model
{
    public class ShopBasket : BaseClassWhithDate
    {
        public int ProductId { get; set; }
        public int Amount { get; set; }

        //Bi productId property değerini Product Class'ı  içerindeki ilişki yapısına girmesi için [ForeignKey(<propert>)] tanımlaması yapılır.
        [ForeignKey("ProductId")]
        //Tanımlanan ForeingKey property'si hangi class içerisindeki Primary Key ile ilişki içerisine girecek ise o class ismi Virtual olarak tanımlanır.
        public virtual Product Product { get; set; }   

    }
}
