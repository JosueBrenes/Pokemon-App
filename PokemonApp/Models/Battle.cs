using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonApp.Models
{
    public class Battle
    {
        public int Id { get; set; }
        public int ChallengeId { get; set; }
        public Challenge Challenge { get; set; }
        public string OpponentName { get; set; }
        public int RewardPoints { get; set; }
        public bool IsCompleted { get; set; }
    }

}