using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
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
            ViewBag.AllDishes = _context.Dishes.OrderBy(a => a.UpdatedAt).ToList();
            return View();
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View("new");
        }
        
        [HttpGet("show/{dishId}")]
        public IActionResult Show(int dishId)
        {
            Dish onlyShow = _context.Dishes.FirstOrDefault(a => a.DishId == dishId);
            return View(onlyShow);
        }

        [HttpPost("createDish")]

        public IActionResult createDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }else{
                return View("new");
            }
        }
            // Dish oneChef = _context.Dishes.FirstOrDefault(a => a.DishId == dishId);

        [HttpGet("edit/{dishId}")]
        public IActionResult Edit(int dishId)
        {
            Dish oneDish = _context.Dishes.FirstOrDefault(a => a.DishId == dishId);
            return View(oneDish);
        }
        
        [HttpGet("delete/{dishId}")]
        public IActionResult DeleteChef(int dishId)
        {
            Dish chefToDelete = _context.Dishes.SingleOrDefault(c => c.DishId == dishId);
            _context.Dishes.Remove(chefToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost("updateDishes/{dishId}")]
        public IActionResult Update(int dishId, Dish dishToUpdate)
        {
            dishToUpdate.DishId = dishId;
            if(ModelState.IsValid)
            {
                Dish oldDish = _context.Dishes.FirstOrDefault(c => c.DishId == dishId);
                oldDish.Chef = dishToUpdate.Chef;
                oldDish.Name = dishToUpdate.Name;
                oldDish.Tastiness = dishToUpdate.Tastiness;
                oldDish.Calories = dishToUpdate.Calories;
                oldDish.Description = dishToUpdate.Description;
                oldDish.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return View("show",oldDish);
            }else{
                return View("Edit",dishToUpdate);
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
