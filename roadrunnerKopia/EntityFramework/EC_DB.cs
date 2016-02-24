namespace EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EC_DB : DbContext
    {
        public EC_DB()
            : base("name=EC_DB")
        {
        }

        public virtual DbSet<Bil> Bils { get; set; }
        public virtual DbSet<InstOrsak> InstOrsaks { get; set; }
        public virtual DbSet<InstProj> InstProjs { get; set; }
        public virtual DbSet<InstVag> InstVags { get; set; }
        public virtual DbSet<LoginAnr> LoginAnrs { get; set; }
        public virtual DbSet<Projekt> Projekts { get; set; }
        public virtual DbSet<Resour> Resours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bil>()
                .Property(e => e.Bil1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bil>()
                .Property(e => e.Projekt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bil>()
                .Property(e => e.Objekt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bil>()
                .Property(e => e.Kstnr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InstOrsak>()
                .Property(e => e.Beskrivning)
                .IsUnicode(false);

            modelBuilder.Entity<InstProj>()
                .Property(e => e.Anr)
                .IsUnicode(false);

            modelBuilder.Entity<InstVag>()
                .Property(e => e.Resvag)
                .IsUnicode(false);

            modelBuilder.Entity<InstVag>()
                .Property(e => e.PersonId)
                .IsUnicode(false);

            modelBuilder.Entity<LoginAnr>()
                .Property(e => e.LoginId)
                .IsUnicode(false);

            modelBuilder.Entity<Projekt>()
                .Property(e => e.Namn)
                .IsUnicode(false);

            modelBuilder.Entity<Resour>()
                .Property(e => e.Fnamn)
                .IsUnicode(false);

            modelBuilder.Entity<Resour>()
                .Property(e => e.Enamn)
                .IsUnicode(false);
        }
    }
}
