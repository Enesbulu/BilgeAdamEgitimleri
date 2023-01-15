using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_GenericType
{
    /*Generic Type
     * -----------
     * Çoğu zaman işlem yaptığımız zaman class yapılarında veya metodlarda belirtilen tiplere göre işlem yapılır. Bu tipler siz değiştirmeden veya aynı metodun overload'ını oluşturmadan farklı tipler ile işlem yapamazsınız.
     * Böylebir durum söz konusu olduğunda class yapılarındaki propertyler veya metod içerisindeki belirtiler generic type sayesinde instance edilme esnasında belirtilere işlem yapılabilir.
     * 
     * Bu Generic Type'lar defaut olarak T tanımlaması ile yapılır. Zorunlu değildir. Kendisiniz isteğiniz bir ismi verebilirsiniz.
     */

    internal class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int F { get; set; }

    }
}
