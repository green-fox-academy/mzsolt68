using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Services
{
    public class CounterService : ICounter
    {
        private int Clicks = 0;

        public int GetNUmber()
        {
            return Clicks;
        }

        public void Increase()
        {
            Clicks++;
        }
    }
}
