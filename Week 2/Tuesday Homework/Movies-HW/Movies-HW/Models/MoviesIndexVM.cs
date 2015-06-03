using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies_HW.Models
{
    public class MoviesIndexVM
    {
        public Movie Movie { get; set; }

        public MoviesIndexVM()
        {
            this.Movie = new Movie();
        }


    }
}