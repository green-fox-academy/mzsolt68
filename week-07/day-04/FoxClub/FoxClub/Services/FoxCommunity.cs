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

        public FoxCommunity()
        {
            foxList = new List<Fox>();
        }

        public void AddFox(string name)
        {
            Fox newFox = new Fox { Name = name, Food = "pizza", Drink = "lemonade" };
            foxList.Add(newFox);
        }

        public bool IsFoxExists(string name)
        {
            return foxList.Exists(f => f.Name == name);
        }

        public Fox SelectFox(string name)
        {
            Fox fox = foxList.Where(f => f.Name == name).SingleOrDefault();
            return fox;
        }
    }
}
