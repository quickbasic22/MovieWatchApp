using SQLite;
using System;
using System.Collections.Generic;

namespace ConsoleStartup.Models
{
    public class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Released { get; set; }
        public List<MovieDetails> MovieDetails { get; set; }
        public List<Actor> Actors { get; set; }
    }
}