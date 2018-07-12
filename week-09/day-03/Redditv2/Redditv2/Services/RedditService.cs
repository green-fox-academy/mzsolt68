using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Redditv2.Models;
using Redditv2.Repositories;

namespace Redditv2.Services
{
    public class RedditService : IRedditService
    {
        private RedditDbContext redditContext;
        private IPostRepository postRepo;
        private IUserRepository userRepo;

        public RedditService(RedditDbContext context)
        {
            redditContext = context;
            postRepo = new PostRepository(redditContext);
            userRepo = new UserRepository(redditContext);
        }

        public void AddPost(Post newPost, string userName)
        {
            if(!string.IsNullOrEmpty(userName))
            {
                if(!userRepo.IsUserExists(userName))
                {
                    userRepo.Adduser(userName);
                }
                newPost.User = userRepo.GetUserByName(userName);
            }
            postRepo.AddPost(newPost);
        }

        public void DownvotePost(int postId, string userName)
        {
            throw new NotImplementedException();
        }

        public Post GetPostById(int id)
        {
            return postRepo.GetPostById(id);
        }

        public Post GetPostByTitle(string title)
        {
            return postRepo.GetPostByTitle(title);
        }

        public IEnumerable<Post> GetPosts()
        {
            return postRepo.GetPosts();
        }

        public void UpvotePost(int postId, string userName)
        {
            throw new NotImplementedException();
        }
    }
}
