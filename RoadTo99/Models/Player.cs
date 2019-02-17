using System;
using System.Collections.Generic;

namespace RoadTo99.Models
{
    public partial class Player
    {
        public Player()
        {
            Highscore = new HashSet<Highscore>();
        }

        public int PlayerId { get; set; }
        public string PlayerName { get; set; }

        public ICollection<Highscore> Highscore { get; set; }
    }
}
