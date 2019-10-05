namespace DADBF1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class F1GrandPrixContext : DbContext
    {
        public F1GrandPrixContext()
            : base("name=F1GrandPrixContext")
        {
        }

        public virtual DbSet<car> cars { get; set; }
        public virtual DbSet<driver> drivers { get; set; }
        public virtual DbSet<race> races { get; set; }
        public virtual DbSet<result> results { get; set; }
        public virtual DbSet<team> teams { get; set; }
        public virtual DbSet<tournament> tournaments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<car>()
                .HasMany(e => e.teams)
                .WithRequired(e => e.car)
                .HasForeignKey(e => e.car1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<car>()
                .HasMany(e => e.teams1)
                .WithRequired(e => e.car3)
                .HasForeignKey(e => e.car2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .Property(e => e.family_name)
                .IsUnicode(false);

            modelBuilder.Entity<driver>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<driver>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results)
                .WithRequired(e => e.driver)
                .HasForeignKey(e => e.fastlap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results1)
                .WithRequired(e => e.driver1)
                .HasForeignKey(e => e.place1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results2)
                .WithRequired(e => e.driver2)
                .HasForeignKey(e => e.place10)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results3)
                .WithRequired(e => e.driver3)
                .HasForeignKey(e => e.place2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results4)
                .WithRequired(e => e.driver4)
                .HasForeignKey(e => e.place3)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results5)
                .WithRequired(e => e.driver5)
                .HasForeignKey(e => e.place4)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results6)
                .WithRequired(e => e.driver6)
                .HasForeignKey(e => e.place5)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results7)
                .WithRequired(e => e.driver7)
                .HasForeignKey(e => e.place6)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results8)
                .WithRequired(e => e.driver8)
                .HasForeignKey(e => e.place7)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results9)
                .WithRequired(e => e.driver9)
                .HasForeignKey(e => e.place8)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results10)
                .WithRequired(e => e.driver10)
                .HasForeignKey(e => e.place9)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.teams)
                .WithRequired(e => e.driver)
                .HasForeignKey(e => e.driver1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.teams1)
                .WithRequired(e => e.driver3)
                .HasForeignKey(e => e.driver2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<race>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<race>()
                .HasMany(e => e.tournaments)
                .WithRequired(e => e.race1)
                .HasForeignKey(e => e.race)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<result>()
                .HasMany(e => e.tournaments)
                .WithRequired(e => e.result1)
                .HasForeignKey(e => e.result)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<team>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
