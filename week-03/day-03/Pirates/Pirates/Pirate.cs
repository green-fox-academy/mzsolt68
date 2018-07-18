using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    public class Pirate
    {
        public static Random rnd = new Random();
        public bool IsAlive { get; set; }
        public bool IsAwake { get; set; }
        public string Name { get; set; }
        private int rumDrinked;

        public Pirate(string name)
        {
            Name = name;
            rumDrinked = 0;
            IsAlive = true;
            IsAwake = true;
        }

        public string DrinkSomeRum()
        {
            if (IsAlive)
            {
                rumDrinked++;
                return "Thanks, mate!";
            }
            else
            {
                return "He's dead!";
            }
        }

        public string HowsItGoingMate()
        {
            if (IsAlive)
            {
                if (rumDrinked < 5)
                {
                    return "Pour me anudder!";
                }
                else
                {
                    IsAwake = false;
                    return "Arghh, I'ma Pirate. How d'ya d'ink its goin?";
                }
            }
            else
            {
                return "He's dead!";
            }
        }

        public void Die()
        {
            IsAlive = false;
        }

        public string Brawl(Pirate enemy)
        {
            if (enemy.IsAlive)
            {
                switch (rnd.Next(0, 3))
                {
                    case 0:
                        this.IsAlive = false;
                        return $"{this.Name} died!";
                    case 1:
                        enemy.IsAlive = false;
                        return $"{enemy.Name} died!";
                    case 2:
                        this.IsAlive = false;
                        enemy.IsAlive = false;
                        return "Both pirates died!";
                }
            }
            return $"{enemy.Name} is dead already!";
        }
    }
}
