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

        public IActionResult List()
        {
            List<BankAccount> accountList = new List<BankAccount>()
            {
                new BankAccount { Name = "Rafiki", Balance = 300, AnimalType = BankAccount.Animal.Monkey },
                new BankAccount { Name = "Pumba", Balance = 4000, AnimalType = BankAccount.Animal.Warthog },
                new BankAccount { Name = "Timon", Balance = 2400, AnimalType = BankAccount.Animal.Meerkats },
                new BankAccount { Name = "Sarafina", Balance = 9000, AnimalType = BankAccount.Animal.Lion },
                new BankAccount { Name = "Nala", Balance = 980, AnimalType = BankAccount.Animal.Lion }

            };
            return View(accountList);
        }
    }
}