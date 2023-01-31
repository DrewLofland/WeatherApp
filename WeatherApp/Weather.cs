using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WeatherApp
{
    public class Weather
    {
        public static double GetTemp(string weatherURL)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(weatherURL).Result;
            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
            return temp;
        }
    }
}
