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
    public class ProductDetail
    {
        //ID of ProductDetail
        public int ProductDetailID { get; set; }
        //ID of Product
        public int ProductID { get; set; }
        //ID of Ingredient
        public int IngredientID { get; set; }
        //Quantity of Items in Product Detail
        public int Quantity { get; set; }
        //Product in ProductDetail
        public virtual Product Product { get; set; }
        //Ingredient in Product Detail
        public virtual Ingredient Ingredient { get; set; }
    }
}