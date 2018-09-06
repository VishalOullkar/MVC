using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Templated_HTML_Helper.Models;

namespace Templated_HTML_Helper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Class1 obj=new Class1()
            {
                Id=1,
                Name="Vishal",
                Address="Belgaum",
                city="Belgaum",
               IsEmp=true

             };



            return View(obj);
        }

      
        public ActionResult Edit()
        {
            return View();
 
        }
        [HttpPost]
        public ActionResult Edit(Class1 obj)
        {
            return View(obj);

        }


    }
}