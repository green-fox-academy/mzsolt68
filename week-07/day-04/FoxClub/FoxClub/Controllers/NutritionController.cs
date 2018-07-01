using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace FoxClub.Controllers
{
    public class NutritionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/NutritionStore")]
        public IActionResult NutritionStore(string name)
        {
            ViewData["Name"] = name;
            return View();
        }

        [HttpGet("/AddNutrition")]
        public IActionResult AddNutrition(string name, string food, string drink)
        {
            RouteValueDictionary dict = new RouteValueDictionary();
            dict.Add("name", name);
            dict.Add("food", food);
            dict.Add("drink", drink);
            return RedirectToAction("ChangeNutrition", "Home", dict);
        }
    }
}