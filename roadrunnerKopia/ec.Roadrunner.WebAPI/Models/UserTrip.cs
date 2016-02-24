using System.Collections.Generic;

namespace ec.Roadrunner.WebAPI.Models
{
    /// <summary>
    /// Model for User to CRUD their trips
    /// </summary>
    public class UserTrip
    {
        /// <summary>
        /// Create new instance of trip
        /// </summary>
        public Trip NewTrip { get; set; }

        /// <summary>
        /// Collection of users purpose
        /// </summary>
        public ICollection<Purpose> Purposes { get; set; }

        /// <summary>
        /// Collection of users route
        /// </summary>
        public ICollection<Route> Routes { get; set; }

        /// <summary>
        /// Collection of users projects
        /// </summary>
        public ICollection<UserProject> Projects { get; set; }
    }
}
