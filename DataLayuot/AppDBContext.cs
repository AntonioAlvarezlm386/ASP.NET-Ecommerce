using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayout;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayuot
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("cart")
        {
        }
         
        public DbSet<User> USER { get; set; }
        public DbSet<Category> CATEGORY { get; set; }
        public DbSet<State> STATE { get; set; }
        public DbSet<City> CITY { get; set; }
        public DbSet<Locality> LOCALITY { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Product relationShips
            modelBuilder.Entity<Product>()
                .HasRequired(p => p.BRAND)
                .WithMany(b => b.PRODUCTS)
                .HasForeignKey(p => p.BRAND_ID);

            modelBuilder.Entity<Product>()
                .HasRequired(p => p.CATEGORY)
                .WithMany(c => c.PRODUCTS)
                .HasForeignKey(p => p.CATEGORY_ID);


            // ShoppCart configuration
            modelBuilder.Entity<ShopCart>()
                .HasRequired(sc => sc.CLIENT_ID)
                .WithMany(c => c.);

                .HasForeignKey(sc => sc.ClientId);
            modelBuilder.Entity<ShoppCart>()
                .HasRequired(sc => sc.Product)
                .WithMany(p => p.ShoppCarts)
                .HasForeignKey(sc => sc.ProductId);

            // Sale configuration
            modelBuilder.Entity<Sale>()
                .HasKey(s => s.SaleId);
            modelBuilder.Entity<Sale>()
                .Property(s => s.SaleId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Sale>()
                .Property(s => s.Total)
                .HasPrecision(10, 2);
            modelBuilder.Entity<Sale>()
                .Property(s => s.Contact)
                .HasMaxLength(50);
            modelBuilder.Entity<Sale>()
                .Property(s => s.LocalitysId)
                .HasMaxLength(10);
            modelBuilder.Entity<Sale>()
                .Property(s => s.Phone)
                .HasMaxLength(50);
            modelBuilder.Entity<Sale>()
                .Property(s => s.Address)
                .HasMaxLength(500);
            modelBuilder.Entity<Sale>()
                .Property(s => s.TransId)
                .HasMaxLength(50);
            modelBuilder.Entity<Sale>()
                .Property(s => s.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Sale>()
                .HasRequired(s => s.Client)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.ClientId);

            // SaleDetail configuration
            modelBuilder.Entity<SaleDetail>()
                .HasKey(sd => sd.DETAIL_ID);

            modelBuilder.Entity<SaleDetail>()
                .Property(sd => sd.DETAIL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            modelBuilder.Entity<SaleDetail>()
                .Property(sd => sd.TOTAL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SaleDetail>()
                .HasRequired(sd => sd.)
                .WithMany(s => s.SaleDetails)
                .HasForeignKey(sd => sd.SaleId);
            modelBuilder.Entity<SaleDetail>()
                .HasRequired(sd => sd.Product)
                .WithMany(p => p.SaleDetails)
                .HasForeignKey(sd => sd.ProductId);


            // State configuration 
            modelBuilder.Entity<State>()
                .HasKey(s => s.STATE_ID);

            modelBuilder.Entity<State>()
                .Property(s => s.STATE_ID)
                .HasMaxLength(2)
                .IsFixedLength()
                .IsRequired();

            modelBuilder.Entity<State>()
                .Property(s => s.DESCRIPTION)
                .HasMaxLength(45)
                .IsRequired();

            //City configuration
            modelBuilder.Entity<City>()
                .HasKey(c => c.CITY_ID);

            modelBuilder.Entity<City>()
                .Property(c => c.CITY_ID)
                .HasMaxLength(4)
                .IsFixedLength()
                .IsRequired();

            modelBuilder.Entity<City>()
                .Property(c => c.DESCRIPTION)
                .HasMaxLength(45);

            modelBuilder.Entity<City>()
                .HasRequired(c => c.STATE)
                .WithMany(s => s.CITIES)
                .HasForeignKey(c => c.STATE_ID);

            // Locality configuration
            modelBuilder.Entity<Locality>()
                .HasKey(l => l.LOCALITY_ID);

            modelBuilder.Entity<Locality>()
                .Property(l => l.LOCALITY_ID)
                .HasMaxLength(6)
                .IsFixedLength()
                .IsRequired();

            modelBuilder.Entity<Locality>()
                .Property(l => l.DESCRIPTION)
                .HasMaxLength(45)
                .IsRequired();

            modelBuilder.Entity<Locality>()
                .HasRequired(l => l.STATE)
                .WithMany(s => s.LOCALITIES)
                .HasForeignKey(l => l.STATE_ID);

            modelBuilder.Entity<Locality>()
                .HasRequired(l => l.CITY)
                .WithMany(c => c.LOCALITIES)
                .HasForeignKey(l => l.CITY_ID);

        }


    } 
}
