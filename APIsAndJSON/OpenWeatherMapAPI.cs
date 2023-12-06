using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void GetWeather()
        {
            Console.WriteLine("Pick a City");
            HttpClient client = new HttpClient();
            string city = Console.ReadLine();
            string endPoint = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=a309632b9e81d1e5db78633cd6f73ec5&units=imperial";
            string weatherInfo = client.GetStringAsync(endPoint).Result;
            JObject weatherObject = JObject.Parse(weatherInfo) ;
            Console.WriteLine(weatherObject["main"]["temp"]);
        }
    }
}
//endpoint https://api.openweathermap.org/data/2.5/weather?q={city name}&appid={API key}&units=imperial