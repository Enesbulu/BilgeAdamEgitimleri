using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders29_Enum.Model
{
    /*ENUM - Enumeration(Numaralandırma)
     * ---------
     * Uygulama içerisinde parametrik yönlendirmelere ihtiyaç duyduğunuz anda yazılımcıya kullanım kolaylığı sağlayan ve aynı zamanda okunabilirlik ve anlaşılabilirliği arttıran bir yapıdır.
     * 
     * Enum yapısı içerisinde sayısal karşılaştırma veya işlem gerektiren durumlarda yazılımcı için kod karmaşasını ortadan kaldıran bir yapıya sahiptir.
     * 
     * Enum yapısı içerisinde belirtilen özelliklerin bir veritipi bulunmamaktadır. Belirtilen degerler sadece property isimlerinden ibarettir. Bu Propertyler kendi içerisinde default olarak tam sayı tipinde deger tutarlar. Bu numaralar onların degeri olur. ve bu degerler ile uygulama içerisinde kulllanım sağlayabilirsiniz.
     * 
     * Enum içerisinde tanımlanan degerler, array yapılarında olduğu gibi ilk deger 0!dan başlar ve sıralı olarak ilerler. Dilerseniz bu default olarak aranan degeri kendiniz değiştirebilirsiniz.
     * 
     * Syntax
     * -----------
     * <erisimTuru> enum <enumAdi>{
     *  Deger|ler
     * }
     * 
     * Enum Tanımlaması yaparken Bilinmesi Gerekenler:
     * -----------------------------------------------
     * -Enum içerisinde deger vermezsek, değerler otomatik olarak 0'dan başlar ve birer birer artar.
     * -Enum'ların varsayılan değeri int'dir.
     * 
     * -Enumları; byte, sbyte,short, ushort, int, uint, long, ulong türlerinen oluşturabilirsiniz.
     * -Enum içerisinde verdiğimiz degerlere, değişken isimlendirmede uyduğumuz kurallar aynen geçerlidir.
     * 
     */
    
    internal enum Gunler:byte   //belirtilen veri tipi limitine kadar sıra limiti olur.
    {
        Pazartesi=1,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }
}
