using System;
using Microsoft.AspNetCore.Mvc;

namespace formsDemo.Controllers
{
    public class FirstController : Controller
    {
        public static string pName;
        public static string pType;
        // This is where my routes and controls go
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        [Route("process")]
        public IActionResult Process(string petName, string petType)
        {
            pName = petName;
            pType = petType;
            return RedirectToAction("Result");
        }
        [HttpGet("Results")]
        public IActionResult Result()
        {
            ViewBag.Name = pName;
            ViewBag.Type = pType;
            return View("Result");
        }
    }
}