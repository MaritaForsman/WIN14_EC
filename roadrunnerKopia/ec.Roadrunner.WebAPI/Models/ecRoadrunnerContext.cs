using System.Data.Entity;

namespace ec.Roadrunner.WebAPI.Models
{
    /// <summary>
    /// DB connection string
    /// </summary>
    public class ecRoadrunnerContext : DbContext
    {

        public DbSet<Project> Projects { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<UserProject> UserProjects { get; set; }
        public DbSet<LoginAnr> LoginAnrs { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
