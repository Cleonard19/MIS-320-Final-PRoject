//MIS 320 - Fall 2016
//Final Project - Team 4
//Team Members - Chris Leonard, Caroline Sedgwick, Kendall Smith, Alex Davila

//Description: Online Ordering system and system backend for a local restaurant in tuscaloosa AL

//    ***********************THIS PROJECT WAS DERIVED FROM THE OPEN SOURCE MVCMUSICSTORE EXAMPLE/TUTORIAL AVAILABLE ON THE ASP.NET WEBSITE***************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team4.Models
{
    public class Cart
    {
        [Key] //sets RecordId as primary key

        //Properties

        //id of the record
        public int RecordId { get; set; }

        //id of the cart
        public string CartId { get; set; }

        // id of the product
        public int ProductID { get; set; }

        //count of items in cart
        public int Count { get; set; }

        //datetime created
        public System.DateTime DateCreated { get; set; }

        //product in cart
        public virtual Product Product { get; set; }
    }
}

