using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ec.Roadrunner.WebAPI.Models
{
    /// <summary>
    /// Table for handling a specific users settings for purpose of trip
    /// </summary>
    [Table("Purpose")]

    public class Purpose
    {
        /// <summary>
        /// Automatic id
        /// </summary>
        [Key]
        public int PurposeId { get; set; }

        /// <summary>
        /// Actual purpose in text, maxlengh 50 Character
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Show the purpose in a list for a specific user
        /// </summary>
        public bool? Show { get; set; }

        /// <summary>
        /// Userid
        /// </summary>
        public int UserId { get; set; }
    }
}
