using LinqToQuery.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LinqToQuery.Model.Concrete
{
    internal class Genre : BaseClass<int>
    {
        [Required(ErrorMessage ="Lütfen tür bilgisi giriniz.")]
        [StringLength(50)]
        public string Name { get; set; }

        //Book clas yapısı içerisinde ForeignKey ile Genre ilişkisi olduğundan dolayı, Genre Class'ı içerisinden de Book class'ına erişim sağlamak için bir ICollection tipinde bir tanımlama yapılabilir.
        public virtual ICollection<Book> Books{ get; set; }

        internal void yazdır()
        {
            Console.WriteLine($"Adı: {Name}\tOluşturma Tarihi: " + CreatDate.ToString("dd.MM.yyyy HH:mm:ss"));
        }
    }
}
