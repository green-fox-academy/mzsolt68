using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Redditv2.Models;
using Redditv2.Repositories;

namespace Redditv2.Services
{
    public class PostRepository : IPostRepository
    {
        private RedditDbContext redditContext;

        public PostRepository(RedditDbContext context)
        {
            redditContext = context;
        }

        public void AddPost(Post newPost)
        {
            redditContext.Posts.Add(newPost);
            redditContext.SaveChanges();
        }

        public void DownVote(Post votedPost)
        {
            votedPost.Score--;
            redditContext.SaveChanges();
        }

        public Post GetPost(int id)
        {
            return redditContext.Posts.Where(p => p.Id == id).SingleOrDefault();
        }

        public List<Post> GetPosts()
        {
            return redditContext.Posts.ToList();
        }

        public void Upvote(Post votedPost)
        {
            votedPost.Score++;
            redditContext.SaveChanges();
        }
    }
}
