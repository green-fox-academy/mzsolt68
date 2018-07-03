using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoWithEF.Models;
using TodoWithEF.Repositories;
using TodoWithEF.Services;

namespace TodoWithEF.Controllers
{
    [Route("/")]
    [Route("/list")]
    public class TodoController : Controller
    {
        private ITodoRepository todoRepository;

        public TodoController(ITodoRepository repository)
        {
            todoRepository = repository;
        }

        public IActionResult Index()
        {
            return View(todoRepository.ListAllTodo());
        }

        [HttpPost("AddTodo")]
        public IActionResult AddTodo(Todo newTodo)
        {
            todoRepository.AddTodo(newTodo);
            return RedirectToAction("Index");
        }
    }
}