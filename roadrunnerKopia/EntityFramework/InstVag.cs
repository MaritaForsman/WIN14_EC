namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstVag")]
    public partial class InstVag
    {
        public int InstVagId { get; set; }

        [Required]
        [StringLength(100)]
        public string Resvag { get; set; }

        [Required]
        [StringLength(10)]
        public string PersonId { get; set; }

        public bool? ShowVag { get; set; }
    }
}
