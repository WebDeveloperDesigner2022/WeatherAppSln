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
        private IList<WeatherServices> _weatherList;
        public IList<WeatherServices> WeatherList
        {
            get
            {
                if (_weatherList == null)
                    _weatherList = new ObservableCollection<WeatherServices>();
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
