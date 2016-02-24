namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bil")]
    public partial class Bil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdNr { get; set; }

        public DateTime Datum { get; set; }

        public int Ing { get; set; }

        public int Utg { get; set; }

        [Column("Bil")]
        [Required]
        [StringLength(10)]
        public string Bil1 { get; set; }

        [Required]
        [StringLength(4)]
        public string Projekt { get; set; }

        [Required]
        [StringLength(3)]
        public string Objekt { get; set; }

        [Required]
        [StringLength(3)]
        public string Kstnr { get; set; }

        public int Bolag { get; set; }

        public int Anr { get; set; }

        public bool? Privat { get; set; }

        public bool? Godkand { get; set; }
    }
}
