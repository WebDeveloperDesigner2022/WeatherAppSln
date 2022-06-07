using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models.Service;




namespace WeatherApp.Services
{
    public class WeatherService
    {
        public async Task<Root> GetRemoteTemp()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            string response = await client.GetStringAsync("https://api.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=8a26da812093f10b480c1f41fad89c2f");

            Root temp = JsonConvert.DeserializeObject<Root>(response);

            return temp;
        }
}
}
