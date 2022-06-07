using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WeatherApp.Models
{
    public class WeatherService
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Temperature { get; set; }

        public string Humidity { get; set; }
        public string Presure { get; set; }
        public string Cloud { get; set; }
        public string Wind { get; set; }

    }
}
