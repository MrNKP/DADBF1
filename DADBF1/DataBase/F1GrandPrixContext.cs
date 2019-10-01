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
        public virtual DbSet<season> seasons { get; set; }
        public virtual DbSet<team> teams { get; set; }
        public virtual DbSet<tournament> tournaments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<car>()
                .HasMany(e => e.teams)
                .WithOptional(e => e.car)
                .HasForeignKey(e => e.car1);

            modelBuilder.Entity<car>()
                .HasMany(e => e.teams1)
                .WithOptional(e => e.car3)
                .HasForeignKey(e => e.car2);

            modelBuilder.Entity<driver>()
                .Property(e => e.family_name)
                .IsUnicode(false);

            modelBuilder.Entity<driver>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results)
                .WithOptional(e => e.driver)
                .HasForeignKey(e => e.place1);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results1)
                .WithOptional(e => e.driver1)
                .HasForeignKey(e => e.place10);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results2)
                .WithOptional(e => e.driver2)
                .HasForeignKey(e => e.place2);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results3)
                .WithOptional(e => e.driver3)
                .HasForeignKey(e => e.place3);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results4)
                .WithOptional(e => e.driver4)
                .HasForeignKey(e => e.place4);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results5)
                .WithOptional(e => e.driver5)
                .HasForeignKey(e => e.place5);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results6)
                .WithOptional(e => e.driver6)
                .HasForeignKey(e => e.place6);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results7)
                .WithOptional(e => e.driver7)
                .HasForeignKey(e => e.place7);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results8)
                .WithOptional(e => e.driver8)
                .HasForeignKey(e => e.place8);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.results9)
                .WithOptional(e => e.driver9)
                .HasForeignKey(e => e.place9);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.teams)
                .WithOptional(e => e.driver)
                .HasForeignKey(e => e.driver1);

            modelBuilder.Entity<driver>()
                .HasMany(e => e.teams1)
                .WithOptional(e => e.driver3)
                .HasForeignKey(e => e.driver2);

            modelBuilder.Entity<race>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<race>()
                .HasMany(e => e.tournaments)
                .WithOptional(e => e.race1)
                .HasForeignKey(e => e.race);

            modelBuilder.Entity<result>()
                .HasMany(e => e.tournaments)
                .WithOptional(e => e.result1)
                .HasForeignKey(e => e.result);

            modelBuilder.Entity<team>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
