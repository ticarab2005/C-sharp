using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LogandReg.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LogandReg.Controllers
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
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email","Email is already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }else{
                return View("Index");
            }
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("login");
        }

        [HttpPost("log")]
        public IActionResult Log(LoginUser logUser)
        {
            if(ModelState.IsValid)
            {
                // First, I need to find the user in my database using their email
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == logUser.logEmail);
            // If nothing shows up, they have the wrong credentials
                if(userInDb == null)
                {
                    ModelState.AddModelError("logEmail","Invalid login attempt!");
                    return View("Login");
                }
            // If something shows up, it's time to check the password
                PasswordHasher<LoginUser> Hasher = new PasswordHasher<LoginUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logUser,userInDb.Password,logUser.logPassword);
                if(result == 0)
                {
            // If the password is wrong, kick them back
                    ModelState.AddModelError("logEmail","Invalid login attempt!");
                    return View("Login");
                }
            // if the password is right, let them through
                HttpContext.Session.SetInt32("User",userInDb.UserId);
                return RedirectToAction("Success");
            }else{
                return View("Login");
            }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("User") == null)
                {
                    ModelState.AddModelError("User","Not signed in!");
                    return RedirectToAction("Login");
                }
            return View("Success");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
        public IActionResult Privacy()
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
