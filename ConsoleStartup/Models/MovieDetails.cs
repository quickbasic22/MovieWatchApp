using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SQLite;

namespace ConsoleStartup.Models
{
    public class MovieDetails
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Liked { get; set; }
        public DateTime Watched { get; set; }
        [ForeignKey("Movies")]
        public int MovieId { get; set; }
        public Movie Movies { get; set; }
        [ForeignKey("Actors")]
        public int ActorId { get; set; }
        public Actor Actors { get; set; }
    }
}
