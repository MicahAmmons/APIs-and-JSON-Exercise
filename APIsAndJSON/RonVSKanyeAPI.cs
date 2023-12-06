using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void KanyeQuote()
        {        // steps to call an api
                 //Client 
            HttpClient client = new HttpClient();
            // - endpoint (link) hhtps:https://api.kanye.rest/
            string endPoint = "https://api.kanye.rest/";

            //GET request 
            string kayneResponse = client.GetStringAsync(endPoint).Result;

            //Parse 
            JObject kanyeObject = JObject.Parse(kayneResponse);

            Console.WriteLine("Kanye:" + kanyeObject["quote"]);

        }

        public static void RonQuote()
        {
            HttpClient client = new HttpClient();
            string endPoint = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            string ronResponse = client.GetStringAsync(endPoint).Result;
            JArray ronObject = JArray.Parse(ronResponse);
            Console.WriteLine("Ron:" + ronObject[0]);
        }
        public static void Convo()
        {
            for (int i = 0; i <= 5; i++)
            {
                RonVSKanyeAPI.KanyeQuote();
                Console.WriteLine();
                RonVSKanyeAPI.RonQuote();
                Console.WriteLine();
            }

        }
    }
}
