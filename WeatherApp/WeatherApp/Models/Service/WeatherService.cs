using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Models.Service
{
    public class Weather
    {
        public int id { get; set; }
        public string temperature { get; set; }

        public string humidity { get; set; }
        public string presure { get; set; }
        public string cloud { get; set; }
        public string wind { get; set; }
    }
}
