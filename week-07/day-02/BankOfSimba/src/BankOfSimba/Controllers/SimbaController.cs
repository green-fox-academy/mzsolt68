using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class SimbaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            BankAccount account = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = BankAccount.Animal.Lion
            };
            return View(account);
        }
    }
}
