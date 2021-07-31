using ExpenseTracker.Data;
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExpenseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Expense> objList = _db.Expenses;

            return View(objList);
        }

        // GET-CreateExpense
        public IActionResult CreateExpense()
        {
            return View();
        }

        // POST-CreateExpense
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateExpense(Expense obj)
        {
            if(obj.ExpenseName != null)
            {
                _db.Expenses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("CreateExpense");
        }
    }
}
