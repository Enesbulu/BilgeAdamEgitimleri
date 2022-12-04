#region DateTime
//  DateTime
//-------------------
//Zaman ile ilgili yapabileceğiniz tüm işlemleri ve tüm verileri elde edebildiğiniz nesnedir.

#region .Now
using System.Globalization;

DateTime tarih = DateTime.Now; //Şimdiki zamanı alır. Geriye DAteTime tipine deger döndürür.
Console.WriteLine("Şimdiki Zaman: " + tarih);

#endregion

#region Tarih Bilgisi alma
Console.WriteLine("Kısa tarih bilgisi: "+tarih.ToShortDateString());
Console.WriteLine("Uzun zaman bilgisi "+ tarih.ToLongDateString());
#endregion

#region Zaman Biilgisi Alma
Console.WriteLine("Kısa zaman bilgisi: "+tarih.ToShortTimeString());
Console.WriteLine("Uzun zaman bilgisi: " + tarih.ToLongTimeString());


#endregion

#region Tarih Bilgisi İçerisinden Ulaşılabilecek bilgiler
#region Gün
Console.WriteLine("Gün: "+ tarih.Day);

#endregion
#region Ay
Console.WriteLine("Ay: " + tarih.Month);
#endregion
#region Yıl
Console.WriteLine("Yıl: "+ tarih.Year);
#endregion
#region Saat
Console.WriteLine("Saat: " + tarih.Hour);
#endregion
#region Dakika
Console.WriteLine("Dakika: "+tarih.Minute);
#endregion
#region Saniye
Console.WriteLine("Saniye: "+tarih.Second);
#endregion
#region Milisaniye
Console.WriteLine("Milisaniye: "+ tarih.Millisecond);
#endregion
#region Haftanın Günü
Console.WriteLine("Haftanın Günü: "+ tarih.DayOfWeek);
#endregion
#region Yılın kaçıncı günü
Console.WriteLine("Yılın kaçıncı günü: "+ tarih.DayOfYear);
#endregion

#region Artık Yıl
//DateTime.IsLeapYear metodu artık yıl bilgisini verir. Şubat ayının 29 çektiği yılda true degerini verir.
bool artikYilMi = DateTime.IsLeapYear(tarih.Year);
Console.WriteLine("Artık yıl durumu: " + (artikYilMi ? "Evet" : "Hayır"));


#endregion

#endregion

#endregion

Console.Clear();

#region Tarih Formatlama
//Tarih Formatlama karakterleri
//Formatlama biçimi ile yazdırma işlemi ToString() extension metodu ile uygulanır.

/*yyyy => uzun yıl bilgisi
*yy => kısa yıl bilgisi
*MMMM => uzun ay bilgisini verir
*MMM => Kısa ay bilgisi verir
*MM => Sayısal olarak ayı verir //01
*M => Sayısal olarak ayı verir //1
*dddd => Uzun gün adını verir
*ddd => kısa gün adını verir
*dd => Sayısal olarak günü verir //01
*d => Sayısal olarak günü verir //1
*hh => 12 saatlik dilimde saat bilgisini verir
*HH => 24 saatlik dilimde saat bilgisini verir
*mm => dakika bilgisini verir
*ss => saniye bilgisini verir
*zzz => milisaniye bilgisini verir.
*/

Console.WriteLine("Custom tarih formatı: " +tarih.ToString("dd.MM.yyyy HH:mm"));
Console.WriteLine("Custom tarih formatı: " +tarih.ToString("dd MM yyyy dddd HH:mm"));
Console.WriteLine();
Console.WriteLine("5 gün eklenmiş tarih: "+ tarih.AddDays(5));
Console.WriteLine("5 gün çıkarılmış tarih: "+ tarih.AddDays(-5));
Console.WriteLine("14 ay eklenmiş tarih: "+tarih.AddMonths(14));

Console.WriteLine("2 Yıl çıkartılmış tarih: " + tarih.AddYears(-2));
Console.WriteLine("10 saat eklenmiş tarih: "+tarih.AddHours(10));
Console.WriteLine("1250 dk çıkarılmış tarih: " + tarih.AddMinutes(-1250));
Console.WriteLine("10547854 saniye çıkarılmış tarih: " + tarih.AddSeconds(10547854));
Console.WriteLine("45684345632 milisaniye çıkarılmış tarih: "+tarih.AddMilliseconds(45684345632));







#endregion

Console.Clear();

#region Tarih Girdisi alma
//DateTime.Parse() metodu ile string ifadeleri içerisindeki degerleri tarih formatına çevirebilir, üzerinden  tarih formatında işlemler yapabilirsiniz. Aynı işlemi Convert.ToDateTime() ile de uygulayabilirsiniz.

string deger = "12.05.2022";
DateTime tarih2 = DateTime.Parse(deger);
DateTime tarih3 = Convert.ToDateTime(deger);

Console.WriteLine("Girilen tarih bilgisi: " + tarih2);
Console.WriteLine("Girilen tarih bilgisi: "+tarih3);

Console.WriteLine();

#endregion

Console.Clear();

#region Manuel olarak tarih oluşturma
//Manuel olarak tarih oluşturma
DateTime tarih4 = new DateTime(2021, 3, 15, 22, 15, 45);
Console.WriteLine("Manuel loluşturulan tarih: " + tarih4);

#endregion

Console.Clear();

#region TimeSpan()
//İki tarih arasındaki farkı gün,saat,dakika,saniye, milisaniye cinsinden hesaplamanızı sağlayan bir nesnedir.
//iki tarih bilgisi standart çıkarma işlemi yaptığınızda bu formatta bir nesne döner.

TimeSpan fark = tarih - tarih2;
//Yukarıdaki çıkarma işlemi DateTime sınfı içerisinde bulunan extension metod ile de uygulanabilmektedir.
TimeSpan fark2 = tarih.Subtract(tarih2);

Console.WriteLine(tarih + " - " + tarih2 + " arasındaki zaman farkları");
Console.WriteLine("----------------");

#region Gün farkı
Console.WriteLine("Gün farkı : "+fark.TotalDays);
#endregion
#region Saat Farkı
Console.WriteLine("Saat Farkı: "+ fark.TotalHours);
#endregion
#region Dakika Farkı
Console.WriteLine("Dakika Farkı: "+ fark.TotalMinutes);
#endregion
#region Saniye Farkı
Console.WriteLine("Saniye Farkı:"+fark.TotalSeconds);
#endregion
#region Milisaniye farkı
Console.WriteLine("Milisaniye Farkı:"+fark.TotalMilliseconds);
#endregion


#endregion



Thread.Sleep(2500);
