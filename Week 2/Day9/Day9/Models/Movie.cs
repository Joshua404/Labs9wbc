using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day9.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public int? Year { get; set; }

        public string Description { get; set; }
    }
}