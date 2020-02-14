using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    ///<Summary>
    /// Gets the answer
    ///</Summary>
    public class Product


    {
        ///<Summary>
        /// Gets the answer
        ///</Summary> 
        [Key]
        public int ProductId { get; set; }
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        public string Name { get; set; }

        ///<Summary>
        /// Gets the answer
        ///</Summary>
        public int Quantity { get; set; }


        ///<Summary>
        /// Gets the answer
        ///</Summary>

        public double Price { get; set; }

    }
}