using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class TrickCenter : ITrickRepo
    {
        private List<Trick> tricklist;

        public TrickCenter()
        {
            tricklist = new List<Trick>()
            {
                new Trick { ID = 1, Description = "Write HTML" },
                new Trick { ID = 2, Description = "Draw foxes" },
                new Trick { ID = 3, Description = "Dance hip-hop" },
                new Trick { ID = 4, Description = "Play squash" }
            };
        }

        public List<Trick> GetTrickList()
        {
            return tricklist; ;
        }

        public Trick GetTrick(int trickID)
        {
            return tricklist.Where(t => t.ID == trickID).SingleOrDefault();
        }

    }
}
