namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Resour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Anr { get; set; }

        [Required]
        [StringLength(50)]
        public string Fnamn { get; set; }

        [Required]
        [StringLength(50)]
        public string Enamn { get; set; }
    }
}
