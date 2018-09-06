using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Action_Example.Models;
using Microsoft.Ajax.Utilities;

namespace Action_Example.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            //ActionResult = Output of action methods

            var Movie=new Movie(){Name = "Dhoom"};
            //return View(Movie);
            //return Content("Hi This is returning content result");
            //return HttpNotFound();
          //  return RedirectToAction("Index","Home",new {page=1,sortby="Random"});

            ViewData["Movie"] = Movie;
            return View();

        }

         public ActionResult Index(int? pageindex,string sortby)
         {
             // Action parameters =  Which are the inputs for Action
             if (!pageindex.HasValue)
                 pageindex = 1;
             if (string.IsNullOrWhiteSpace(sortby))
                 sortby = "Name";
          return Content(string.Format("PageIndex = {0} Sortby = {1}",pageindex,sortby));


      }



       //    [Route("Movies/Released/{year}/{month:regex(\\d{4}):range(1,12)}")]
            
                 // Attribute routes = More powerful
        //[Route("Movies/Released/{year:regex(\\d{4})}/{month:regex(\\d{4})")]
         public ActionResult ReleasedDate(int year,int month)
         {
             return Content(year +"/"+month);
         }
    }
}