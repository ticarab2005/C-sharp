using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OtMDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace OtMDemo.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.allStudent = _context.Teachers.ToList();
            return View();
        }

        [HttpPost("addTeacher")]

        public IActionResult addTeacher(Teacher newTeacher)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newTeacher);
                _context.SaveChanges();
                return RedirectToAction();
            }else{
                ViewBag.allStudent = _context.Teachers.ToList();
                return View("Index");
            }
        }
        [HttpPost("addTeacher")]

        public IActionResult addStudent(Teacher newStudent)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newStudent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }else{
                ViewBag.allStudent = _context.Teachers.ToList();
                return View("Index");
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
