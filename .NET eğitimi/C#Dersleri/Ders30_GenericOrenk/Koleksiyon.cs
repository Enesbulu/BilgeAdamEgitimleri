using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_GenericOrenk
{
    internal class Koleksiyon<T>
    {
        List<T> list;
        public Koleksiyon() 
        {
            list = new List<T>();
        }

        public void Ekle(T veri)
        {
            list.Add(veri);
        }
        public void Ekle(params T[] veriler)
        {
            foreach (T veri in veriler) 
            {
                list.Add(veri);
            }
        }

        public void Sil(int index)
        {
            list.RemoveAt(index);
        }
        public void Sil(int[] indexs)
        {
            foreach (var item in indexs)
            {
                list.RemoveAt(item);
            }
        }

        internal void ArayaEkle(T[] girilenSayılar, int? baslangicIndex = null)   //? işareti belirtilen deger boş bırakılabilir anlamına gelir.// Nullable<int> da anlama gelir.
        {
            List<T> gecici = new List<T>();
            if (baslangicIndex == null) 
            {
                Ekle(girilenSayılar);
            }
            else
            {
                for (int i = 0; i < ElemanSayisi; i++)
                {
                    if (i == baslangicIndex)
                    {
                        gecici.AddRange(girilenSayılar);
                    }
                    gecici.Add(list[i]);
                   
                }
                list = gecici;
            }
        }

        internal void Yazdır()
        {
            foreach (var sayi in list)
            {
                Console.Write( sayi +" ");
            }
            Console.WriteLine();
        }

        public int ElemanSayisi => list.Count;
    }
}
