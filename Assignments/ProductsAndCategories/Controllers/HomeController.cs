using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAndCategories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace ProductsAndCategories.Controllers
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
            ViewBag.allProducts = _context.Products.OrderBy( a=> a.Name).ToList();
            return View();
        }

                
        [HttpGet("category/{categoryId}")]
        public IActionResult Category(int categoryId)
        {
            Category single = _context.Categories.Include(f=>f.AssociatedAt).ThenInclude(g =>g.Product).FirstOrDefault(e=>e.CategoryId == categoryId);
            ViewBag.allProducts = _context.Products.OrderBy( a=> a.Name).ToList();
            return View(single);
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            ViewBag.allCategories = _context.Categories.OrderBy( a=> a.Name).ToList();
            return View("Categories");
        }

        [HttpGet("product/{productId}")]
        public IActionResult Product(int productId)
        {
            Product one = _context.Products.Include(f=>f.AssociationList).ThenInclude(g =>g.Category).FirstOrDefault(e=>e.ProductId == productId);
            ViewBag.allCategories = _context.Categories.OrderBy( a=> a.Name).ToList();
            return View(one);
        }

        [HttpPost("createProduct")]
        public IActionResult createProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                ViewBag.allProducts = _context.Products.OrderBy( a=> a.Name).ToList();
                return View("Index");
            }
        }

        [HttpPost("addProduct")]
        public IActionResult addProduct(Association oneProduct)
        {
            _context.Add(oneProduct);
            _context.SaveChanges();
            return Redirect($"/product/{oneProduct.ProductId}");
        }
        
        [HttpPost("createCategory")]
        public IActionResult createCategory(Category newCategory)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newCategory);
                _context.SaveChanges();
                return RedirectToAction("Categories");
            } else {
                ViewBag.allCategories = _context.Categories.OrderBy( a=> a.Name).ToList();
                return View("Categories");
            }
        }
        

        [HttpPost("addCategory")]
        public IActionResult AddCategory(Association oneCategory)
        {
            _context.Add(oneCategory);
            _context.SaveChanges();
            return Redirect($"/category/{oneCategory.CategoryId}");

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
