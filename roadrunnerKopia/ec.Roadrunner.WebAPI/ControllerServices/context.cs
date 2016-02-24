using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ec.Roadrunner.WebAPI.Controllers;
using System.Web.Mvc.Html;
using System.Security.AccessControl;
using System.Data.Entity;
using ec.Roadrunner.WebAPI.Models;

namespace ec.Roadrunner.WebAPI.ControllerServices
{
    public class ecRoadrunnerWebAPIContext : DbContext
    {
        
        /// <summary>
        /// </summary>
        public ecRoadrunnerWebAPIContext() : base("name=ecRoadrunnerWebAPIContext")
        {
        }



        /// <summary>
        /// </summary>
        public DbSet<Purpose> Purposes { get; set; }

        /// <summary>
        /// </summary>
        public DbSet<Purpose> Routes { get; set; }

        /// <summary>
        /// </summary>
        public DbSet<UserProject> UserProjects { get; set; }


        /// <summary>
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        public DbSet<Trip> Trips { get; set; }

    }

    public class Project
    {
        public string name { get; set; }
        public int Id { get; set; }

    }
}
