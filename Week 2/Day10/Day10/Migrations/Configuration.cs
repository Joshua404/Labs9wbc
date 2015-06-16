namespace Day10.Migrations
{
    using Day10.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Day10.Models.MoviesDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Day10.Models.MoviesDB context)
        {
            var categories = new Category[] {
                new Category {
                    Name="Action",
                    Movies = new List<Movie> {
                        new Movie {Title = "Age of Ultron"},
                        new Movie {Title = "Bladerunner"}
                    }
                
                },
                new Category {
                    Name="Drama",
                    Movies = new List<Movie> {
                        new Movie {Title="The Godfather"}
                    }
                
                }
            };

            context.Categories.AddOrUpdate(c => c.Name, categories);
        }
    }
}
