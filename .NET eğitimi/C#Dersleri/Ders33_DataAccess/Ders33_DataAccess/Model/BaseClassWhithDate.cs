using System;
using System.ComponentModel.DataAnnotations;

namespace Ders33_DataAccess.Model
{
    public class BaseClassWhithDate:BaseClassId
    {
        [Required]  //Boş bırakılamaz bir kolon
        public DateTime CreationDate { get; set; }  = DateTime.Now;
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }  //İçi boş bırakıabilir -- '?' ile sağlanıyor.

    }
}
