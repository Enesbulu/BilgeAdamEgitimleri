using LinqToQuery.Model.Abstract;
using LinqToQuery.Model.Concrete;
using LinqToQuery.Model.Context;
using LinqToQuery.Model.Extensions;
using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;

namespace LinqToQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BookDBContext db = new BookDBContext();

            #region Add Genre

            /*
            List<Genre> genres = new List<Genre>();
            genres.Add(new Genre() { Name ="Tarih",Status=Model.Abstract.StatusType.Active});
            genres.Add(new Genre() { Name = "Bilim Kurgu", Status = Model.Abstract.StatusType.Active });
            genres.Add(new Genre() { Name = "Romantik", Status = Model.Abstract.StatusType.Passive });
            genres.Add(new Genre() { Name = "Polisiye", Status = Model.Abstract.StatusType.Active });
            genres.Add(new Genre() { Name = "Dram", Status = Model.Abstract.StatusType.Passive });

            db.Genres.AddRange(genres);
            */
            #endregion

            #region Add Book

            //List<Book> books = new List<Book>()
            //{

            //    new Book() {Title="Çalı Kuşu", Price=65.90m,Status=StatusType.Active,GenreId=1},
            //    new Book() { Title = "Hayvanlar Çiftliği", Price = 45.99m, Status = StatusType.Active, GenreId = 1 },
            //    new Book() { Title = "Sefiller", Price = 55.99m, Status = StatusType.Active, GenreId = 2 },
            //    new Book() { Title = "Küçük Prens", Price = 16.90m, Status = StatusType.Active, GenreId = 3 },
            //    new Book() {Title="Tutunamayanlar", Price=65.90m,Status=StatusType.Active,GenreId=4},
            //    new Book() {Title="Martı", Price=65.90m,Status=StatusType.Active,GenreId=4},
            //    new Book() {Title="Aşk ve Gurur", Price=65.90m,Status=StatusType.Active,GenreId=4},
            //    new Book() {Title="İnsan Ne İle Yaşar", Price=65.90m,Status=StatusType.Active,GenreId=5},
            //    new Book() {Title="OD", Price=18.90m,Status=StatusType.Active,GenreId=1},
            //    new Book() { Title = "1984", Price = 72.50m, Status = StatusType.Passive, GenreId = 5 },
            //    new Book() { Title = "Otomatik Portakal", Price = 65.90m, Status = StatusType.Passive, GenreId = 4 },
            //    new Book() { Title = "Şeker Portakalı", Price = 65.90m, Status = StatusType.Passive, GenreId = 2 },

            // };
            //db.Books.AddRange(books);



            #endregion

            //db.SaveChanges();

            #region Select

            //Eski Yöntem
            /*var selectCollection = db.Genres.ToList();

            //foreach (var genre  in selectCollection)
            //{
            //    //genre.yazdır();
            //    Console.WriteLine("Id: "+genre.Id);
            //    Console.WriteLine("Adı: "+genre.Name);
            //    Console.WriteLine("Oluşturma Tarihi: "+ genre.CreatDate);
            //    Console.WriteLine();
            //}
            */

            //Linq Kullanımı

            /*  var selectCollection = db.Genres.Select(g => new
              {
                  Id=g.Id,
                  Name=g.Name,
                  Date=g.CreatDate
              }).ToList();

              foreach (var genre in selectCollection)
              {
                  //genre.yazdır();
                  Console.WriteLine("Id: " + genre.Id);
                  Console.WriteLine("Adı: " + genre.Name);
                  Console.WriteLine("Oluşturma Tarihi: " + genre.Date);
                  Console.WriteLine();
              }
              */

            /*

            var bookCollection = db.Books.Select(x => new
            {
                KitapAdi = x.Title,
                Fiyat = x.Price,
                //Genre property'si Class yapısında bir property olduğu için içindeki propertyler ile ilgili işlem yapabilirsiniz. Direk kendisini ekrana yazdıramazsınız.
                //Tur = x.Genre
                Tur=x.Genre.Name,
                Durum=x.Status
            });

            foreach (var book in bookCollection)
            {
                Console.WriteLine("Kitap Adı: "+book.KitapAdi);
                Console.WriteLine("Fiyat: "+book.Fiyat);
                //Console.WriteLine("Tür: "+ book.Tur.Name);  //
                Console.WriteLine("Tür: " + book.Tur);
                //Console.WriteLine("Durumu: "+book.Durum);

                //Console.WriteLine("Durum: "+Convertions.GetStatu(book.Durum));    //Class parametresinde 'this' yazmazsak
                Console.WriteLine("Durum: " + book.Durum.GetStatu());
                Console.WriteLine();

                Console.WriteLine();
            }

            */


            #endregion

            #region Where

            //var bookCollection = db.Books.Where(b => b.Status==StatusType.Active).Select(x=> new
            /*var bookCollection = db.Books.Where(b => b.Status == StatusType.Passive).Select(x => new
            {
                KitapAdi = x.Title,
                Fiyat = x.Price,
                Tur = x.Genre.Name,
                Durum = x.Status
            });


            foreach (var book in bookCollection)
            {
                Console.WriteLine("Kitap Adı: " + book.KitapAdi);
                Console.WriteLine("Fiyat: " + book.Fiyat);
                Console.WriteLine("Tür: " + book.Tur);
                Console.WriteLine("Durum: " + book.Durum.GetStatu());
                Console.WriteLine();
            }

            */
            #endregion



            //Ders35

            #region Where-2
            //Fiyatı 40 ile 70 tl arasında olan kitapları listeleyelim.
            //Alternatif olarak db bağlantısı.
            /*using (var db = new BookDBContext())
            {
                var books = db.Books
                    .Where(b => b.Price >= 40 && b.Price <= 70 && b.Status==StatusType.Active)
                    .Select(s => new
                    {
                        KitapAdi = s.Title,
                        KitapFiyati = s.Price,
                        Tur = s.Genre.Name,
                        Durum = s.Status
                    });

                foreach (var book in books)
                {
                    Console.WriteLine("Kitap Adi: " + book.KitapAdi);
                    Console.WriteLine("Kitap Fİyatı: "+book.KitapFiyati);
                    Console.WriteLine("Kitap Türü:" + book.Tur);
                    Console.WriteLine("Kitap Durumu: "+ book.Durum);
                    Console.WriteLine();
                }

            }*/

            #endregion

            #region OrderBy
            //Kitapları şsşmlerşne göre küçükten büyüğe doğru sıralayalım.
            /*using (var db = new BookDBContext())
            {
                var books = db.Books
                    .Select(x => new
                    {
                        Ad = x.Title,
                        Fiyat = x.Price,
                        Tur = x.Status,
                        Durum= x.Status
                    }).OrderBy(o => o.Ad);
               
                foreach (var book in books)
                {
                    Console.WriteLine("Kitap Adi: " + book.Ad);
                    Console.WriteLine("Kitap Fİyatı: " + book.Fiyat);
                    Console.WriteLine("Kitap Türü:" + book.Tur);
                    Console.WriteLine("Kitap Durumu: " + book.Durum);
                    Console.WriteLine();
                }

            }
            */
            #endregion

            #region OrderBy-2
            //Aktif olan ve fiyatı 30 ile 70 arasında olan kitapları tür Adına göre büyükten küçüğe doğru sıralayalım.
            /*
             using (var db = new BookDBContext())
            {
                var books = db.Books
                    .Where(b => b.Price >= 30 && b.Price <= 70 && b.Status == StatusType.Active)
                    .Select(s => new
                    {
                        Ad = s.Title,
                        Fiyat = s.Price,
                        Tur = s.Genre.Name,
                        Durum = s.Status
                    }).OrderByDescending(o => o.Tur);

                foreach (var book in books)
                {
                    Console.WriteLine("Kitap Adi: " + book.Ad);
                    Console.WriteLine("Kitap Fİyatı: " + book.Fiyat.ToString("C", new CultureInfo("en-US"))); //Sistem diline göre para birimi ile yazdırır.
                    Console.WriteLine("Kitap Türü:" + book.Tur);
                    Console.WriteLine("Kitap Durumu: " + book.Durum.GetStatu());
                    Console.WriteLine();
                }
            }
            */
            #endregion


            #region First
            //using System.Data.Entity kütüphanesi ile Include() yöntmi ile ilişki yapısı içerisinde olan classlara erişim sağlayabiliriz.
            /*
            using (var db = new  BookDBContext())
            {
                try
                {
                    var book = db.Books.Include(x => x.Genre).First();
                    
                    Console.WriteLine("Kitap Adi: " + book.Title);
                    Console.WriteLine("Kitap Fİyatı: " + book.Price);
                    Console.WriteLine("Kitap Türü:" + book.Genre);
                    Console.WriteLine("Kitap Durumu: " + book.Status);
                    Console.WriteLine();
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine("Hata: Mesajı: "+ e.Message);
                    Console.WriteLine();
                }
                

            }

            */
            #endregion
            //Kodda hata var!
            #region First-2
            //Fiyatı 50 $ üzerinde olan ilk kitabı getirelim.
            /* try
             {
                 using (var db = new BookDBContext())
                 {
                     var book = db.Books.First(b => b.Price >= 50);
                     Console.WriteLine("Kitap Adi: " + book.Title);
                     Console.WriteLine("Kitap Fiyatı : " + book.Price);
                     Console.WriteLine("Kitap Türü: " + book.Genre.Name);
                     Console.WriteLine("Kitap Durumu: "+ book.Status);
                     Console.WriteLine();
                 }

             }
             catch (Exception e)
             {
                 Console.WriteLine("Hata Mesajı: " + e.Message);
             }
             */
            #endregion

            #region FirstOrDefault
            //Koleksiyon içerisindeki ilk veriyi çeker. Koleksiyonda hernhangi bir veri bulunmuyorsa null değeri geri döndürür.
            //Kitap Türleri tablosundaki ilk veriyi çekelim.
            /*using (var db = new BookDBContext())
            {
                var genre = db.Genres.Include(b=>b.Books).OrderBy(g=>g.Name).FirstOrDefault();
                if (genre !=null)
                {
                    Console.WriteLine("Tür: " + genre.Name);
                    Console.WriteLine("Durum: " + genre.Status.GetStatu());
                    Console.WriteLine();
                    Console.WriteLine("Türe Bağlı kitaplar:");
                    Console.WriteLine("-----------------------------");

                    if (genre.Books.Count > 0)
                    {
                        foreach (var book in genre.Books)
                        {
                            Console.WriteLine("Kitap Adi: " + book.Title);
                            Console.WriteLine("Kitap Fİyatı: " + book.Price.ToString("C", new CultureInfo("en-US"))); //Sistem diline göre para birimi ile yazdırır.
                            Console.WriteLine("Kitap Türü:" + book.Genre.Name);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Listelenecek kitap bulunamadı.");
                    }
                }
                else
                {
                    Console.WriteLine("Tür bulunamadı.");
                }
                
            }
            */
            #endregion


            #region FirstOrDefault-2
            //Fiyatı 60$ üzerinde olan ilk kitabı getirelim.
            /*using (var db = new BookDBContext())
            {
                var book = db.Books.Include(g => g.Genre).FirstOrDefault(b => b.Price >= 60);
                if (book != null)
                {
                    Console.WriteLine("Ad: " + book.Title);
                    Console.WriteLine("Fiyatı: " + book.Price.ToString("C", new CultureInfo("en-US")));
                    Console.WriteLine("Tür: " + book.Genre.Name);
                    Console.WriteLine("Durum: " + book.Status.GetStatu());
                    Console.WriteLine();

                }
            }
            */
            #endregion

            #region Find
            //Koleksiyon içerisinde tanımlanan PrimaryKey propertysi içerisindeki değere göre arama işlemini yapar. Eşleşen classı geri döndürür. İlgili değeri geri döndürür. İlgili değeri bulamıyorsa null degeri döndürür.
            /*using (var db = new BookDBContext())
            {
                var book = db.Books.Find(5);
                if (book ==null)
                {
                    Console.WriteLine("Kitap Bulunamadı.");
                }
                else
                {
                    Console.WriteLine("Ad: " + book.Title);
                    Console.WriteLine("Fiyatı: " + book.Price.ToString("C", new CultureInfo("en-US")));
                    Console.WriteLine("Durum: " + book.Status.GetStatu());
                    Console.WriteLine();
                }
            }
            */
            #endregion

            #region Take
            //Koleksiyon içerisindeki verileri belirtilen adet kadar getirir.
            //Kitaplar içerisinde  fiyatı en pahalı 3 kitabı listeleyelim.
            /*
            using (var db=new BookDBContext())
            {
                var books = db.Books.Include(b=>b.Genre).OrderByDescending(b => b.Price).Take(3);
                if (books.Count()==0)
                {
                    Console.WriteLine("Listelenecek Kitap bulunamadı.");
                }
                else
                {
                    foreach (var book in books)
                    {
                        Console.WriteLine("Ad: " + book.Title);
                        Console.WriteLine("Fiyatı: " + book.Price.ToString("C", new CultureInfo("en-US")));
                        Console.WriteLine("Tür: " + book.Genre.Name);
                        Console.WriteLine("Durum: " + book.Status.GetStatu());
                        Console.WriteLine();
                    }
                }
            }

            */
            #endregion

            #region Skip
            //Koleksiyon içerisinde belirtilen sayı kadar degeri atlamak için kullanılır.

            //Fiyatı en pahalı 5. kitabı getirelim.
            /*
            using (var db = new BookDBContext())
            {
                Book book = db.Books.OrderByDescending(x => x.Id)
                    .Skip(4).FirstOrDefault();  //Atlanacak miktarı belirtiyoruz.
                if (book==null)
                {
                    Console.WriteLine("Kitap bulunamadı.");
                }
                else
                {
                    Console.WriteLine("Ad: " + book.Title);
                    Console.WriteLine("Fiyatı: " + book.Price.ToString("C", new CultureInfo("en-US")));
                    Console.WriteLine("Durum: " + book.Status.GetStatu());
                    Console.WriteLine();
                }

            }
            */
            #endregion

            #region Contains
            //Koleksiyon içerisinde belirtilen propertylerde, belirtilen kelime geçiyorsa o class yapılarını koleksiyon olarak geriye döndürmemizi sağlar.
            //İçerisinde 'a' harfi geçen kitapları listeleyelim.
            /*using (var db = new BookDBContext())
            {
                var books = db.Books.Where(b => b.Title.Contains("a"));

                foreach (var book in books)
                {
                    Console.WriteLine("Ad: " + book.Title);
                    Console.WriteLine("Fiyatı: " + book.Price.ToString("C", new CultureInfo("en-US")));
                    Console.WriteLine("Durum: " + book.Status.GetStatu());
                    Console.WriteLine();
                }
            }
            */
            #endregion

            #region StartsWith()
            //Koleksiyon içerisinde belirtilen propertylerde, belirtilen kelime ile başlıyorsa o class yapılarını koleksiyon olarak geriye döndürmemizi sağlar.

            //İçerisinde 'a' harfi geçen kitapları listeleyelim.
            /*using (var db = new BookDBContext())
            {
                var books = db.Books.Where(b => b.Title.StartsWith("a"));

                foreach (var book in books)
                {
                    Console.WriteLine("Ad: " + book.Title);
                    Console.WriteLine("Fiyatı: " + book.Price.ToString("C", new CultureInfo("en-US")));
                    Console.WriteLine("Durum: " + book.Status.GetStatu());
                    Console.WriteLine();
                }
            }
            */
            #endregion

            #region EndsWith()
            //Koleksiyon içerisinde belirtilen propertylerde, belirtilen kelime ile bitiyorsa o class yapılarını koleksiyon olarak geriye döndürmemizi sağlar.

            //İçerisinde 'r' harfi geçen kitapları listeleyelim.
            /*using (var db = new BookDBContext())
            {
                var books = db.Books.Where(b => b.Title.EndsWith("r"));

                foreach (var book in books)
                {
                    Console.WriteLine("Ad: " + book.Title);
                    Console.WriteLine("Fiyatı: " + book.Price.ToString("C", new CultureInfo("en-US")));
                    Console.WriteLine("Durum: " + book.Status.GetStatu());
                    Console.WriteLine();
                }
            }
            */
            #endregion

            #region Any
            //Koleksiyon içerisinde öğe var mı? yok mu? sorusuna karşılık olarak boolean değer döndürür.

            //Fiyatı 70$ üzerinde bir kitap var mı?
            /*using (var db = new BookDBContext())
            {
                var result = db.Books.Any(x => x.Price >= 70);
                Console.WriteLine("Fiyatı 70$ üzerinde bir kitap " + (result ? "Var" : "Yok"));
            }
            */

            #endregion

            #region Count
            //Koleksiyon içerisinde bulunan eleman sayısını geri döndürür.

            //Aktif olan kitapların sayısının ekrana yazdıralım.
            /*
            using (var db= new BookDBContext())
            {
                var result = db.Books.Count(x => x.Status == StatusType.Active);
                Console.WriteLine("Veri tabanındaki aktif olan kitapların sayısı: "+ result);
            }
            */

            #endregion

            #region Sum 
            //Koleksiyon içerisindeki belirtilen propertynin toplamını alır. Sadece sayısal propertylerde kullanılabilir.
            //Veritabanındaki kitaplar tablosunda bulunan pasif kitapların toplam tutarını ekrana yazdıralım.
            /*
             using (var db = new BookDBContext())
            {
                var totalPrice =db.Books.Where(x=>x.Status==StatusType.Passive).Sum(x => x.Price);
                Console.WriteLine("Veri Tabaındaki kitapların toplam tutarı: " + totalPrice.ToString("C", new CultureInfo("en-US")));
            }
            */
            #endregion

            #region Min & Max
            //Koleksiyon içerisindeki belirtilen propertynin min ve max degerini alır. Sadece sahısal propertyler için kullanılıabilir.

            //Veritabanında kayıtlı olan en pahalı ve en ucuz olan kitabın fiyatını ekranan yazdıralım.
            /*
            using (var db = new BookDBContext())
            {
                var mostExpensive = db.Books.Max(x => x.Price);
                var cheapest= db.Books.Min(x => x.Price);
                Console.WriteLine($"En pahalı kitap: {mostExpensive.ToCurrency("tr-TR")}, En ucuz kitap: {cheapest.ToCurrency()} "); //Kendi oluşturduğumuz kültür metodu ile para birimini yazdırdık.

            }
            */

            #endregion

            #region GroupBy
            //Group By metodu ile belirtilen propertyle göre gruplama işlemi yapmanızı sağlar. Geriye IGrouping<TKey,TIQueryable<TValue>> koleksiyonu döndürür.

            //TKey => Gruplama yapılan property tipini ifade eder.
            //IQuerable<TValue> => Gruplanan tipe bağlı olan koleksiyonu ifade eder.

            //Türlere göre kitap sayılarını ekrana yazdıralım. Kitap sayısı 2 den büyük olanların kitap sayısına göre listeleyelim.
            /*using (var db=new BookDBContext())
            {
                var genreTypes = db.Books.GroupBy(b => b.Genre.Name)
                    .Select(g => new
                    {
                        GenreName = g.Key,
                        Count = g.Count()
                    }).Where(b=>b.Count>=2)
                    .OrderBy(x=>x.Count);
                foreach (var genre in genreTypes)
                {
                    Console.WriteLine("Tür Adi: "+ genre.GenreName);
                    Console.WriteLine("Kitap Sayisi: "+genre.Count);
                    Console.WriteLine();
                }

            }
            */

            #endregion

            #region GroupBy-2
            //Türleri içerisinde bulunan kitapların toplam tutarına göre listeleyelim.
            /* using (var db = new BookDBContext())
             {
                 var books = db.Books.GroupBy(g => g.Genre.Name)
                     .Select(s => new
                     {
                         Name = s.Key,
                         TotalPric = s.Sum(t => t.Price)
                     });
                 foreach (var genre in books)
                 {
                     Console.WriteLine("Tür adi: "+genre.Name);
                     Console.WriteLine("Toplam Fiyat: " + genre.TotalPric);
                     Console.WriteLine();
                 }
             }
             */
            #endregion

            #region GroupBy-3
            //Türleri içerisinde bulunan kitapların toplam tutarına göre listeleyelim.
            /*using (var db = new BookDBContext())
            {
                var booksGroup = db.Books.GroupBy(g => g.Genre.Name);
                foreach (var book in booksGroup)
                {
                    Console.WriteLine("Grup Adı: "+book.Key);
                    Console.WriteLine("------------");
                    foreach (var item in book.OrderBy(x=>x.Title))
                    {
                        Console.WriteLine("Kitap Adi: "+ item.Title);
                        Console.WriteLine("Kitap fiyatı: "+item.Price.ToCurrency());
                        Console.WriteLine();
                    }
                    Console.WriteLine("Grubun toplam fiyatı: "+ book.Sum(x=>x.Price).ToCurrency());
                    Console.WriteLine();

                }
            }
            */

            #endregion



            #region MyRegion
            using (var db =new BookDBContext())
            {
                var genreList = db.Genres.Include(x=>x.Books);
                foreach (var item in genreList)
                {
                    Console.WriteLine("Tür Adi: "+item.Name+ "\t-Kitap Sayısı: "+item.Books.Count);
                    Console.WriteLine("---------------");
                    foreach (var book in item.Books)
                    {
                        Console.WriteLine("Kitap ADi: "+book.Title);
                    }
                    Console.WriteLine();
                }

            }


            #endregion


            Console.ReadKey();
        }
    }
}
