using FoxClub.Models;
using FoxClub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class FoxCommunity : IFoxRepo
    {
        private List<Fox> foxList;
        private List<Trick> tricklist;

        public FoxCommunity()
        {
            foxList = new List<Fox>();
            tricklist = new List<Trick>()
            {
                new Trick { ID = 1, Description = "Write HTML" },
                new Trick { ID = 2, Description = "Draw foxes" },
                new Trick { ID = 3, Description = "Dance hip-hop" },
                new Trick { ID = 4, Description = "Play squash" }
            };
        }

        public void AddFox(string name)
        {
            Fox newFox = new Fox { Name = name, Food = "pizza", Drink = "lemonade" };
            foxList.Add(newFox);
        }

        public List<Trick> GetTrickList()
        {
            return tricklist; ;
        }

        public Trick GetTrick(int trickID)
        {
            return tricklist.Where(t => t.ID == trickID).SingleOrDefault();
        }

        public bool IsFoxExists(string name)
        {
            return foxList.Exists(f => f.Name == name);
        }

        public void LearnTrick(string name, int trick)
        {
            Fox fox = foxList.Where(f => f.Name == name).SingleOrDefault();
            fox.KnownTricks.Add(GetTrick(trick));
        }

        public Fox SelectFox(string name)
        {
            Fox fox = foxList.Where(f => f.Name == name).SingleOrDefault();
            return fox;
        }
    }
}
