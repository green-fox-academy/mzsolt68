using Redditv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redditv2.Repositories
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        User GetUserByName(string name);
        void Adduser(User newUser);
        void DeleteUser(User userToDelete);
        void UpdateUser(User userToUpdate);
    }
}
