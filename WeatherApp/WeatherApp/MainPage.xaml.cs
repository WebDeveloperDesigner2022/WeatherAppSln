using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models.Service;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;  
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await GetWeatherData();
        }

        public async Task<Root> GetWeatherData()
        {

            //var location = await Gcolocation.

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            string response = await client.GetStringAsync("https://api.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=8a26da812093f10b480c1f41fad89c2f");

            Root temp = JsonConvert.DeserializeObject<Root>(response);

            return temp;
        }
    }
}
