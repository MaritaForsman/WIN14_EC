using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ec.Roadrunner.WebAPI.Models
{

    /// <summary>
    /// Database Table for Trips
    /// </summary>
    [Table("Bil")]
    public class Trip
    {
        /// <summary>
        /// Automatic Id for Trip
        /// </summary>
        [Key]
        public int IdNr { get; set; }
        /// <summary>
        /// Date for trip
        /// </summary>
        [Column("Datum")]
        public DateTime DateStart { get; set; }

        /// <summary>
        /// Trip wtart value for car milage
        /// </summary>
        [Column("Ing")]
        public int MilageStart { get; set; }

        /// <summary>
        /// Trip end value for car milage
        /// </summary>
        [Column("Utg")]
        public int MilageStop { get; set; }

        /// <summary>
        /// The car license plate
        /// </summary>
        [Column("Bil")]
        public string Car { get; set; }

        /// <summary>
        /// Project connected to the trip
        /// </summary>
        [Column("Projekt")]
        public string Project { get; set; }

        /// <summary>
        /// Customer to visit for the trip
        /// </summary>
        [Column("Kstnr")]
        public string Customer { get; set; }

        /// <summary>
        /// Only there for existing system to run parallell
        /// </summary>
        [Column("Anr")]
        public int TemporaryPrivate { get; set; }

        /// <summary>
        /// Approve status of trip, set by Admin
        /// [NotMapped] will be removed
        /// </summary>
        
        public bool? Approved { get; set; }

        /// <summary>
        /// Private trip
        /// [NotMapped] will be removed
        /// </summary>
       
        public bool? Private { get; set; }

        /// <summary>
        /// The purpose of the trip
        /// [NotMapped] will be removed
        /// </summary>
        
        public string Purpose { get; set; }

        /// <summary>
        /// The route of the trip
        /// [NotMapped] will be removed
        /// </summary>
        
        public string Route { get; set; }

        /// <summary>
        /// The Projekt for the trip
        /// should be removed?? 
        /// </summary>
        
        
        
        public int? UserId { get; set; }
    }
}

