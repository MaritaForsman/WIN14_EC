namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Projekt")]
    public partial class Projekt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjId { get; set; }

        [Required]
        [StringLength(50)]
        public string Namn { get; set; }

        public int KostNr { get; set; }
    }
}
