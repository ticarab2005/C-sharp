using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;



namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string createPasscode(int code)
        {
            string val = "ABCDEFJHIJKLMNOPQRSTUVWXYZ1234567890";
            string results = "";
            Random rand = new Random();
            for(int i = 0; i < code;i++)
            results += val[rand.Next(val.Length)];
            return results;
        }
        // public static string "0"
        [HttpGet("Index")]
        [Route("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("passcode") == null)
                HttpContext.Session.SetString("passcode","Create a Passcode!");
            if(HttpContext.Session.GetInt32("times") == null)
                HttpContext.Session.SetInt32("times",0);
            ViewBag.passcode = HttpContext.Session.GetString("passcode");
            ViewBag.times = HttpContext.Session.GetInt32("times");
            return View();
        }

        [HttpGet("Passcode")]
        public IActionResult newPasscode()
        {
            int? times = HttpContext.Session.GetInt32("times");
            times++;
            HttpContext.Session.SetInt32("times",(int)times);
            HttpContext.Session.SetString("passcode", createPasscode(14));
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
