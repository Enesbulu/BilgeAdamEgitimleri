// See https://aka.ms/new-console-template for more information
#region String Functions (Metin Fonsksiyonlar)
//String degerler içerisindebir takım işlemler yapmak için kullanılan, Microsoft'un bize sunmuş olduğu hazır fonskiyonşar bulunmaktadır. Bu fonksiyonlr ile metinsel degerlerin özelliklerini degisştirmek için kullanılan metodlardır.
// Metinsel bir degeri parcalamak, eklemek,çıkarmak, degiştirmek, vs .. gibi işlemleri ekstra efor sarfetmeden  bu fonksiyonlar aracılığıyla işlemelerinizi yapabilirsiniz.

#endregion

string ornekMetin = "Bilge Adam";
Console.WriteLine(ornekMetin);
Console.WriteLine();

#region CompareTo()
//String degerle metod içerisine veridiğini parametredeki string degeri sözlük mantığı ile karşılaştırır. Eğer sözlük aynı lokasyondaki degerler ile eşleşiyorsa 0, parametrede verilen degerler ana degerimizden önce geliyorsa -1, sonra geliyorsa 1 degerini döndürü.

int sonuc = ornekMetin.CompareTo("Bilge Adam");
switch (sonuc)
{
    case -1:
        Console.WriteLine("Kelime diğer kelime ile eşleşmemektedir. Eksik karakter var");
        break;
    case 0:
        Console.WriteLine("Tebrikler! Kelimelr birbiri ile eşleşmektedir.");
        break;
    case 1:
        Console.WriteLine("Kelime,diger kelime ile eşleşmemektedir, fazla karakter var.");
        break;
}
Console.WriteLine();
#endregion

#region Contains()
//String deger içerisinde belirtilen deger var mı sorgusunu yapar. Geriye boolean tipinde deger döndürür. True ise var, False ise yok anlamına gelir

bool varMi = ornekMetin.Contains("Adam");
Console.WriteLine("Aradığınız deger " + (varMi ? "bulunmaktadır" : "bulunmamaktadır."));

#endregion

#region StartsWith()
//String bir deger, belirtilen eger ile başlayıp başlamadığının sonucunu boolean olarak döndürür.

bool baslangic = ornekMetin.StartsWith("Bil");
Console.WriteLine("Metin belirtdiğiniz deger ile " + (baslangic ? "baslıyor." : "başlamıyor."));
Console.WriteLine();
#endregion

#region EndsWith()
//String bir deger, belirtilen eger ile bitip bitmediğinin sonucunu boolean olarak döndürür.

bool bitis = ornekMetin.StartsWith("Bil");
Console.WriteLine("Metin belirtdiğiniz deger ile " + (bitis ? "bitiyor." : "bitmiyor."));
Console.WriteLine();
#endregion

#region IndexOf()
//Dizilerde görmüş olduğumuz metod ile aynı mantıktaa çalışmaktadır. geriye int türünde deger alırız. Metinsel ifade içerisinde belitrilen karakter veya metin varsa index numarasını döndürür. Yoksa -1 degerini döndürür.

int sonucIndex = ornekMetin.IndexOf('a');
Console.WriteLine("Aradığınız karakter " + (sonucIndex == -1 ? "bulunamadı." : sonucIndex + ". indextedir."));

#endregion

#region LastIndexOf()
//Dizilerde görmüş olduğumuz metod ile aynı mantıktaa çalışmaktadır.Aramaya sondan başlar. Geriye int türünde deger alırız. Metinsel ifade içerisinde belitrilen karakter veya metin varsa index numarasını döndürür. Yoksa -1 degerini döndürür.

int sonucLastIndex = ornekMetin.LastIndexOf('a');
Console.WriteLine("Aradığınız karakter " + (sonucLastIndex == -1 ? "bulunamadı." : sonucLastIndex + ". indextedir."));

#endregion

#region Remove()
//String bir deger içerisinde belirtilen index numarası  ve karakter sayısına göre silme işlemini uygular.
//String degerin mevcut degerini değiştirmez. Geriye bir kopyasını metinsel ifade olarak geri döndürür.

//iki farklı kullanımı vardır.
//1-Fonksiyon içerisinde belirtilen index içerisindebelirtilen index numarası dahil olmak üzere o index ve sonrasındaki tüm karakterleri siler.
//2-Fonsksiyon içerisinde belirtilen index numarası dahil olmak üzere, girilen ikinci parametredeki deger kadar silme işlemi yapar

string metin = "Merhaba Dünya";
Console.WriteLine(metin.Remove(5));     //1. kullanım
Console.WriteLine(metin.Remove(6, 2));   //2. kullanım
#endregion

