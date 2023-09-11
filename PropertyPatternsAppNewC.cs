namespace PropertyPatternsAppNewC
{

    public enum Cities
    {
        Vienna,
        Berlin,
        Amsterdam,
        Paris,
        Melbourne
    }

    public class City
    {
        public Cities CityName { get; set; }
        public string CountryName { get; set; }

        public City(Cities city, string country)
        {
            CityName = city;
            CountryName = country;
        }
    }
    internal class PropertyPatternsAppNewC
    {
        static void Main(string[] args)
        {
            City viennaAus = new City(Cities.Vienna, "Austria");
            City parisFr = new City(Cities.Paris, "France");
            City parisUS = new City(Cities.Paris, "USA");

            Console.WriteLine(CheckPrices(viennaAus));
            Console.WriteLine(CheckPrices(parisFr));
        }

        // aq ganvixilav fasebi rogoria
        public static string CheckPrices(City city) =>
            city switch
            {
                { CityName: Cities.Vienna } => $"{city.CityName} is Reasonable",
                { CityName: Cities.Paris, CountryName: "France" } => "Average",
                { CityName: Cities.Paris, CountryName: "USA" } => "Expensive",
                _ => "City is not covered"
            };
    }
}