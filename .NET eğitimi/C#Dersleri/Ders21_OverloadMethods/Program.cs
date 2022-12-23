using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders21_OverloadMethods
{
    internal class Program
    {
        #region Overload Methods



        #endregion


        /// <summary>
        /// Int Parametrelerin toplamını ekrana yazdırır.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        static void Toplam(int s1,int s2)
        {
            Console.WriteLine("Sayıların toplmanı: " + (s1 + s2));
        }

        /// <summary>
        /// Float sayıların toplamını ekrana yazdırır.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        static void Toplam(float s1,float s2)
        {
            Console.WriteLine("Sayıların toplamı: " + (s1 + s2));
        }

        /// <summary>
        /// Parametre olarak gönderilen 3 adet sayıyı toplar
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        static void Toplam(int s1,int s2,int s3)
        {
            Console.WriteLine("Sayıların Toplamı: " + (s1 + s2 + s3));
        }
        static void Main(string[] args)
        {

            Toplam(3, 5);
            Toplam(6.3f, 5.2f);
            Toplam(3, 5, 8);
            Console.ReadKey();
        }
    }
}
