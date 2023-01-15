using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary
             * ----------
             * Standart dizilere eklenen elemanlar, belleğe sıralı bir sekilde yerleştirilmektedir. Sıfırdan başlanarak her elemana birer index numarası verilip, o elemanlara o indexler aracılığıyla ulaşım sağlanmaktadır.
             
             * Dictionary  koleksiyonunda ise bu işleyiş değişmektedir. Dictionary  koleksiyonu yapsından dolayı anahtar(key) ve deger(value)  olmak üzere iki kavram ile karşımıza çıkmaktadır. Standart dizilere eklediğimiz elemanları Value, ilgili elemana ulaşmak için kulanılan indeş numarasını ise Key olarak düşünebilirsiniz.
             
             *Dictionary koleksiyonu oluştururken her bir değerin farklı Key değeri olmalıdır.
              
             * Yeni bir dictionary koleksiyonu oluşturuken key ve value değerleri için bir tip belirtilmesi zorunludur.
             
             *Belirtilen bu tipler ile koleksiyon içerisine o türdeki verilerin ekleme işlemi yapılır.
              
             * Syntax
             -----------------
             * Dictionary<TKey,TValue> <koleksiyonAdi> = new Dictionary<TKey,TValue>();
             * 
             
             */


            //Bir dictionary koleksiyonu olışturalım
            Dictionary<short,string> ogrenciler = new Dictionary<short,string>();

            //Oluşturulan koleksiyon içerisinde Add() metodu ile ekleme işlemi yapalım.
            ogrenciler.Add(120, "Tolga Demirel");
            ogrenciler.Add(480, "Ayşegül Fındık");
            ogrenciler.Add(532, "Kadir Aydemir");
            ogrenciler.Add(387, "Harun Çiftçi");

            //Öğrenciler koleksiyonu içerisindeki 480 numaralı öğrenciyi ekrana yazdıralım.
            Console.WriteLine(ogrenciler[480]);

            //Koleksiyon içerisinde olmayan bir Key bilgisine sahip bir elemana ulaşmak istediğimizde 'KeyNotFoundException' tipinde bir hata dönecektir.
            try
            {
                Console.WriteLine(ogrenciler[480]);

            }
            catch (KeyNotFoundException e)
            {

                Console.WriteLine("Hata Mesajı"+e.Message);
            }


            //Koleksiyon içerisindeki elemanları ekrana yazdırmak için foreach döngü mekanizması kullanabilirsiniz.
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenciler[ogrenci.Key]);
            }

            //ContainsKey() metodu => Koleksiyon içerisidne belirtilen key bilgisine göre arama yapar. KEy bilgisi var ise 'True' yok ise 'False' degeri döner.
            Console.WriteLine("480 numaralı öğrenci "+ (ogrenciler.ContainsKey(480)? "var":"yok"));

            //ContainsValue() metodu => koleksiyon içerisinde belirtilen value bilgisine göre arama yapar. Value bilgisi var ise 'True' yok ise 'False' egeri döner.
            Console.WriteLine("Tolga Demirel degerine sahip öğrenci " + (ogrenciler.ContainsValue("Tolga Demirel") ? "var" : "yok"));

            //Koleksiyon içerisindeki tüm elemanları silmek için
            //ogrenciler.Clear();

            //Koleksiyon içerisindeki eleman sayısına ulaşmak için count property'si kullanılır.
            Console.WriteLine("Eleman sayısı: "+ogrenciler.Count);

            //Remove() Metodu => Belirtilen key bilgisine sahip olan elemanı siler.
            ogrenciler.Remove(480);

            //Keys => Koleksiyon içerindeki key'leri geriye KeyCollction tipinde bir koleksiyon olarak verir.
            //Values => Koleksiyon içerisindeki value'ları geriye KEyCollection tipinde bir kollektion olarak verir.
            var keyler =ogrenciler.Keys.ToArray();  //ToArray() metodu sayesinde keyleri array'e çevirebilirsiniz.
            var degerler = ogrenciler.Values.ToArray();

            Console.ReadKey();
        }
    }
}
