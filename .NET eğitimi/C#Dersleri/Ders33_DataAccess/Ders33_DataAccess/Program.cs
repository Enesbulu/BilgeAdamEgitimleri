using Ders33_DataAccess.Model;
using System;
using System.Linq;

namespace Ders33_DataAccess
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region  Veri Ekleme
            /*
            //Uygulama içerisinden oluşturulan DB içerisine veri aktrımını sağlamak için hangi tabloya veri aktarımı yapılacaksa o class ile yeni bir nesne oluşturulup bilgilerin girilmesi gerekmektedir.
            
            //Categories tablosuna kayıt eklemek üzere yeni bir nesne oluşturalım.
            Category category = new Category();
            category.Name= "Bilgisayar";
            category.Description = "Dizüstü,Masaüstü,Mini PC,vs...";
            category.CreationDate= DateTime.Now;
            
            category.Name = "Televisyon";
            category.Description = "Led,Oled,Qled,vs...";
            

            //Veritabanına kayıt işlemi yapılabilmesi için oluşturulan DataAccesscontext classının instance edilmesi gerekmektedir.
            //Bu sayede DB ile bağlantı kurmuş olursunuz.
            DataAccessDbContext db = new DataAccessDbContext();

            //DB içerisineki ilgili tabloya veriyi eklememk için ilgili property'yi ekleme işlemi yapmamız gerekir. Bu işlemi yapmak için kolaksiyonlara veri ekleme olan .Add() metodu kullanılır.
            db.Categories.Add(category);

            // Ekleme işlemi yaptıktan sonra veri tabanındaki değişiklikleri kayıt etmek için oluşturulan DB contexti içerisinde bulunan .SaveChanges() fonksiyonu çalıştırılır.
            //Veritabanına kayıt işlemi esnasında kısıtlamalara bağlı olarak veya herhangi bir sebepten dolayı hata vermesi durumunda hatayı yakalamak için Try-Catch mekanizması kullanılır.
            try
            {
                db.SaveChanges();
                Console.WriteLine($"{category.Name} kategorisi veritabanına eklendi.");

            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: "+ e.Message);
            }
            */
            #endregion

            #region Verileri listeleme
            /*
            //DB ile bağlantı işlemini gerçekleştiriyoruz.
            DataAccessDbContext db = new DataAccessDbContext();

            //DB içerisindeki cateegoryleri koleksiyon haliyle çekelim.
            var kategoriler = db.Categories;

            //Kategoriler koleksiyonu içerisindeki verileri ekrana yazdıralım.
            foreach (var cat in kategoriler)
            {
                Console.WriteLine("Kategori Adı: " + cat.Name);
                Console.WriteLine("Kategori Açıklaması: " + cat.Description);
                Console.WriteLine();
            }
            */
            #endregion

            #region Veri Güncelleme
            /*
            //DB içersindeki herhangi bir kaydı güncellemek için öncelikle o kaydı ele almamız gerekmektedir. Şimdilik index numarasına göre kaydı çekelim.
            DataAccessDbContext db = new DataAccessDbContext();
            var kategori = db.Categories.ToList()[1];

            //Güncellemek istediğiniz propertyşere yeni deger ataması yapabilirsiniz.
            kategori.Description = "Led Tv, Plazma Tv,vs...";
            kategori.IsDeleted = true;

            try
            {
                db.SaveChanges();
                Console.WriteLine($"{kategori.Name} kategorisi başarı ile güncellendi.");
            }
            catch (Exception e)
            {

                Console.WriteLine("Hata: "+e.Message);
            }
            */
            #endregion

            #region Veri Silme

            //Silme işlemini yapabilmemiz için öncelikle silinecek olan nesneyi ele almanız gerekir.
            DataAccessDbContext db = new DataAccessDbContext();
            var kategori= db.Categories.ToList()[1];

            //DB üzerinde hangi tablo üzerinde silme işlemi gerçekleştirecekseniz o koleksiyon yapısı içerisinde bulunan .Remove(); metodu kullanarak silme işlemini gerçekleştirebilirsiniz.
            try
            {
                db.Categories.Remove(kategori);
                db.SaveChanges();
                Console.WriteLine($"{kategori.Name} kategorisi başarı ile silinmiştir.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata:" + e.Message);
            }

            #endregion


            Console.ReadKey();
        }
    }
}
