using Day7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day7.Views.Products
{
    public class IndexVM
    {
        public IList<Product> Products { get; set; }
    }
}