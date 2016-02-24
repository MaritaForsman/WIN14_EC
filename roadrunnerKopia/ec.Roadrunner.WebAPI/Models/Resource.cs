using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ec.Roadrunner.WebAPI.Models
{
    /// <summary>
    /// To retrive users name
    /// </summary>
    [Table("Resurs")]
    public class Resource
    {
        /// <summary>
        /// Userid
        /// </summary>
        [Key]
        [Column("Anr")]
        public int UserId { get; set; }

        /// <summary>
        /// Users First name
        /// </summary>

        [Column("FNamn")]
        public string Fname { get; set; }

        /// <summary>
        /// Users Last name
        /// </summary>
        [Column("ENamn")]
        public string Lname { get; set; }
        /// <summary>
        /// Active user = 1
        /// </summary>
        [Column("Visas")]
        public int Show { get; set; }
    }
}
