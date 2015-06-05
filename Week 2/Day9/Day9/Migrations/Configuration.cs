namespace Day9.Migrations
{
    using Day9.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Day9.Models.MoviesDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Day9.Models.MoviesDB";
        }

        protected override void Seed(Day9.Models.MoviesDB context)
        {
            var movies = new Movie[]
            {
                new Movie {Title="Star Wars", Director="Lucas", Year=1979},
                new Movie {Title="Memento", Director="Nolan", Year=1998},
                new Movie {Title="King Kong", Director="Jackson", Year=2005}
            };

            context.Movies.AddOrUpdate(p => p.Title, movies);

        }
    }
}
