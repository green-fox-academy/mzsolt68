using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    }
}