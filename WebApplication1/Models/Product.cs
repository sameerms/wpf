using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Product'
    public class Product
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Product'
    {
        [Key]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Product.ProductId'
        public int ProductId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Product.ProductId'

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Product.name'
        public string name { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Product.name'

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Product.Quantity'
        public int Quantity { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Product.Quantity'

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Product.Price'
        public double Price { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Product.Price'
    }
}