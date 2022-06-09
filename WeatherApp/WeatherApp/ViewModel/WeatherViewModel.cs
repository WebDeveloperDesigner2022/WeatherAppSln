using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models.Service;
using WeatherApp.Services;

namespace WeatherApp.ViewModel
{
    public class WeatherViewModel
    {
        private IList<WeatherServiceData> _weatherList;
        public IList<WeatherServiceData> WeatherList
        {
            get
            {
                if (_weatherList == null)
                    _weatherList = new ObservableCollection<WeatherServiceData>();
                return _weatherList;
            }
            set
            {
                _weatherList = value;
            }

        }
        public async Task APIAsync()
        {
            WeatherService weatherService = new WeatherService();
            var weather = await weatherService.GetWeatherData();
            WeatherList.Add(weather);
        }       
    }
}
