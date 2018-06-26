using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba2017.Models
{
    public class BankAccount
    {
        public enum Animal
        {
            Lion, Monkey, Warthog, Meerkats, Zebra
        }
        public string Name { get; set; }
        public int Balance { get; set; }
        public Animal AnimalType { get; set; }
    }
}
