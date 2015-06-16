using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day10.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }

    }
}