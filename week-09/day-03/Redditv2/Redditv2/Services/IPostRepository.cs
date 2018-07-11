using Redditv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redditv2.Services
{
    public interface IPostRepository
    {
        List<Post> GetPosts();
        void AddPost(Post newPost);
        void Upvote(Post votedPost);
        void DownVote(Post votedPost);
        Post GetPost(int id);

    }
}
