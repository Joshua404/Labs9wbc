using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day9.Models
{
    public class MyDatabaseInitializer:DropCreateDatabaseAlways<MoviesDB>
    {

        protected override void Seed(MoviesDB context)
        {
            var movies = new List<Movie>
            {
                new Movie {Title="Star Wars", Director="Lucas", Year=1979},
                new Movie {Title="Memento", Director="Nolan", Year=1998},
                new Movie {Title="King Kong", Director="Jackson", Year=2005}
            
            
            };
            movies.ForEach(m => context.Movies.Add(m));
        }
    }
}