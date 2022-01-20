using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Movies.Models
{
    public class Actor
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Actor")]
        public int ActorId { get; set; }
        public Actor Actors { get; set; }
    }
}
