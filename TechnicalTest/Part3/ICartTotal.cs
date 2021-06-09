using System.Collections.Generic;

namespace TechnicalTest.Part3
{
    public interface ICartTotal
    {
        decimal Calculate(IEnumerable<Product> products, ILocalizationInfo localInfo);
    }
}
