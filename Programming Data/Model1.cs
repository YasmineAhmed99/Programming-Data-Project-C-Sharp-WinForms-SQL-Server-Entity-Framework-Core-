using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace Programming_Data
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Dismissal> Dismissals { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplyPerm> SupplyPerms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Dismissal>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<Dismissal>()
                .Property(e => e.material)
                .IsUnicode(false);

            modelBuilder.Entity<Dismissal>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .HasMany(e => e.Stores)
                .WithMany(e => e.Materials)
                .Map(m => m.ToTable("MaterialStore").MapLeftKey("Code").MapRightKey("StoreN"));

            modelBuilder.Entity<Store>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.RespPerson)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SupplyPerm>()
                .Property(e => e.Storename)
                .IsUnicode(false);

            modelBuilder.Entity<SupplyPerm>()
                .Property(e => e.material)
                .IsUnicode(false);

            modelBuilder.Entity<SupplyPerm>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);
        }
    }
}
