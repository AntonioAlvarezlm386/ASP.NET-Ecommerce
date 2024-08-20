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
                .WithMany(c => c.SHOP_CARTS)
                .HasForeignKey(sc => sc.CLIENT_ID);

            modelBuilder.Entity<ShoppCart>()
                .HasRequired(sc => sc.PRODUCT)
                .WithMany(p => p.SHOPCARTS)
                .HasForeignKey(sc => sc.PRODUCT_ID);

            // Sale configuration
            modelBuilder.Entity<Sale>()
                .HasRequired(s => s.CLIENT)
                .WithMany(c => c.SALES)
                .HasForeignKey(s => s.CLIENT_ID);

            modelBuilder.Entity<Sale>()
                .HasRequired(s => s.LOCALITY)
                .WithMany(l = l.SALES)
                .HasForeignKey(s => s.LOCALITY_ID)

            // SaleDetail configuration
            modelBuilder.Entity<SaleDetail>()
                .HasRequired(sd => sd.SALE)
                .WithMany(s => s.SALE_DETAILS)
                .HasForeignKey(sd => sd.SALE_ID);

            modelBuilder.Entity<SaleDetail>()
                .HasRequired(sd => sd.PRODUCT)
                .WithMany(p => p.SALE_DETAIS)
                .HasForeignKey(sd => sd.PRODUCT_ID);

            //City configuration
            modelBuilder.Entity<City>()
                .HasRequired(c => c.STATE)
                .WithMany(s => s.CITIES)
                .HasForeignKey(c => c.STATE_ID);

            // Locality configuration
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
