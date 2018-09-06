using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_In_Action.Models;

namespace MVC_In_Action.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var Movie = new Movie() { Name = "Dhoom" };

            return View(Movie);
        }
    }
}