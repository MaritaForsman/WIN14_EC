namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstProj")]
    public partial class InstProj
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjId { get; set; }

        public bool? ShowProj { get; set; }

        [Required]
        [StringLength(10)]
        public string Anr { get; set; }
    }
}
