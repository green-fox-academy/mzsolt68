using Redditv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redditv2.Services
{
    public interface IRedditService
    {
        void AddPost(Post newPost, string userName);
        void UpvotePost(int postId, string userName);
        void DownvotePost(int postId, string userName);
        IEnumerable<Post> GetPosts();
        Post GetPostById(int id);
        Post GetPostByTitle(string title);
    }
}
