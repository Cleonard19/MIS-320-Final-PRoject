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
    [Authorize]
    public class CheckoutController : Controller
    {

        ApplicationDbContext storeDB = new ApplicationDbContext();
        //
        // GET: /Checkout/AddressAndPayment
        public ActionResult AddressAndPayment()
        {
            return View();
        }
        //
        // POST: /Checkout/AddressAndPayment
        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values)
        {
            //creates a new order
            var order = new Order();
            TryUpdateModel(order);

            order.Username = User.Identity.Name;
            order.OrderDate = DateTime.Now;

            //Save Order
            storeDB.Orders.Add(order);
            storeDB.SaveChanges();

            //Processes the order
            var cart = ShoppingCart.GetCart(this.HttpContext);
            cart.CreateOrder(order);


           
            int thisID = order.OrderId;
            //assigns ord a unique order id


            return RedirectToAction("Complete", "Checkout");
        }


        public ActionResult Complete()
        {
            
                return View();

        }
    }
}
