using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;

namespace FoxClub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return RedirectToAction("login");
            }
            else
            {
                return View();
            }
        }

        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost("/")]
        //public IActionResult Index(string Name)
        //{
        //    return View();
        //}

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
