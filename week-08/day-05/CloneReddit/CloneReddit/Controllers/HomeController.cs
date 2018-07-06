using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CloneReddit.Models;
using CloneReddit.Services;

namespace CloneReddit.Controllers
{
    public class HomeController : Controller
    {
        private IRedditRepo redditRepository;

        public HomeController(IRedditRepo repo)
        {
            redditRepository = repo;
        }

        public IActionResult Index()
        {
            return View(redditRepository.GetAllPost());
        }

        [Route("Up/{id}")]
        public IActionResult UpVote(int id)
        {
            Post votedPost = redditRepository.GetPost(id);
            redditRepository.Upvote(votedPost);
            return RedirectToAction("Index");
        }

        [Route("Down/{id}")]
        public IActionResult DownVote(int id)
        {
            Post votedPost = redditRepository.GetPost(id);
            redditRepository.DownVote(votedPost);
            return RedirectToAction("Index");
        }
    }
}
