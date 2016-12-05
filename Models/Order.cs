//MIS 320 - Fall 2016
//Final Project - Team 4
//Team Members - Chris Leonard, Caroline Sedgwick, Kendall Smith, Alex Davila

//Description: Online Ordering system and system backend for a local restaurant in tuscaloosa AL
//
//    ***********************THIS PROJECT WAS DERIVED FROM THE OPEN SOURCE MVCMUSICSTORE EXAMPLE/TUTORIAL AVAILABLE ON THE ASP.NET WEBSITE***************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Team4.Models
{

        [Bind(Exclude = "OrderId")]
        public partial class Order
        {
            [ScaffoldColumn(false)]

            //id of order
        public int OrderId { get; set; }
            [ScaffoldColumn(false)]

            //datetime of order
            public System.DateTime OrderDate { get; set; }
            [ScaffoldColumn(false)]

            //username of user placing the order
            public string Username { get; set; }

        //message shown if first name is not entered
        //first name of user placing order
            [Required(ErrorMessage = "First Name is required")]
            [DisplayName("First Name")]
            [StringLength(160)]
            public string FirstName { get; set; }

        //message shown if last name is not entered
        //last name of user placing order
            [Required(ErrorMessage = "Last Name is required")]
            [DisplayName("Last Name")]
            [StringLength(160)]
            public string LastName { get; set; }
        //message shown if address is not entered
        //address of user
            [Required(ErrorMessage = "Address is required")]
            [StringLength(70)]

            //message shown if city is not entered
           
            public string Address { get; set; }
            [Required(ErrorMessage = "City is required")]
            [StringLength(40)]
            
            //message shown if state is not entered
            public string City { get; set; }
            [Required(ErrorMessage = "State is required")]
            [StringLength(40)]
            public string State { get; set; }

        //message shown if postal code is not entered
            [Required(ErrorMessage = "Postal Code is required")]
            [DisplayName("Postal Code")]
            [StringLength(10)]
            public string PostalCode { get; set; }

        //message shown if country is not entered
            [Required(ErrorMessage = "Country is required")]
            [StringLength(40)]
            public string Country { get; set; }

        //message shown if phone is not entered
        //phone number of customer
            [Required(ErrorMessage = "Phone is required")]
            [StringLength(24)]
            public string Phone { get; set; }

        //message shown if email is not entered
        //email of customer
            [Required(ErrorMessage = "Email Address is required")]
            [DisplayName("Email Address")]

            [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
                ErrorMessage = "Email is is not valid.")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
            [ScaffoldColumn(false)]
            //order total
            public decimal Total { get; set; }
        //list of order details
            public List<OrderDetail> OrderDetails { get; set; }
        }
}