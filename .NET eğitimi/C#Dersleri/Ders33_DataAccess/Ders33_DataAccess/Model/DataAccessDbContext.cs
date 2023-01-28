using System.Data.Entity;

namespace Ders33_DataAccess.Model
{
    public class DataAccessDbContext : DbContext
    {
        //Constructer metod aracılığı ile SqlServer'a bağlantı sağlıyoruz.
        public DataAccessDbContext(): base("myConnectionString")
        {

        }

        //Configration dosyasındaki ConnectionString içerisinde tanımlanmış olan DB'ye ilgili classları tablo olarak aktarımını sağlıyoruz.
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShopBasket> ShopBaskets { get; set; }

    }
}
