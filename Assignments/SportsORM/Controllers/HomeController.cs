using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeague = _context.Leagues.Where(w => w.Name.Contains("Womens'"));
            ViewBag.HockeyLeague = _context.Leagues.Where(h => h.Sport.Contains("Hockey"));
            ViewBag.NoFootballLeague = _context.Leagues.Where(nf => nf.Sport != "Football");
            ViewBag.ConferenceLeague = _context.Leagues.Where(c => c.Name.Contains("Conference"));
            ViewBag.AtlanticLeague = _context.Leagues.Where(a => a.Name.Contains("Atlantic"));
            ViewBag.DallasTeams = _context.Teams.Where(d => d.Location == "Dallas");
            ViewBag.RaptorsTeams = _context.Teams.Where(r => r.TeamName.Contains("Raptors"));
            ViewBag.CityTeams = _context.Teams.Where(ct => ct.Location.Contains("City"));
            ViewBag.TTeams = _context.Teams.Where(t => t.TeamName.Contains("T"));
            ViewBag.TopALocationTeams = _context.Teams.OrderBy(tl => tl.Location);
            ViewBag.BottomATeams = _context.Teams.OrderByDescending(bt => bt.TeamName).ToList();
            
            ViewBag.NameCooper = _context.Players.Where(ln => ln.LastName == "Cooper");
            ViewBag.NameJoshua = _context.Players.Where(fn => fn.FirstName == "Joshua");
            ViewBag.ExceptJoshua = _context.Players.Where(ex => ex.LastName.Contains("Cooper") && !ex.FirstName.Contains("Joshua"));
            ViewBag.EitherOr = _context.Players.Where(eo => eo.FirstName.Contains("Alexander") || eo.FirstName.Contains("Wyatt"));
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}