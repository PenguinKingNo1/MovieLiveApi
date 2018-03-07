namespace MovieLive.Data
{
    using MovieLive.Models.Common;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MovieLiveDbContext : DbContext
    {
        // Your context has been configured to use a 'MovieLiveDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MovieLive.Data.MovieLiveDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MovieLiveDbContext' 
        // connection string in the application configuration file.
        public MovieLiveDbContext()
            : base("name=MovieLiveDbContext")
        {
        }


        public virtual DbSet<AuditableEntity> MyEntities { get; set; }
    }

}