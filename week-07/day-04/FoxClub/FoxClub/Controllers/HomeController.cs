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

        public IActionResult Index(string name, int trick)
        {
            if (string.IsNullOrEmpty(name))
            {
                return RedirectToAction("login");
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

        public IActionResult AddTrickTo(string name, int newtrick)
        {
            Fox fox = foxes.SelectFox(name);
            fox.LearnTrick(newtrick);
            return RedirectToAction("Index", new { Name = fox.Name });
        }

        public IActionResult ChangeNutrition(string name, string food, string drink)
        {
            Fox fox = foxes.SelectFox(name);
            fox.Food = food;
            fox.Drink = drink;
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
