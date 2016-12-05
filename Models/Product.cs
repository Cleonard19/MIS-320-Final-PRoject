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
using System.ComponentModel;
using System.Web.Mvc;

namespace Team4.Models
{
    [Bind(Exclude = "ProductID")]
    public class Product
    {
        [ScaffoldColumn(false)]
        // Id of the product
        public int ProductID { get; set;}

        // Category ID of the category the product belongs to
        [DisplayName("Category")]
        public int CategoryID { get; set; }

        // Name of the product
        [Required(ErrorMessage ="A Product Name is Required")]
        [StringLength(160)]
        public string Name { get; set; }


        // Price of the product
        [Required(ErrorMessage ="is required")]
        [Range(0.01, 100.00, ErrorMessage ="Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }

        // Total number sold
        [DisplayName("Total Number Sold")]
        public int TotalSold { get; set;}

        // URL of the picture of the product
        [DisplayName("Menu Image URL")]
        public string ProductPicURL { get; set; }

        // Needed for foreign key relationships
        public virtual Category Category { get; set; }

        public List<Product> ProductList { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }

        
    }
}