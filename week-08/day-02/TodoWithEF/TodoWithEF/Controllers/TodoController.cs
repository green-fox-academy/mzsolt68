using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoWithEF.Models;
using TodoWithEF.Repositories;
using TodoWithEF.Services;
using TodoWithEF.ViewModels;

namespace TodoWithEF.Controllers
{
    [Route("/")]
    [Route("/list")]
    public class TodoController : Controller
    {
        private ITodoRepository todoRepository;
        private IAssigneeRepository assigneeRepository;
        private TodoAssigneeVM TodoAssigneeVM;

        public TodoController(ITodoRepository todoRepo, IAssigneeRepository assigneeRepo)
        {
            todoRepository = todoRepo;
            assigneeRepository = assigneeRepo;
            TodoAssigneeVM = new TodoAssigneeVM();
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
            TodoAssigneeVM.Todo = todoRepository.GetTodo(id);
            TodoAssigneeVM.Assignees = assigneeRepository.ListAllAssignees();
            return View("Edit", TodoAssigneeVM);
        }

        [HttpPost("{id}/edit")]
        public IActionResult UpdateTodo(TodoAssigneeVM model)
        {
            todoRepository.UpdateTodo(model.Todo);
            return RedirectToAction("Index");
        }
    }
}