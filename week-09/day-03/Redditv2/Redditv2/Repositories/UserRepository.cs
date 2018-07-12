using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Redditv2.Models;

namespace Redditv2.Repositories
{
    public class UserRepository : IUserRepository
    {
        private RedditDbContext redditContext;

        public UserRepository(RedditDbContext context)
        {
            redditContext = context;
        }
        public void Adduser(string userName)
        {
            redditContext.Users.Add(new User {UserName = userName });
            redditContext.SaveChanges();
        }

        public void DeleteUser(User userToDelete)
        {
            redditContext.Users.Remove(userToDelete);
            redditContext.SaveChanges();
        }

        public User GetUserById(int id)
        {
            return redditContext.Users.Where(u => u.Id == id).SingleOrDefault();
        }

        public User GetUserByName(string name)
        {
            return redditContext.Users.Where(u => u.UserName == name).SingleOrDefault();
        }

        public bool IsUserExists(string userName)
        {
            User tmp = GetUserByName(userName);
            if (tmp != null)
                return true;
            else
                return false;
        }

        public void UpdateUser(User userToUpdate)
        {
            redditContext.Users.Update(userToUpdate);
            redditContext.SaveChanges();
        }
    }
}
