using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Counter.Controllers
{
    public class CounterController : Controller
    {
        private int number = 0;

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(number);
        }

        [HttpPost]
        [Route("/")]
        public IActionResult AddOneNumber()
        {
            number++;
            return RedirectToAction("Index");
        }
    }
}