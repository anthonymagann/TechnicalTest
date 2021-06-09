namespace TechnicalTest.Part3
{
    public class LocalizationInfo : ILocalizationInfo
    {
        public LocalizationInfo(string country = "us")
        {
            Country = country;
        }

        public string Country { get; }
    }
}