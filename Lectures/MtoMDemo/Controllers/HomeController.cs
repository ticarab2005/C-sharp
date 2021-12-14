using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MtoMDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace MtoMDemo.Controllers
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
            ViewBag.allMovies = _context.Movies.OrderBy(a=>a.Title).ToList();
            return View();
        }

        [HttpPost("addMovie")]
        public IActionResult addMovie(Movie newMovie)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newMovie);
                _context.SaveChanges();
                return RedirectToAction("Index");
                
            }else{
                return View("Index");
            }
        }
        [HttpGet("actors")]
        public IActionResult Actor()
        {
            ViewBag.allActors = _context.Actors.OrderBy(s=>s.FirstName).ToList();
            return View("actors");
        }

        [HttpPost("addActor")]
        public IActionResult addActor(Actor newActor)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newActor);
                _context.SaveChanges();
                return RedirectToAction("actors");
                
            }else{
                return View("Actors");
            }
        }
        [HttpGet("movie/{movieId}")]
        public IActionResult oneMovie(int movieId)
        {
            Movie one = _context.Movies.Include(f => f.CastList).ThenInclude(g => g.Actor).FirstOrDefault(d => d.MovieId == movieId);
            ViewBag.allActors = _context.Actors.OrderBy(s=>s.FirstName).ToList();
            return View();
        }

        [HttpPost("addToCast")]
        public IActionResult addToCast(Cast newRole)
        {
            _context.Add(newRole);
            _context.SaveChanges();
            return Redirect($"/movie/{newRole.MovieId}");
            // return RedirectToAction ("OneMovie", new {id = newRole.MovieId});

        }

        [HttpGet("actor/{actorId}")]
        public IActionResult oneActor(int actorId)
        {
            Actor one = _context.Actors.Include(f => f.ActorId).ThenInclude(g => g.Actor).FirstOrDefault(d => d.MovieId == movieId);
            ViewBag.allActors = _context.Actors.OrderBy(s=>s.FirstName).ToList();
            return View();
        }

        [HttpPost("addToFilm")]
        public IActionResult addToFilm(Cast newRole)
        {
            _context.Add(newRole);
            _context.SaveChanges();
            return Redirect($"/actor/{newRole.MovieId}");
            // return RedirectToAction ("OneMovie", new {id = newRole.MovieId});

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
