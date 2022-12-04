
#region Math Sınıfı
//   Math Sınıfı
//-----------------------
//Microsoft'un hazır olarak sunmuş olduğu bazı matematiksel işlemleri ekstra efor safetmeden hesaplamanızı sağlayan bir sınıftır. Sınıf içerisinde bulunan property ve fonksiyonlar ile bu işlemleri  gerçekleştirebilirsiniz.
//Math. işleminden sonra property veya fonksiyonlara ulaşım sağlayabilirsiniz.

#region PI Sayisi
//PI sayısını veren property'dir. Bu property sadece okunabilir özelliğe sahiptir. Yeni ir deger ataması yapılamaz.
Console.WriteLine("PI Sayisi: "+ Math.PI);

#endregion

#region E Sayisi(ELen)
//E sayısını veren property'dir. Bu property sadece okunabilir özelliğe sahiptir. Yeni bir deger ataması yapılamaz.
Console.WriteLine("E sayisi: "+Math.E);

#endregion

#region Abs(x)
//Parametre olarak verilen degerin mutlak degrini hesaplayıp geri döndürür.
Console.WriteLine("-5 sayısının mutlak degeri: " + Math.Abs(-5));

#endregion

#region Floor(x)
//Parametre olarak verilen ondalık değeri alt tam sayıya yuvarlar.
Console.WriteLine("12.98 sayısının alt tam sayısıya yuvarlanmış hali: " + Math.Floor(12.98));

#endregion

#region Ceiling(x)
//Parametre olarak verilen ondalık değeri üst tam sayıya yuvarlar.
Console.WriteLine("12.5 sayısının üst sayıya yuvarlanmış degeri: " + Math.Round(12.5));

#endregion

#region Round(x)
//parametre olarak verilen ondalık degeri standart olarak yuvarlama işlemini yapar.
Console.WriteLine("15.5 sayısının yuvarlanmış hali : "+ Math.Round(12.5));
#endregion

#region Truncate(x)
//Parametre olarak verilen ondalık degerin ondalık kısmını atar. Geriye tam sayı değerini veriri.
Console.WriteLine("12.65 sayısının  tam sayı hali: "+Math.Truncate(12.65));
#endregion

#region Max(x,y)
//Parametre olarak verilen iki egern en büyüğü olanını geriye döndürür.
Console.WriteLine("14 ile 24.5 sayılarının büyüğü: " + Math.Max(14, 24.5));
#endregion

#region Min(x,y)
//parametre olarak verilen iki sayıdan küçük olanını verir.
Console.WriteLine("14 ile 24.5 sayılarının küçüğü: " + Math.Min(14, 24.5));

#endregion

#region Pow(x,y)
//Parametere olarak iki adet deger alır. İlk deger hangisi sayının kuvveti alınacağı, ikinci parametre kaçıncı kuvvetinin alınacağını belirtir.
Console.WriteLine("5 syısının 3. kuvveti: ",Math.Pow(5,3));
#endregion

#region Squart(x)
//Parametre olarak verilen degerin karakökünü hesaplar
Console.WriteLine("9 sayısının karekökü: ", Math.Sqrt(9));
#endregion

#region Sing(x)
//Parametre olarak verilen sayının negatif, pozitif ya da sıfır(0) 'a eğişt olup olmadığının bilgisini verir.
//Negatif ise -1, pozitif ise 1, sıfıra eşit ise 0 degerini döndürür.
Console.WriteLine("-25 sayısının durumu: "+Math.Sign(-25));
int durum = Math.Sign(-25);
if (durum==0)
{
    Console.WriteLine("Sıfıra eşit");
}
else if (durum == -1)
{
    Console.WriteLine("Sayı Negatif.");
}
else
{
    Console.WriteLine("Sayı pozitif.");
}
#endregion

#endregion

Console.Clear();

#region Ornek
//Kullanıcıdan 3 adet sayı talep edelim.
//En büyük olan sayıyı ve en büyük küçük sayıyı ekrana yazdıralım
Console.WriteLine("3 Adet Sayi giriniz");
Console.Write("1. Sayiyı giriniz: ");
int sayi1=int.Parse(Console.ReadLine());
Console.Write("2. sayiyi giriniz: ");
int sayi2 =int.Parse(Console.ReadLine()); 
Console.Write("3. sayiyi giriniz: ");
int sayi3 =int.Parse(Console.ReadLine());

Console.Write("Girilen en küçük sayi: " + Math.Min(Math.Min(sayi1, sayi2), sayi3));
Console.Write("\nGirilen en büyük sayi: " + Math.Max(sayi1, Math.Max(sayi2, sayi3)));




#endregion

Thread.Sleep(5000);