using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class SimbaController : Controller
    {
        static SimbaIndexViewModel accountViewModel = new SimbaIndexViewModel()
        {
            AccountList = new List<BankAccount>()
            {
                new BankAccount { Name = "Rafiki", Balance = 300, AnimalType = BankAccount.Animal.Monkey },
                new BankAccount { Name = "Pumba", Balance = 4000, AnimalType = BankAccount.Animal.Warthog },
                new BankAccount { Name = "Timon", Balance = 2400, AnimalType = BankAccount.Animal.Meerkats },
                new BankAccount { Name = "Sarafina", Balance = 9000, AnimalType = BankAccount.Animal.Lion },
                new BankAccount { Name = "Nala", Balance = 980, AnimalType = BankAccount.Animal.Lion }
            }
        };

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

        public IActionResult AccountList()
        {

            return View(accountViewModel);
        }
    }
}
