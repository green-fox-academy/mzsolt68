using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloneReddit.Models;
using CloneReddit.Repositories;

namespace CloneReddit.Services
{
    public class RedditRepository : IRedditRepo
    {
        private RedditContext redditContext;

        public RedditRepository(RedditContext context)
        {
            this.redditContext = context;
        }

        public void AddPost(Post newPost)
        {
            redditContext.Posts.Add(newPost);
            redditContext.SaveChanges();
        }

        public void DownVote(Post votedPost)
        {
            votedPost.Votes--;
            redditContext.SaveChanges();
        }

        public Post GetPost(int postId)
        {
            return redditContext.Posts.Where(p => p.Id == postId).SingleOrDefault();
        }

        public void Upvote(Post votedPost)
        {
            votedPost.Votes++;
            redditContext.SaveChanges();
        }
    }
}
