using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoMVC.Models;
using TodoMVC.Services;

namespace TodoMVC.Controllers
{
    public class TodoController : Controller
    {
        private TodoRepo repository;

        public TodoController(TodoRepo repo)
        {
            this.repository = repo;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(repository.GetTodos());
        }

        [HttpPost("/")]
        public IActionResult AddTodo()
        {
            return View("AddTodo");
        }

        [HttpPost("/GetTodo")]
        public IActionResult GetTodo(Todo task)
        {
            repository.AddTodo(task);
            return RedirectToAction("Index");
        }
    }
}