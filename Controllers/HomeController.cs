//MIS 320 - Fall 2016
//Final Project - Team 4
//Team Members - Chris Leonard, Caroline Sedgwick, Kendall Smith, Alex Davila

//Description: Online Ordering system and system backend for a local restaurant in tuscaloosa AL

//    ***********************THIS PROJECT WAS DERIVED FROM THE OPEN SOURCE MVCMUSICSTORE EXAMPLE/TUTORIAL AVAILABLE ON THE ASP.NET WEBSITE***************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Team4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Would link to a Bama Drive In About Page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Admin Portal Tab on Home Page; 
        public ActionResult AdminPortal()
        {
            return View();
        }

        //Contact Page Tab on Home Page
        public ActionResult Contact()
        {
            ViewBag.Message = "Having trouble? Send us a message.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Thanks we got your message!";

            return View();
        }
    }
}