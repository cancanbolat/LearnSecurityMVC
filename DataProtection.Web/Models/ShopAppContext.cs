using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataProtection.Web.Models
{
    public partial class ShopAppContext : DbContext
    {
        public ShopAppContext()
        {
        }

        public ShopAppContext(DbContextOptions<ShopAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CartItems> CartItems { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Editions> Editions { get; set; }
        public virtual DbSet<ProductCategories> ProductCategories { get; set; }
        public virtual DbSet<ProductVariants> ProductVariants { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategories>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ProductId, e.CategoryId });

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductVariants>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ProductId, e.EditionId });

                entity.HasIndex(e => e.EditionId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.ProductVariants)
                    .HasForeignKey(d => d.EditionId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVariants)
                    .HasForeignKey(d => d.ProductId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
