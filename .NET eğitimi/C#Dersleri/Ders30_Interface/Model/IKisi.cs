using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_Interface
{
    /*INTERFACE
     * -------------
     * Interfaceyapısı gereği diğer sınıflara yol gösterici, rehberlik yapmak içinoluşturulan, kendisiden implement edilen  bir sınıfta doldurulması zorunlu olan bazı özelliklerin aktarılmasını sağlayan bir kavramdır.
     * 
     * Özellikleri;
     * -Sınıf yapılarımız birden fazla interface ile implement edilebilir.
     * -In terface yapıları rehber, yol göstericiler olarak tanımlandığından dolayı içerisinde metot ve property tanımlaması dışında herhangi bri kod bloğu bulunmaz.
     * -Interface içerisinde tanımlanan tüm özellikler default olarak public kabul edilir.
     * -Bir interface'i başka bir interface'den türetebilirsiniz.
     * -Sınıflar implement edilen Interface içerisindeki bulunan tüm özellikleri implement etmek zornadır.
     * -İnterface içerisinde tannımlanan metodalar gövdesizdir. Bu yapsısı ile abstruct metodlara benzemektedir.
     * -Interface yapıları kullanılarak nesneler oluşturulamaz.
     *  
     * 
     */ 
    internal interface IKisi
    {
        string Name { get; set; }
        string LastName { get; set; }
        string FullName { get; }

        void Yazdir();

    }
}
