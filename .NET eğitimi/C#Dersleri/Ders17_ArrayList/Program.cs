//// See https://aka.ms/new-console-template for more information
#region ArrayList 
//Uygbulama içerisinde şuana dek gördüğümüz arraylerin en büyük özelliği tip bağımllılığı  ve eleman sayısı zorunluluğudur.
//ArrayList bu iki yapıdan bağımsız olarak çalışmaktadır.
//Yeni bir ArrayList tanımlama işlemi esnasında içerisinde barındırılacağı tip ve elemean sayısı belirtilmez.
//ArrayList içerisine her türlü  veri aktarımı yapılabilir.Fakat en büyük dez avantajı, koleksiyon içerisine eklenen veriler otomatik olarak object t,p,ne döner.Verilerin üzerinde işlem yapmak için ayriyeten tür dönüşümğne ihtiyaç duyarız. bu da iki kat is yapmak demektir.
//Uygulama içerisinde ArrayList ler ile işlem yapmak için using system.collections; ibaresini uygulama içerisine eklemeniz gerekmektedir.

//Syntax
//-----------
//ArrayList <degiskenAdi> = new ArraList();
//ArrayList <degiskenAdi> = new ArrayList(<elemanSayisi>);
#endregion

using System.Collections;

ArrayList arrayList= new ArrayList();
#region Properties
//ArrayList içerisinde  kullanılan metodlar:
//--------------
#region Add()
//Add() => öge ekleme
arrayList.Add("BilgeAdam");
arrayList.Add(145);
arrayList.Add(true);
arrayList.Add(34.5);
arrayList.Add(new int[] { 45, 48, 85, 78, 17, 1 });
arrayList.Add("istanbul");
arrayList.Add("izmir");

foreach (var item in arrayList)
{
	if (item is int[])
	{
		var array = item as int[];	//(int[])item; 
		foreach (var sayi in array)
		{
			Console.Write(sayi+ " ");
		}
		Console.WriteLine();
	}
	else
	{
		Console.WriteLine(item);
	}
}
#endregion

#region Count()
//Count() => Eleman Sayisinı öğrenme
Console.WriteLine("\nEleman sayisi: " + arrayList.Count);

#endregion

#region Remove()
//Remove() => eleman silmek 
arrayList.Remove("İzmir");
foreach (var item in arrayList)
{
    if (item is int[])
    {
        var array = item as int[];  //(int[])item; 
        foreach (var sayi in array)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine(item);
    }
}
#endregion

#region RemovAt()
//RemoveAt() => İndex numarasına göre eleman girmek
arrayList.RemoveAt(4);

foreach (var item in arrayList)
{
    if (item is int[])
    {
        var array = item as int[];  //(int[])item; 
        foreach (var sayi in array)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine(item);
    }
}
#endregion

#region Contains()
//Contains() => koleksiyon içerisinde var mı?(boolean)
if (arrayList.Contains("BilgeAdam"))
{
    Console.WriteLine("Aranan Deger Var");
}
else
{
    Console.WriteLine("\nAranan deger bulunamadı.");
}

#endregion


#region Insert()
//Insert() => koleksiyon içerisinde belirtilen index eyeni deger eklemek için kullanılır.


#endregion

#region Sort()
//Sort() => Sıralama yapma
//Sadece Aynı türden verilerin olduğu durumda sıralama yapabilir!

#endregion

#region Revorse()
//Reverse() => Tersten sıralama yapar
//Sadece Aynı türden verilerin olduğu durumda sıralama yapabilir!

#endregion

#region Clear()
//Clear() => koleksiyon içerisindeki tüm elemanları silmek için kullanılır.

#endregion

#region TrimTpSize()
//TriToSize() => koleksiyon kapasitesini o anki eleman sayısına eşit olarak boyutunu sınırlar
//arrayList.TrimToSize
#endregion


Thread.Sleep(2500);
#endregion

