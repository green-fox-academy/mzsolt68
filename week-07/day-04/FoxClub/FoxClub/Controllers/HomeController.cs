using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;
using FoxClub.Services;

namespace FoxClub.Services
{
    public class HomeController : Controller
    {
        private IFoxRepo foxes;

        public HomeController(IFoxRepo repo)
        {
            this.foxes = repo;
        }

        public IActionResult Index(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return RedirectToAction("login", new {Name = name });
            }
            else
            {
                if (foxes.IsFoxExists(name))
                    return View(foxes.SelectFox(name));
                else
                    return RedirectToAction("login", new { Name = name });
            }
        }

        [HttpGet("/login")]
        public IActionResult Login(string name)
        {
            ViewData["Name"] = name;
            return View();
        }

        [HttpGet("/AddFox")]
        public IActionResult AddFox(string name)
        {
            foxes.AddFox(name);
            return RedirectToAction("Index", new {Name = name });
        }

        [HttpGet("/trickcenter")]
        public IActionResult TrickCenter(string name)
        {
            ViewData["Name"] = name;
            return View();
        }

        [HttpGet("/AddTrick")]
        public IActionResult AddTrick(string name, string trick)
        {
            foxes.LearnTrick(name, trick);
            return RedirectToAction("Index", new { Name = name });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
