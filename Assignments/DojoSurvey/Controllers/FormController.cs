using System;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class FormController : Controller
    {
        public static string pName;
        public static string dLocation;
        public static string dLanguage;
        public static string pComment;
        // This is where my routes and controls go
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        
        [HttpPost]
        [Route("process")]
        public IActionResult Process(string personName, string dojoLocation, string dojoLanguage, string personComment)
        {
            pName = personName;
            dLocation = dojoLocation;
            dLanguage = dojoLanguage;
            pComment = personComment;
            return RedirectToAction("Result");
        }
        [HttpGet("Results")]
        public IActionResult Result()
        {
            ViewBag.Name = pName;
            ViewBag.Location = dLocation;
            ViewBag.Language = dLanguage;
            ViewBag.Comment = pComment;
            return View("Result");
        }
    }
}