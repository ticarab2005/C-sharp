using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WeddingPlanner.Controllers
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
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("loggedInUser", newUser.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("log")]
        public IActionResult Log(LogUser loginUser)
        {
            if (ModelState.IsValid)
            {
                // First, I need to find the user in my database using their email
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == loginUser.logEmail);
                // If nothing shows up, they have the wrong credentials
                if (userInDb == null)
                {
                    ModelState.AddModelError("logEmail", "Invalid login attempt!");
                    return View("Index");
                }
                // If something shows up, it's time to check the password
                PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.logPassword);
                if (result == 0)
                {
                    // If the password is wrong, kick them back
                    ModelState.AddModelError("logEmail", "Invalid login attempt!");
                    return View("Index");
                }
                // if the password is right, let them through
                HttpContext.Session.SetInt32("loggedInUser", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard(int weddingId)
        {
            if (HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                ModelState.AddModelError("loggedInUser", "Not signed in!");
                return RedirectToAction("Index");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
            ViewBag.allWeddings = _context.Weddings.Include(d => d.myUser).Include(r => r.RSVPAt).ToList();
            return View("Dashboard");
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            ViewBag.UserId = (int)HttpContext.Session.GetInt32("loggedInUser");
            return View("New");
        }

        [HttpPost("createWedding")]
        public IActionResult CreateWedding(Wedding reserveWedding)
        {
            if (reserveWedding.Date < DateTime.Now)
            {
                ModelState.AddModelError("Date", "Can't be past Weddings!");
                return View("New");
            }
            if (_context.Weddings.Any(u => u.WedderOne == reserveWedding.WedderOne && u.WedderTwo == reserveWedding.WedderTwo))
            {
                ModelState.AddModelError("WedderOne", "Wedding Already Exists!");
                return View("New");
            }
            if (ModelState.IsValid)
            {
                reserveWedding.UserId = (int)HttpContext.Session.GetInt32("loggedInUser");
                _context.Add(reserveWedding);
                _context.SaveChanges();
                return Redirect($"/show/{reserveWedding.WeddingId}");
            }else{

            return View("New");
            }
        }

        [HttpGet("show/{weddingId}")]
        public IActionResult Show(int weddingId)
        {
            if (HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                ModelState.AddModelError("loggedInUser", "Not signed in!");
                return RedirectToAction("Index");
            }
            ViewBag.allWeddings = _context.Weddings.ToList();
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
            Wedding single = _context.Weddings.Include(f => f.RSVPAt).ThenInclude(g => g.User).FirstOrDefault(e => e.WeddingId == weddingId);
            return View(single);
        }

        [HttpGet("RSVP/{weddingId}/{userId}")]
        public IActionResult RSVP(int weddingId, int userId)
        {
            if (HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                ModelState.AddModelError("loggedInUser", "Not signed in!");
                return RedirectToAction("Index");
            }
            if(HttpContext.Session.GetInt32("loggedInUser")!=userId)
            {
                RedirectToAction("Logout");
            }
            RSVP newRSVP = new RSVP();
            newRSVP.WeddingId = weddingId;
            newRSVP.UserId = userId;
            _context.Add(newRSVP);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("UnRSVP/{weddingId}/{userId}")]
        public IActionResult UnRSVP(int weddingId, int userId)
        {
            if (HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                ModelState.AddModelError("loggedInUser", "Not signed in!");
                return RedirectToAction("Index");
            }
            if(HttpContext.Session.GetInt32("loggedInUser")!=userId)
            {
                RedirectToAction("Logout");
            }
            RSVP removeRSVP = _context.RSVPs.FirstOrDefault(d=> d.WeddingId == weddingId && d.UserId == userId);
            _context.RSVPs.Remove(removeRSVP);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        
        [HttpGet("delete/{weddingId}")]
        public IActionResult deleteReservation(int weddingId)
        {
            Wedding deleteReservation = _context.Weddings.SingleOrDefault(f=> f.WeddingId == weddingId);
            _context.Weddings.Remove(deleteReservation);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        // [HttpGet("delete/{weddingId}/{userId}")]
        // public IActionResult DeleteReservation(int weddingId, int userId)
        // {
        //     Wedding reservationToDelete = _context.Weddings.SingleOrDefault(c => c.WeddingId == weddingId);
        //     // if (HttpContext.Session.GetInt32("loggedInUser") != reservationToDelete.UserId)
        //     // {
        //     //     return RedirectToAction("Logout");
        //     // }else{
        //     _context.Weddings.Remove(reservationToDelete);
        //     _context.SaveChanges();
        //     return RedirectToAction("Dashboard");
        //     // }
        // }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
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
