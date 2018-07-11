using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Redditv2.Models;

namespace Redditv2.Repositories
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

        public void DownVote(int id)
        {
            Post votedPost = GetPostById(id);
            votedPost.Score--;
            redditContext.SaveChanges();
        }

        public Post GetPostById(int id)
        {
            return redditContext.Posts.Where(p => p.Id == id).SingleOrDefault();
        }

        public Post GetPostByTitle(string title)
        {
            return redditContext.Posts.Where(p => p.Title == title).SingleOrDefault();
        }

        public List<Post> GetPosts()
        {
            return redditContext.Posts.ToList();
        }

        public void Upvote(int id)
        {
            Post votedPost = GetPostById(id);
            votedPost.Score++;
            redditContext.SaveChanges();
        }
    }
}
