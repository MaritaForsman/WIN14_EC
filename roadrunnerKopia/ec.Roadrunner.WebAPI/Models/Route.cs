using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ec.Roadrunner.WebAPI.Models
{
    /// <summary>
    /// Table for handling a specific users settings for route of trip
    /// </summary>
    [Table("Route")]

    public class Route
    {
        /// <summary>
        /// Automatic id
        /// </summary>
        [Key]
        public int RouteId { get; set; }

        /// <summary>
        /// Actual route in text, maxlengh 50 Character
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Show the route in a list for a specific user
        /// </summary>
        public bool? Show { get; set; }

        /// <summary>
        /// Userid
        /// </summary>
        public int UserId { get; set; }


    }
}
