//MIS 320 - Fall 2016
//Final Project - Team 4
//Team Members - Chris Leonard, Caroline Sedgwick, Kendall Smith, Alex Davila

//Description: Online Ordering system and system backend for a local restaurant in tuscaloosa AL

//    ***********************THIS PROJECT WAS DERIVED FROM THE OPEN SOURCE MVCMUSICSTORE EXAMPLE/TUTORIAL AVAILABLE ON THE ASP.NET WEBSITE***************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Team4.Models;


namespace Team4.Models
{
    public class OrderDetail
    {
        //id of orderdetail
        public int OrderDetailId { get; set; }

        //id of order
        public int OrderId { get; set; }

        //id of product
        public int ProductId { get; set; }

        //quantity of items in order
        public int Quantity { get; set; }

        //price of each unit in orderdetail
        public decimal UnitPrice { get; set; }

        //product in orderdetail
        public virtual Product Product { get; set; }

        //order in orderdetail
        public virtual Order Order { get; set; }
    }
}