#region Replace()
//Metin içerisinde belirtilen bir karakter veya metni değiştirmek için kullanılır.
string degistirilen = metin.Replace("Dünya", "Mars");
Console.WriteLine(degistirilen);
Console.WriteLine();
#endregion

#region Split()
//metinlerimizi özel bir karaktere göre birden fazla parçaya ayırmamıza olanak sağlayan metotdur. Aynı anda birden fazla özel karakter ile ayırabilirsiniz. Geriye string[] tipinde deger döndürür.

string metin2 = "İstanbul-Ankara-İzmir-Adana";
string[] sehirler = metin2.Split('-');
foreach (var item in sehirler)
{
    Console.WriteLine(item);
}
Console.WriteLine();
#endregion

#region Insert()
//Bir metin degerinin herhangi bir pozisyona (index) yeni bir degeri ilişkilendirmek için kullanılır. İlk parmetre kaçıncı indexten sonra ekleyeceği, ikinci parametre ise eklemek istediğiniz metin degeridir.
string metin3 = "Insert ekleme islemi";
Console.WriteLine(metin3);
metin3 = metin3.Insert(7, "Metodu ");
Console.WriteLine(metin3);
Console.WriteLine();

#endregion

#region ToLower() & ToUpper()
//ToLower() => Belirtilen metin içerisinde  bulunan bütün karakterleri küçük karakterlere çevirir.
//ToUpper() => Belirtilen metin içerisinde  bulunan bütün karakterleri büyük karakterlere çevirir.
Console.WriteLine("ToLower : "+ornekMetin.ToLower());
Console.WriteLine("ToUpper : " + ornekMetin.ToUpper());
Console.WriteLine();


#endregion

#region Equels()
//Bir metin içerisindeki degeri başka bir metin ile eşitliğini sorgulamak için kullanılır. Geriye boolean tipinde deger döndürür.
//Metod içerisinde 2. parametre olarak 'StringComparison.OrdinalIgnoreCase' parametresini eklerseniz,büyük veya küçük karakter gözekmeksizin karşılaştırma işlemini yapar.

bool esitMi = ornekMetin.Equals("bilge adam",StringComparison.OrdinalIgnoreCase);
Console.WriteLine("Metinler " + (esitMi ? "eşleşiyor" : "eşleşmiyor"));
Console.WriteLine();
#endregion

#region SubString()
//Metin içerisinde belirtilen index degerleri aralığındaki karakterleri almak için kullanılır.
//2 Farklı kullanımı vardır.
//I => Parametre olarak gönderilen index degerinden başlayarak, geri kalan tüm metinleri alır.
//II => İlk parametre olarak verilmiş  olduğumuz index numarasından , ikinci parametre olarak vermiş olduğumuz adet kadar olan karakterleri alır.

Console.WriteLine("I. Kullanım: "+ornekMetin.Substring(3));
Console.WriteLine("II. Kullanım: " + ornekMetin.Substring(2,5));
Console.WriteLine();
#endregion

#region ToCharArray()
//Metin karakterlerine ayırarak geriye char[] degeri döndürür.
char[] karakterler = ornekMetin.ToCharArray();
foreach (var item in karakterler)
{
    Console.Write(item + "-");
}
Console.WriteLine();
for (int i = 0; i < karakterler.Length; i++)
{
    Console.Write(i == 0 ? "" : " - " + karakterler[i]);
}
Console.WriteLine();
#endregion

#region Trim()
//Bir metindeki baştaki ve sonraki  boşlukları veya belirtilen karakterleri temizlemek için kullanılır.
//TrimStart() => Baştaki boşlukları temizler
//TrimEnd() => Sonraki boşlukları temizler.
//Trim() => Baştaki ve sonraki boşlukları siler

string metin4 = "        MErhaba Dünya    ,.?      ";
string metin5 = "  ,.?     Nasılsın??   ,.?    ";
Console.WriteLine(metin4.Trim() + " " + metin5.TrimStart());
char[] ozelKarakterler = { '.', ',', '?' };
Console.WriteLine(metin4.Trim(ozelKarakterler) + " " + metin5.TrimStart(ozelKarakterler));

Console.WriteLine();

#endregion

#region IsNullEmpty()
//Metin içerisinde bir deger var mı? yok mu? sorgulmasını yapar. Geriye boolean tipinde deger döndürür. Boş degerde true deger döner.
string metin6 = string.Empty;
Console.WriteLine("Metin " + (string.IsNullOrEmpty(metin6) ? "boş" : "dolu"));
#endregion

#region Reverse()
//MEtinsel degeri tersine çevirmek için kullanılır. Geriye IEnumerable tipinde deger döndürür.
var tersMetin = ornekMetin.Reverse();
foreach (var item in tersMetin)
{
    Console.Write(item);
}

#endregion



Thread.Sleep(2500);
