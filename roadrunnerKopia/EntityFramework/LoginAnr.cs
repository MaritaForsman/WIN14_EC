namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoginAnr")]
    public partial class LoginAnr
    {
        [Key]
        [StringLength(50)]
        public string LoginId { get; set; }

        public int Anr { get; set; }

        public int? Visas { get; set; }

        public int? TypeOfUser { get; set; }
    }
}
