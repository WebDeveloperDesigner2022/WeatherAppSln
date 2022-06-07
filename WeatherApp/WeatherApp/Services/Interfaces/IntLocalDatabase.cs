using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Models;

namespace WeatherApp.Services.Interfaces
{
    public interface IntLocalDatabase
    {
        List<WeatherService> GetTemperature();
        void SaveTemperature(WeatherService weather);
    }
}
