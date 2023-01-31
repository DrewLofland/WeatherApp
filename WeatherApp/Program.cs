using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var key = File.ReadAllText("appsettings.json");
            var APIKey = JObject.Parse(key).GetValue("APIKey");

            Console.WriteLine("Please enter your zip code");
            var zipCode = Console.ReadLine();

            var weatherURL = $"http://api.openweathermap.org/data/2.5/weather?units=imperial&appid={APIKey}&zip={zipCode}";


            Console.WriteLine($"It is currently {Weather.GetTemp(weatherURL)} degrees F in your location");
        }
    }
}