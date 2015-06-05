using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day9.Models
{
    public class MoviesDB:DbContext
    {

        public MoviesDB()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoviesDB, Configuration>());
        }
        public IDbSet<Movie> Movies { get; set; }

    }
}
//new MyDatabaseInitializer());
//DropCreateDatabaseIfModelChanges<MoviesDB>());