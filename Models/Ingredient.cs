//MIS 320 - Fall 2016
//Final Project - Team 4
//Team Members - Chris Leonard, Caroline Sedgwick, Kendall Smith, Alex Davila

//Description: Online Ordering system and system backend for a local restaurant in tuscaloosa AL

//    ***********************THIS PROJECT WAS DERIVED FROM THE OPEN SOURCE MVCMUSICSTORE EXAMPLE/TUTORIAL AVAILABLE ON THE ASP.NET WEBSITE***************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team4.Models
{
    public class Ingredient
    {
        // id of the indgredient
        public int IngredientID { get; set; }
        
        //name of the ingredient
        public string Name { get; set; }

        //Qty of ingredient available
        public int QtyAvail { get; set; }

        //price of the ingredient
        public decimal UnitPrice { get; set;}

    }
}