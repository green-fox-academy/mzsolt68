using FoxClub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        ITrickRepo repo;
        public string Name { get; set; }
        public List<Trick> KnownTricks { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }

        public Fox()
        {
            KnownTricks = new List<Trick>();
            repo = new TrickCenter();
        }

        public void LearnTrick(int trickID)
        {
            this.KnownTricks.Add(repo.GetTrick(trickID));
        }
    }
}
