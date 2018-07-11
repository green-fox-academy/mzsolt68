using System;
using Microsoft.AspNetCore.Mvc;
using Redditv2.Models;
using Redditv2.Repositories;

namespace Redditv2.Controllers
{
    [Produces("application/json")]
    [Route("/posts")]
    public class PostController : Controller
    {
        private IPostRepository postRepository;

        public PostController(IPostRepository repository)
        {
            postRepository = repository;
        }

        [HttpGet]
        public IActionResult GetPosts()
        {
            return Json(new { posts = postRepository.GetPosts() });
        }

        [HttpPost]
        public IActionResult AddPost([FromBody]Post newPost)
        {
            newPost.Timestamp = Math.Round((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds).ToString();
            postRepository.AddPost(newPost);
            newPost = postRepository.GetPostByTitle(newPost.Title);
            return Json(newPost);
        }

        [HttpPut("/posts/{id}/upvote")]
        public IActionResult Upvote(int id)
        {
            postRepository.Upvote(id);
            return Json(postRepository.GetPostById(id));
        }

        [HttpPut("/posts/{id}/downvote")]
        public IActionResult DownVote(int id)
        {
            postRepository.DownVote(id);
            return Json(postRepository.GetPostById(id));
        }
    }
}