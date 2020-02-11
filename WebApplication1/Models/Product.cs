using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string name { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
    }
}