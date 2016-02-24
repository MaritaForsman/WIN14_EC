using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ec.Roadrunner.WebAPI.Models
{
    /// <summary>
    /// Table for handling a specific users settings for projects of trip
    /// </summary>
    [Table("UserProject")]

    public class UserProject
    {
        /// <summary>
        /// Automatic Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Project id
        /// </summary>
        public string UserProjectId { get; set; }

        /// <summary>
        /// Show the project in a list for a specific user
        /// </summary>
        public bool? Show { get; set; }

        /// <summary>
        /// Userid
        /// </summary>
        public int UserId { get; set; }
    }
}
