using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorio(6));

            Console.ReadKey();
        }

        static int Factorio(int number)
        {
            int tmp = 1;
            for (int i = 1; i <= number; i++)
                tmp *= i;
            return tmp;
        }
    }
}
