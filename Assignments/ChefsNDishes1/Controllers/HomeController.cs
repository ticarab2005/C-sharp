using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace ChefsNDishes1.Controllers

{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;


        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.allChefs = _context.Chefs.Include(a => a.MyDishes).ToList();
            return View();
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.allDishes = _context.Dishes.Include(a => a.MyChef).ToList();
            return View("Dishes");
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            return View("new");
        }

        [HttpPost("CreateChef")]
        public IActionResult CreateChef(Chef oneChef)
        {
            if (oneChef.DoB > DateTime.Now)
            {
                ModelState.AddModelError("DoB", "Date of birth cannot be in the future!");
                return View("New");
            }
            if (DateTime.Now.Year - oneChef.DoB.Year < 18)
            {
                ModelState.AddModelError("DoB", "Invalid Date, Must be at least 18!");
                return View("New");
            }
            if (ModelState.IsValid)
            {
                if (_context.Chefs.Any(u => u.FirstName == oneChef.FirstName && u.LastName == oneChef.LastName))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("FirstName", "Chef Already Exists!");

                    return View("New");
                }
                _context.Add(oneChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("NewChef");
        }

        [HttpGet("newDish")]
        public IActionResult NewDish()
        {
            ViewBag.allChefs = _context.Chefs.ToList();
            return View("NewDish");
        }

        [HttpPost("createDish")]
        public IActionResult createDish(Dish oneDish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oneDish);
                _context.SaveChanges();
                return RedirectToAction("dishes");
            }
            else
            {
                ViewBag.allChefs = _context.Chefs.ToList();
                return View("newDish");
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
