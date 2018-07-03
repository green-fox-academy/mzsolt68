using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoWithEF.Services;

namespace TodoWithEF.Controllers
{
    [Route("/")]
    [Route("/list")]
    public class TodoController : Controller
    {
        TodoRepository todoRepository;

        public TodoController(TodoRepository repository)
        {
            todoRepository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}