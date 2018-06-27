using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Counter.Services;
using Microsoft.AspNetCore.Mvc;

namespace Counter.Controllers
{
    public class CounterController : Controller
    {
        private ICounter counter;

        public CounterController(ICounter counter)
        {
            this.counter = counter;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(counter.GetNumber());
        }

        [HttpPost]
        [Route("/")]
        public IActionResult AddOneNumber()
        {
            counter.Increase();
            return RedirectToAction("Index");
        }
    }
}