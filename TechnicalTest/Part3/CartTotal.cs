using System.Collections.Generic;
using System.Linq;

namespace TechnicalTest.Part3
{
    public class CartTotal : ICartTotal
    {
        public decimal Calculate(IEnumerable<Product> products, ILocalizationInfo localInfo)
        {
            if (products == null)
                return 0.0m;

            //add total of products
            var total = products.Sum(product => product.Price);

            return (total + (total * TaxRateDictionary(localInfo)));
        }

        private static decimal TaxRateDictionary(ILocalizationInfo localInfo)
        {
            var taxDictionary = new Dictionary<string, decimal>
            {
                {"us", 0.05m},
                {"ca", 0.15m}
            };
            return taxDictionary.ContainsKey(localInfo.Country) ? taxDictionary[localInfo.Country] : 0.0m;
        }
    }
}