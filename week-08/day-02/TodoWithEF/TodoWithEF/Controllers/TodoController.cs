using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TodoWithEF.Controllers
{
    [Route("/")]
    [Route("/list")]
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}