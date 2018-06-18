using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxes = new List<Fox>
            {
                new Fox { Name = "Vuk", Type = "Vulpes vulpes", Color = "Red" },
                new Fox { Name = "Zelda", Type = "Vulpes corsac", Color = "Grey" },
                new Fox { Name = "Karak", Type = "Vulpes pallida", Color = "Green" },
                new Fox { Name = "Vadim", Type = "Vulpes zerda", Color = "Yellow" },
                new Fox { Name = "Fred", Type = "Vulpes pallida", Color = "Brown" },
                new Fox {Name = "Ginger", Type ="Vulpes zerda", Color = "Green" }
            };

            var greenFoxes = foxes.Where(fox => fox.Color == "Green");
            var greenPallidas = foxes.Where(fox => fox.Type.Contains("pallida") && fox.Color == "Green");

            Console.WriteLine("Green foxes:");
            foreach (var fox in greenFoxes)
            {
                Console.WriteLine($"{fox.Name} color is {fox.Color}");
            }
            Console.WriteLine("\nGreen pallidas:");
            foreach (var fox in greenPallidas)
            {
                Console.WriteLine($"{fox.Name} type is {fox.Type} and has color of {fox.Color}");
            }
            Console.ReadLine();
        }
    }
}
