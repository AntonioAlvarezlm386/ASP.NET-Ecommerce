using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataLayuot
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("name=EcommerceDB")
        {
        }
         
        public DbSet<USER> USER { get; set; }
        public DbSet<CATEGORY> CATEGORY { get; set; }
        public DbSet<BRAND> BRAND { get; set; }
        public DbSet<PRODUCT> PRODUCT { get; set; }
        public DbSet<CLIENT> CLIENT { get; set; }
        public DbSet<SALE> SALE { get; set; }
        public DbSet<SHOPP_CART> SHOPCARP { get; set; }
        public DbSet<SALE_DETAIL> SALE_DETAIL { get; set; }
        public DbSet<STATE> STATE { get; set; }
        public DbSet<CITY> CITY { get; set; }
        public DbSet<LOCALITY> LOCALITY { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Brand Configuration
            modelBuilder.Entity<BRAND>()
                .HasKey(b => b.BRAND_ID);

            //Category configuration
            modelBuilder.Entity<CATEGORY>()
                .HasKey(c => c.CATEGORY_ID);

            //Client configuration
            modelBuilder.Entity<CLIENT>()
                .HasKey(c => c.CLIENT_ID);

            //State configuration
            modelBuilder.Entity<STATE>()
                .HasKey(s => s.STATE_ID);

            //User configuration
            modelBuilder.Entity<USER>()
                .HasKey(u => u.USER_ID);

            // Product relationShips
            modelBuilder.Entity<PRODUCT>()
                .HasKey(p => p.PRODUCT_ID);

            modelBuilder.Entity<PRODUCT>()
                .HasRequired(p => p.BRAND)
                .WithMany(b => b.PRODUCTS)
                .HasForeignKey(p => p.BRAND_ID);

            modelBuilder.Entity<PRODUCT>()
                .HasRequired(p => p.CATEGORY)
                .WithMany(c => c.PRODUCTS)
                .HasForeignKey(p => p.CATEGORY_ID);


            // ShoppCart configuration
            modelBuilder.Entity<SHOPP_CART>()
                .HasKey(sp => sp.CART_ID);

            modelBuilder.Entity<SHOPP_CART>()
                .HasRequired(sc => sc.CLIENT)
                .WithMany(c => c.SHOPCARTS)
                .HasForeignKey(sc => sc.CLIENT_ID);

            modelBuilder.Entity<SHOPP_CART>()
                .HasRequired(sc => sc.PRODUCT)
                .WithMany(p => p.SHOPCARTS)
                .HasForeignKey(sc => sc.PRODUCT_ID);

            // Sale configuration
            modelBuilder.Entity<SALE>()
                .HasKey(s => s.SALE_ID);

            modelBuilder.Entity<SALE>()
                .HasRequired(s => s.CLIENT)
                .WithMany(c => c.SALES)
                .HasForeignKey(s => s.CLIENT_ID);

            modelBuilder.Entity<SALE>()
                .HasRequired(s => s.LOCALITY)
                .WithMany(l => l.SALES)
                .HasForeignKey(s => s.LOCALITY_ID);

            // SaleDetail configuration
            modelBuilder.Entity<SALE_DETAIL>()
                .HasKey(sd => sd.DETAIL_ID);

            modelBuilder.Entity<SALE_DETAIL>()
                .HasRequired(sd => sd.SALE)
                .WithMany(s => s.SALE_DETAILS)
                .HasForeignKey(sd => sd.SALE_ID);

            modelBuilder.Entity<SALE_DETAIL>()
                .HasRequired(sd => sd.PRODUCT)
                .WithMany(p => p.SALE_DETAILS)
                .HasForeignKey(sd => sd.PRODUCT_ID);

            //City configuration
            modelBuilder.Entity<CITY>()
                .HasKey(c => c.CITY_ID);

            modelBuilder.Entity<CITY>()
                .HasRequired(c => c.STATE)
                .WithMany(s => s.CITIES)
                .HasForeignKey(c => c.STATE_ID)
                .WillCascadeOnDelete(false);

            // Locality configuration
            modelBuilder.Entity<LOCALITY>()
                .HasKey(l => l.LOCALITY_ID);

            modelBuilder.Entity<LOCALITY>()
                .HasRequired(l => l.STATE)
                .WithMany(s => s.LOCALITIES)
                .HasForeignKey(l => l.STATE_ID);

            modelBuilder.Entity<LOCALITY>()
                .HasRequired(l => l.CITY)
                .WithMany(c => c.LOCALITIES)
                .HasForeignKey(l => l.CITY_ID);

        }


    } 
}
