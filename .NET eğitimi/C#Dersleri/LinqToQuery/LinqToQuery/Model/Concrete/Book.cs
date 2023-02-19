using LinqToQuery.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinqToQuery.Model.Concrete
{
    internal class Book : BaseClass<int>
    {
        [Required(ErrorMessage ="Lütfen bir kitap ismi giriniz.")]
        [MaxLength(200)]
        public string Title { get; set; }

        [Range(0.0,1000000.0,ErrorMessage ="Lütfen 1 ile 1.000.000 arasında bir değer giriniz.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Lütfen bir tür seçiniz.")]
        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }


    }
}
