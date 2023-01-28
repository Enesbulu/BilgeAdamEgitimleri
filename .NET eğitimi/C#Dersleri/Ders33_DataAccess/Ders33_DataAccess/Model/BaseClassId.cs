using System.ComponentModel.DataAnnotations;

namespace Ders33_DataAccess.Model
{
    public class BaseClassId
    {
        [Key]   //Property'i Primary Key olarak tanımlamasını yapar.
        public int Id { get; set; }

    }
}
