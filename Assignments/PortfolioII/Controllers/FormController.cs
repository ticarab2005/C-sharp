using System;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioII.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        [Route("/")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }

        [HttpGet]
        [Route("contact")]
        public ViewResult Contact()
        {
            return View("Contact");;
        }
    }
}