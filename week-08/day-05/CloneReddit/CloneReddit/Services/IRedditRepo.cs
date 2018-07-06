using CloneReddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneReddit.Services
{
    public interface IRedditRepo
    {
        void AddPost(Post newPost);
        void Upvote(Post votedPost);
        void DownVote(Post votedPost);
        Post GetPost(int postId);
        List<Post> GetAllPost();
    }
}
