namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstOrsak")]
    public partial class InstOrsak
    {
        public int InstOrsakId { get; set; }

        [Required]
        [StringLength(50)]
        public string Beskrivning { get; set; }

        public bool? ShowOrsak { get; set; }

        public int Anr { get; set; }
    }
}
