using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Greet.Services;
using Microsoft.AspNetCore.Mvc;

namespace Greet.Controllers
{
    public class GreetingController : Controller
    {
        private Person person;

        public GreetingController(Person person)
        {
            this.person = person;
        }
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Greet(string name)
        {
            person.Name = name;
            return RedirectToAction("Greeting");
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greeting()
        {

            return View(person);
        }
    }
}