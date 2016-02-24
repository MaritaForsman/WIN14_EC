using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ec.Roadrunner.WebAPI.Models
{
    /// <summary>
    /// Table for retrivning users
    /// </summary>
    public class LoginAnr
    {
        /// <summary>
        /// User id
        /// </summary>
        [Key]
        [StringLength(50)]
        public string LoginId { get; set; }

        /// <summary>
        /// Employee number
        /// </summary>
        public int Anr { get; set; }

        /// <summary>
        /// Autority level
        /// </summary>
        public int? TypeOfUser { get; set; }

        /// <summary>
        /// Active user = 1
        /// </summary>
        [Column("Visas")]
        public int? Show { get; set; }
    }
}
