using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day7.Models
{
    public class Product
    {
        public int Val1 { get; set; }
        public int Val2 { get; set; }
        public int Val3 { get; set; }

        public Category Category { get; set; }
    }
}