using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ec.Roadrunner.WebAPI.Models
{
    /// <summary>
    /// Retrive information from Project Table
    /// </summary>
    [Table("Projekt")]
    public class Project
    {
        /// <summary>
        /// Project id number
        /// </summary>
        [Key]
        [Column("Nr")]
        [MaxLength(4)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Project Name
        /// </summary>
        [Column("Namn")]
        public string Name { get; set; }

        /// <summary>
        /// Department
        /// </summary>

        [Column("Avdelning")]
        public string Department { get; set; }

        /// <summary>
        /// Active = 1
        /// </summary>
        [Column("Visas")]
        public System.Byte[] Show { get; set; }

    }
}
