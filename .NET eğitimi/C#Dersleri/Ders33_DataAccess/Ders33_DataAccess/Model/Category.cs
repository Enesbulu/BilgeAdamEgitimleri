using System.ComponentModel.DataAnnotations;

namespace Ders33_DataAccess.Model
{
    public class Category : BaseClassWhithDate
    {
        [StringLength(100)] //Name metodu için kısıtlama
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
