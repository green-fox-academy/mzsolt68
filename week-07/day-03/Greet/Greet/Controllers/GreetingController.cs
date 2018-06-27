using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Greet.Controllers
{
    public class GreetingController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Greet()
        {
            return RedirectToAction("Greeting");
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greeting()
        {
            return View();
        }
    }
}