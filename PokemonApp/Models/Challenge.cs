using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonApp.Models
{
    public class Challenge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Battle> Battles { get; set; } = new List<Battle>();
    }

}