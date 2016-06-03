using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WeatherStation
{
    class Api
    {
        //Fields API key and client
        public static HttpClient Client = new HttpClient();
        private const string ApiKey = "&APPID=70436b8b887b432a3c07a06f53abae1c";

        /// <summary>
        /// Gets the Json data from the API and returns this into a JObject
        /// </summary>
        /// <param name="city">Sets the city for the program</param>
        /// <returns></returns>
        public dynamic ApiCall(string location)
        {
            //get properties out of settings
            string setUnints = Properties.Settings.Default.Units;
            string setCity;
            if (location == null)
            {
                setCity = Properties.Settings.Default.City;
            }
            else
            {
                setCity = location;
            }
            //Make Api Url
            string baseUrl = "http://api.openweathermap.org/data/2.5/weather?q=";
            string lang = "&lang=nl";
            string units = "&units=" + setUnints;
            Uri url = new Uri(baseUrl + setCity + lang + units + ApiKey);

            //Get the Json from Api
            Task<HttpResponseMessage> response = Client.GetAsync(url);
            String resp = response.Result.Content.ReadAsStringAsync().Result;

            //Return json object
            return JObject.Parse(resp);
        }
    }
}
