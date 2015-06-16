using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day10.Models
{
    public class MoviesDB:DbContext
    {
        public IDbSet<Category> Categories { get; set; }


    }
}