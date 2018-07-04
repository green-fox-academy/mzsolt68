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

        public IActionResult Index(bool isActive)
        {
            if (isActive)
            {
                return View(todoRepository.ListActiveTodos());
            }
            else
            {
                return View(todoRepository.ListAllTodo());
            }
        }

        [HttpGet("Add")]
        public IActionResult AddTodo()
        {
            return View("Add");
        }

        [HttpPost("Add")]
        public IActionResult AddTodo(Todo newTodo)
        {
            todoRepository.AddTodo(newTodo);
            return RedirectToAction("Index");
        }

        [Route("{id}/delete")]
        public IActionResult DeleteTodo(int id)
        {
            todoRepository.DeleteTodo(id);
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/edit")]
        public IActionResult UpdateTodo(int id)
        {
            return View("Edit", todoRepository.GetTodo(id));
        }

        [HttpPost("{id}/edit")]
        public IActionResult UpdateTodo(Todo updatedTodo)
        {
            todoRepository.UpdateTodo(updatedTodo);
            return RedirectToAction("Index");
        }
    }
}