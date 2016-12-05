//MIS 320 - Fall 2016
//Final Project - Team 4
//Team Members - Chris Leonard, Caroline Sedgwick, Kendall Smith, Alex Davila

//Description: Online Ordering system and system backend for a local restaurant in tuscaloosa AL

//    ***********************THIS PROJECT WAS DERIVED FROM THE OPEN SOURCE MVCMUSICSTORE EXAMPLE/TUTORIAL AVAILABLE ON THE ASP.NET WEBSITE***************
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team4.Models
{
    public class Category
    {
        // ID of the category of products
        public int CategoryID { get; set;}

        // name of the categories
        public string Name { get; set;}
        
        // description of the category
        public string Descriptions { get; set; }

        // List of products contained in the category
        public List<Product> Products { get; set; }

    }
}