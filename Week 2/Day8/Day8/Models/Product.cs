using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day8.Models
{
    public class Product
    {
        //[Required(ErrorMessage="Name Is Required!")]
        public string Name { get; set; }

        //[DataType(DataType.Currency)]
        //[Required(ErrorMessage="Price Is required!")]
        //[Range(0, 100, ErrorMessage="Price Is Invalid!")]
        public decimal Price { get; set; }
    }
}