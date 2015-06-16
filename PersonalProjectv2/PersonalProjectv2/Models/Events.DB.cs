using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonalProjectv2.Models
{
    public class EventsDB:DbContext 
    {
        public EventsDB()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoviesDB, Configuration>());
        }
        public IDbSet<EventsViewModel> Events { get; set; }
    }
}