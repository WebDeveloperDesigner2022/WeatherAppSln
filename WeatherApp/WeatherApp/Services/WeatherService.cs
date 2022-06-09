using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models.Service;
using Xamarin.Essentials;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        public async Task<WeatherServiceData> GetWeatherData()
        {

            var data = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
            if (data != PermissionStatus.Granted)
            {
                var newdata = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            }
            var location = await Geolocation.GetLocationAsync();
            var latitude = location.Latitude;
            var longitude = location.Longitude;

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            string url = $"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&units=metric&appid=8a26da812093f10b480c1f41fad89c2f";
            var response = await client.GetStringAsync(url);


            var temp = JsonConvert.DeserializeObject<WeatherServiceData>(response);

            return temp;
        }
    }
}
