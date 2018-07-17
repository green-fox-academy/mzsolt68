using System;
using Microsoft.AspNetCore.Mvc;
using Redditv2.Models;
using Redditv2.Repositories;
using Redditv2.Services;

namespace Redditv2.Controllers
{
    [Produces("application/json")]
    [Route("/posts")]
    public class PostController : Controller
    {
        private IRedditService service;

        public PostController(IRedditService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetPosts()
        {
            return Json(new { posts = service.GetPosts() });
        }

        [HttpPost]
        public IActionResult AddPost([FromBody]Post newPost)
        {
            service.AddPost(newPost, Request.Headers["User"]);
            //newPost = service.GetPostByTitle(newPost.Title);
            return Json(service.GetPostByTitle(newPost.Title));
        }

        //[HttpPut("/posts/{id}/upvote")]
        //public IActionResult Upvote(int id)
        //{
        //    postRepository.Upvote(id);
        //    return Json(postRepository.GetPostById(id));
        //}

        //[HttpPut("/posts/{id}/downvote")]
        //public IActionResult DownVote(int id)
        //{
        //    postRepository.DownVote(id);
        //    return Json(postRepository.GetPostById(id));
        //}
    }
}