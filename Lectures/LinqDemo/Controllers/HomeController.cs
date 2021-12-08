using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LinqDemo.Models;

namespace LinqDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Game[] allGames = new Game[]
            {
                new Game{Title="Pokemon Brilliant Diamon", Genre="Adventure",Price=60.00,Rating="E",Platform="Nintento Switch",minNumPlayers=1,maxNumPlayers=4},
                new Game{Title="Plasmophobia", Genre="Horror",Price=13.99,Rating="M",Platform="PC",minNumPlayers=1,maxNumPlayers=4},
                new Game{Title="Modern Warfare 3", Genre="First Person Shooter",Price=59.99,Rating="E",Platform="Nintento Switch",minNumPlayers=1,maxNumPlayers=1},
                new Game{Title="Pokemon Brilliant Diamon", Genre="Adventure",Price=60.00,Rating="E",Platform="Nintento Switch",minNumPlayers=1,maxNumPlayers=4},
                new Game{Title="Pokemon Brilliant Diamon", Genre="Adventure",Price=60.00,Rating="E",Platform="Nintento Switch",minNumPlayers=1,maxNumPlayers=4},
                new Game{Title="Pokemon Brilliant Diamon", Genre="Adventure",Price=60.00,Rating="E",Platform="Nintento Switch",minNumPlayers=1,maxNumPlayers=4},
                new Game{Title="Dreamland", Genre="Adventure",Price=25.00,Rating="E",Platform="Nintento Switch",minNumPlayers=1,maxNumPlayers=4},
            };

            // This line is a for each loop

            // foreach (Game adventG in allGames)
            // {
            //     if(adventG.Genre == "Adventure")
            //     {
            //         // add to a list of adventure games
            //     }
            // }

            //  function adventGames(game){
                // is the game passed in an adventure game?
                // if (game.Genre == "Adventure")
                // Do a thing, add to list, etc...
                // }
                // As SQL
                // SELECT * WHERE games.genre= "Adventure" ORDER BY ASC
                // Pass into List
            // }
            double priceMax = 20.00;
            // List<Game> AdventureGames = allGames.Where(adventG => adventG.Genre =="Adventure").OrderByDescending(n => n.Title).ToList();
            string genre = "Adventure";
            List<Game> AdventureGames = allGames.Where(adventG => adventG.Genre ==genre).OrderByDescending(n => n.Title).ToList();
            // List<Game> AdventureGames = allGames.Where(adventG => adventG.Genre =="Adventure").ToList();
            ViewBag.AllGames = allGames;
            ViewBag.AdventGames = AdventureGames;
            ViewBag.MaxPlayers = allGames.OrderBy(a => a.maxNumPlayers).ToList();
            ViewBag.Under20 = allGames.Where(g=>g.Price < priceMax).ToList();
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
