using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTApiTest.Controllers
{
    [Produces("application/json")]
    [Route("api/Home")]
    public class HomeController : Controller
    {
        [HttpGet("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if(input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2});
            }
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if(string.IsNullOrEmpty(name))
            {
                return Json(new { error = "Please provide a name!" });
            }
            if(string.IsNullOrEmpty(title))
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult Appenda(string appendable)
        {
            if (!string.IsNullOrEmpty(appendable))
                return Json(new { appended = $"{appendable}a" });
            return NotFound();
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil(string what,[FromBody] Data until)
        {
            if (until != null)
            {
                int result = 0;
                switch (what)
                {
                    case "sum":
                        for (int i = 1; i <= until.until; i++)
                        {
                            result += i;
                        }
                        break;
                    case "factor":
                        result = 1;
                        for(int i = 1; i <= until.until; i++)
                        {
                            result *= i;
                        }
                        break;
                }
                return Json(new {result = result });
            }
            return Json(new { error = "Please provide a number!" });
        }
    }
    public class Data
    {
        public int? until;
    }
}