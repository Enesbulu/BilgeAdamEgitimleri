using LinqToQuery.Model.Abstract;
using System.Globalization;

namespace LinqToQuery.Model.Extensions
{
    internal static class Convertions
    {
        public static string GetStatu(this StatusType type)
        {
            string txt = string.Empty;
            switch (type)
            {
                case StatusType.Active:
                    return "Aktif";
                case StatusType.Passive:
                    return "Pasif";
                default:
                    return "Belirtilmedi.";
            }

        }

        /// <summary>
        /// Kültür bilgisine göre ülke para birimini yazdırma.
        /// </summary>
        /// <param name="price"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string ToCurrency(this decimal price, string culture = "en-US")
        {
            return price.ToString("C", new CultureInfo(culture)); 
        }
    }
}
