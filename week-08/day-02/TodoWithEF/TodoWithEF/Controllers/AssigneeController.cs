using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoWithEF.Models;
using TodoWithEF.Services;

namespace TodoWithEF.Controllers
{
    [Route("Assignee")]
    public class AssigneeController : Controller
    {
        private IAssigneeRepository assigneeRepository;

        public AssigneeController(IAssigneeRepository repository)
        {
            assigneeRepository = repository;
        }

        public IActionResult Index()
        {
            return View(assigneeRepository.ListAllAssignees());
        }

        [HttpGet("Add")]
        public IActionResult AddAssignee()
        {
            return View("Add");
        }

        [HttpPost("Add")]
        public IActionResult AddAssignee(Assignee newAssignee)
        {
            assigneeRepository.AddAssignee(newAssignee);
            return RedirectToAction("Index");
        }

        [Route("{id}/delete")]
        public IActionResult DeleteAssignee(int id)
        {
            assigneeRepository.DeleteAssignee(id);
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/edit")]
        public IActionResult UpdateAssignee(int id)
        {
            return View("Edit", assigneeRepository.GetAssignee(id));
        }

        [HttpPost("{id}/edit")]
        public IActionResult UpdateAssigneeo(Assignee updatedAssignee)
        {
            assigneeRepository.UpdateAssignee(updatedAssignee);
            return RedirectToAction("Index");
        }
    }
}