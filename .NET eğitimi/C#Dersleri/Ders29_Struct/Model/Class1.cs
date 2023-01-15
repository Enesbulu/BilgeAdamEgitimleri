using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders29_Struct.Model
{
    /*Struct
     * ---------------
     * Nesneye yönelik programlama(OOP) yapılarının en önemli yapılarıdan biri olan class yapısına alternatif olarak yaratılmıştır. Bir takım kısaltmaları ve daha basit kullanımı olan içerisinde deger tipleri barındıran yapıdır.
     * 
     * OOP içerisinde Class yapıları REferns tip, struct yapısı ise deger tipi olarak geçmektedir.
     * 
     * Struct yapısı içerisine miras alma işlemi uygulanamaz.
     * Değer tipi olmasından dolayı Programlama içerisinde new ifadesi ile instance uygulamadan direk olarak kullanabilirsiniz.
     * 
     * Struct yapıları ram'in stack bölümünde yer alır.
     * 
     * Class yapılarında olduğu gibi metod, preporty veya field yapısı barındırabillirler.
     * 
     * Not: Struct yapısı içerisinde tanımlanan metodlara erişim sağlamak için new ifadesi ile instance etmemize gerek kalmaz. Fakat struct yapısı içerisinde bir property tanımlaması yapıldıysa new ifadesi ile o struct yapısını heap alanına taşıyarak propertyeri oluşturabilir ve içerisine default deger ataması yapabilirsiniz.
     * 
     * Syntax
     * -----------
     * <erisimTuru> struct <structAdi>{
     *  <özellikler>
     * }
     */
    internal struct Dikdortgen    
    {
        public int KK { get; set; }
        public int UK { get; set; }
        public int Alan { get { return UK * KK; } }
        public int Cevre { get { return (UK + KK) * 2; } }

    }
}
