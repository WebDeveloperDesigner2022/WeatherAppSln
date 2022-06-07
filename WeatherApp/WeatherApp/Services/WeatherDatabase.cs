using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Services;
using WeatherApp.Services.Interfaces;
using SQLite;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherDatabase : IntLocalDatabase
    {
        private SQLiteConnection _database;

        public WeatherDatabase()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = path + "weatherService.db";

            _database = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            _database.CreateTable<WeatherService>();


        }

        List<WeatherService> GetTemperature()
        {
            return _database.Table<WeatherService>().OrderByDescending(x => x.Temperature).ToList();
        }

        public void SaveTemperature(WeatherService temp)
        {
            _database.Insert(temp);
        }
    }
}
