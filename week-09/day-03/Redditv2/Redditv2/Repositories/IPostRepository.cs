using Redditv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redditv2.Repositories
{
    public interface IPostRepository
    {
        List<Post> GetPosts();
        void AddPost(Post newPost);
        void Upvote(int id);
        void DownVote(int id);
        Post GetPostById(int id);
        Post GetPostByTitle(string title);
    }
}
