using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.DbContexts
{
    public partial class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext()
        {
        }

        public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        //public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=THANH_HO;Database=OnlineShop22;User Id=sa; password=123456;Trusted_Connection=False;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.ID)
                    .IsUnique();

                entity.Property(e => e.Link).IsFixedLength();

            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.ID)
                    .IsUnique();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Category_ID);

                entity.Property(e => e.Metatitle)
                    .IsFixedLength();
                entity.Property(e => e.Promotion_Price)
                    .HasPrecision(18, 0);
                entity.Property(e => e.Price)
                    .HasPrecision(18, 0);
            });

        }
    }
}
