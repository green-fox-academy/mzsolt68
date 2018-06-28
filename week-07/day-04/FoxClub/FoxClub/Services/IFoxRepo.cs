using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public interface IFoxRepo
    {
        Fox SelectFox(string name);
        bool IsFoxExists(string name);
        void AddFox(string name);
    }
}
