using DadJokesApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DadJokesApp
{
    
    public class DadJokeDatabase
    {

        private SQLiteConnection _database;

        public  static DadJokeDatabase Instance = new DadJokeDatabase();

        public DadJokeDatabase()
        {
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = path + "joke.db";
            _database = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache);

            _database.CreateTable<DadJoke>();
        }

        public List<DadJoke> GetJokes()
        {
            return _database.Table<DadJoke>().OrderByDescending(x => x.JokeDate).ToList();
        }

        public void SaveDateJoke(DadJoke joke)
        {
            _database.Insert(joke);
        }

    }
}
