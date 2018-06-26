using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba2017.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba2017.Controllers
{
    public class SimbaController : Controller
    {
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