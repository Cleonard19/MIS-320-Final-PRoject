using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Team4.Models;

namespace Team4.ViewModels
{
    public class ShoppingCartViewModel
    {
        public int ID { get; set; }

        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}