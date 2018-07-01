using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;
using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace FoxClub.Controllers
{
    public class TrickController : Controller
    {
        ITrickRepo tricks;

        public TrickController(ITrickRepo trickRepo)
        {
            tricks = trickRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Trickcenter")]
        public IActionResult Trickcenter(string name)
        {
            ViewData["Name"] = name;
            return View(tricks.GetTrickList());
        }

        [HttpGet("/AddTrick")]
        public IActionResult AddTrick(string name, int trick)
        {
            RouteValueDictionary dict = new RouteValueDictionary();
            dict.Add("name", name);
            dict.Add("newtrick", trick);
            return RedirectToAction("AddTrickTo", "Home", dict);
        }

    }
}