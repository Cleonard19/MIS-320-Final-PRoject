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
using Team4.Models;

namespace Team4.Controllers
{
    public class StoreController : Controller
    {
        //GET: Store
        ApplicationDbContext storeDB = new ApplicationDbContext();

        //Displays list of menu item categories as action links
        public ActionResult Index()
        {
            var categories = storeDB.Categories.ToList();

            return View(categories);
        }

        public ActionResult Forecast()
        {
            return View();
        }
        
        //When category selected, displays action links of products within quantity
        public ActionResult Browse(string category)
        {
            var categoryModel = storeDB.Categories.Include("Products").Single(g => g.Name == category);

            return View(categoryModel);
        }
        
        //action link that displays details of each product
        public ActionResult Details(int id)
        {
            var product = storeDB.Products.Find(id);

            return View(product);
        }

        // GET: /Store/CategoryMenu
        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var categories = storeDB.Categories.ToList();
            return PartialView(categories);
        }
    }
}