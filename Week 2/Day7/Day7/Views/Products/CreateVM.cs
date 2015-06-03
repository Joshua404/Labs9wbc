using Day7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day7.Views.Products
{
    public class CreateVM
    {
        public Product Product { get; set; }

        public SelectList Categories { get; set; }
    }
}