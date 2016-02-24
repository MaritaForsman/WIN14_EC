using System.Collections.Generic;

namespace ec.Roadrunner.WebAPI.Models
{
    /// <summary>
    /// Model for Admin to CRUD trips
    /// </summary>
    public class AdminTrip
    {
        /// <summary>
        /// List of Userid's
        /// </summary>
        public IList<LoginAnr> UserId = new List<LoginAnr>();

        /// <summary>
        /// Create new trip
        /// </summary>
        public Trip NewTrip { get; set; }
    }
}
