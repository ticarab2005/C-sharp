using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Artistry.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace Artistry.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MyContext _context;

        protected void Upload(object sender, EventArgs e)
{
    if (FileUpload1.HasFile)
    {
        string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Images/") + fileName);
        Response.Redirect(Request.Url.AbsoluteUri);
    }
}

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
                if (_context.Users.Any(u => u.Username == newUser.Username))
                {
                    ModelState.AddModelError("Username", "Username is already in use!");
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

        [HttpPost("login")]
        public IActionResult Login(LoginUser loginUser)
        {
            if (ModelState.IsValid)
            {
                // First, I need to find the user in my database using their email
                User userInDb = _context.Users.FirstOrDefault(u => u.Username == loginUser.logUsername);
                // If nothing shows up, they have the wrong credentials
                if (userInDb == null)
                {
                    ModelState.AddModelError("logUsername", "Invalid login attempt!");
                    return View("Index");
                }
                // If something shows up, it's time to check the password
                PasswordHasher<LoginUser> Hasher = new PasswordHasher<LoginUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.logPassword);
                if (result == 0)
                {
                    // If the password is wrong, kick them back
                    ModelState.AddModelError("logUsername", "Invalid login attempt!");
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
        public IActionResult Dashboard(int hobbyId)
        {
            if (HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                ModelState.AddModelError("loggedInUser", "Not signed in!");
                return RedirectToAction("Index");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
            ViewBag.allHobbies = _context.Artists.Include(r => r.difSkill).ToList();
            return View("Dashboard");
        }

        // [HttpGet("new")]
        // public IActionResult New()
        // {
        //     ViewBag.UserId = (int)HttpContext.Session.GetInt32("loggedInUser");
        //     if (HttpContext.Session.GetInt32("loggedInUser") == null)
        //     {
        //         ModelState.AddModelError("loggedInUser", "Not signed in!");
        //         return RedirectToAction("Index");
        //     }
        //     ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
        //     return View("New");
        // }

        // [HttpPost("createHobby")]
        // public IActionResult CreateHobby(Hobby newHobby, int hobbyId)
        // {
        //     ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
        //     if (_context.Artists.Any(u => u.HobbyName == newHobby.HobbyName))
        //     {
        //         ModelState.AddModelError("HobbyName", "Activity Already Exists!");
        //         return View("New");
        //     }
        //     if (ModelState.IsValid)
        //     {
        //         newHobby.UserId = (int)HttpContext.Session.GetInt32("loggedInUser");
        //         _context.Add(newHobby);
        //         _context.SaveChanges();
        //         return Redirect($"/show/{newHobby.HobbyId}");
        //     }
        //     else
        //     {

        //         return View("New");
        //     }
        // }

        // [HttpGet("show/{hobbyId}")]
        // public IActionResult Show(int hobbyId)
        // {
        //     if (HttpContext.Session.GetInt32("loggedInUser") == null)
        //     {
        //         ModelState.AddModelError("loggedInUser", "Not signed in!");
        //         return RedirectToAction("Index");
        //     }
        //     ViewBag.allHobbies = _context.Artists.Include(g => g.myUser).ToList();
        //     ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
        //     Hobby single = _context.Artists.Include(f => f.Enthusiastfor).ThenInclude(g => g.User).FirstOrDefault(e => e.HobbyId == hobbyId);
        //     return View(single);
        // }

        // [HttpGet("join/{hobbyId}/{userId}")]
        // public IActionResult Join(int hobbyId, int userId)
        // {
        //     if (HttpContext.Session.GetInt32("loggedInUser") == null)
        //     {
        //         ModelState.AddModelError("loggedInUser", "Not signed in!");
        //         return RedirectToAction("Index");
        //     }
        //     if (HttpContext.Session.GetInt32("loggedInUser") != userId)
        //     {
        //         RedirectToAction("Logout");
        //     }
        //     Enthusiast oneEnthusiast = new Enthusiast();
        //     oneEnthusiast.HobbyId = hobbyId;
        //     oneEnthusiast.UserId = userId;
        //     _context.Add(oneEnthusiast);
        //     _context.SaveChanges();
        //     return RedirectToAction("Dashboard");
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
