using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BeltReview.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BeltReview.Controllers
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
            if(ModelState.IsValid){
            // Make sure the email is unique
                if(_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use!");
                    return View("Index");
                }
                // After that, I need to hash the password
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                // Then I can add to the database
                _context.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("loggedInUser", newUser.UserId);
                return RedirectToAction("Dashboard");
            }else{
                return View("Index");
            }
        }
        [HttpPost("login")]
        public IActionResult Login(LogUser logUser)
        {
            if(ModelState.IsValid)
            {
                // First, I need to find the user in my database using their email
                User userindb = _context.Users.FirstOrDefault(u=> u.Email == logUser.logEmail);
                // If nothing shows up, they have the wrong credentials 
                if (userindb == null){
                    ModelState.AddModelError("logEmail","Invalid login attempt");
                    return View("Index");
                }
                // If something shows up, it's time to check against the password
                PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
                var result = hasher.VerifyHashedPassword(logUser, userindb.Password, logUser.logPassword);
                // If the password is wrong, kick them back
                if(result == 0)
                {
                    ModelState.AddModelError("logEmail","Invalid login attempt");
                    return View("Index");
                }
                // If the password is right, let them through
                HttpContext.Session.SetInt32("loggedInUser", userindb.UserId);
                return RedirectToAction("Dashboard");
            } else {
                return View("Index");
            }
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            // Verify if someone is a logged in user
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d=>d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
            ViewBag.AllPost = _context.Posts.Include(d=>d.Poster).Include(f => f.LikedBy).OrderBy(s=>s.UpdatedAt).ToList();
            return View();
        }

        [HttpGet("addPost")]
        public IActionResult AddPost()
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            return View("AddPost");
        }

        [HttpPost("createPost")]
        public IActionResult CreatePost(Post newPost)
        {
            if(ModelState.IsValid)
            {
                newPost.UserId = (int)HttpContext.Session.GetInt32("loggedInUser");
                _context.Add(newPost);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            } else {
            return View("AddPost");
            }
        }

        [HttpGet("post/{postId}")]
        public IActionResult onePost(int postId)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d=>d.UserId == (int)HttpContext.Session.GetInt32("loggedInUser"));
            Post onePost = _context.Posts.Include(f=>f.Poster).Include(d=>d.LikedBy).FirstOrDefault(d=>d.PostId == postId);
            return View(onePost);
        }
        
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{postId}")]
        public IActionResult Edit(int postId)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            Post postToEdit = _context.Posts.FirstOrDefault(d=>d.PostId == postId);
            return View(postToEdit);
        }

        [HttpPost("update/{postId}")]
        public IActionResult Update(int postId, Post newVersion)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            Post postToUpdate = _context.Posts.FirstOrDefault(d=>d.PostId == postId);
            if(HttpContext.Session.GetInt32("loggedInUser") != postToUpdate.UserId)
            {
                return RedirectToAction("Logout");
            }
            postToUpdate.URL = newVersion.URL;
            postToUpdate.Description = newVersion.Description;
            postToUpdate.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("delete/{postId}")]
        public IActionResult Delete(int postId)
        {
            Post toDelete = _context.Posts.SingleOrDefault(f => f.PostId == postId);
            if(HttpContext.Session.GetInt32("loggedInUser") != toDelete.UserId)
            {
                return RedirectToAction("Logout");
            }
            _context.Posts.Remove(toDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("like/{postId}/{userId}")]
        public IActionResult LikePost(int postId, int userId)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            if(HttpContext.Session.GetInt32("loggedInUser") != userId)
            {
                return RedirectToAction("Logout");
            }
            Like newLike = new Like();
            newLike.PostId = postId;
            newLike.UserId = userId;
            _context.Add(newLike);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        
        [HttpGet("unlike/{postId}/{userId}")]
        public IActionResult UnLikePost(int postId, int userId)
        {
            if(HttpContext.Session.GetInt32("loggedInUser") == null)
            {
                return RedirectToAction("Index");
            }
            if(HttpContext.Session.GetInt32("loggedInUser") != userId)
            {
                return RedirectToAction("Logout");
            }
            Like likeToRemove = _context.Likes.FirstOrDefault(d=>d.PostId == postId && d.UserId == userId);
            _context.Likes.Remove(likeToRemove);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
