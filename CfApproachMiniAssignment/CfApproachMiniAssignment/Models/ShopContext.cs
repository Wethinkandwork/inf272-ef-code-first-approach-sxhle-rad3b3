using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace CfApproachMiniAssignment.Models
{
    public class ShopContext : DbContext
    {
        DbSet<Product> Products;
        DbSet<Brand> Brands;
        DbSet<Categories> Categories;
        DbSet<Stock> Stocks;
        DbSet<Store> Stores;
        DbSet<Staff> Staffs;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

        public System.Data.Entity.DbSet<CfApproachMiniAssignment.Models.Brand> Brand { get; set; }

        public System.Data.Entity.DbSet<CfApproachMiniAssignment.Models.Categories> Categories { get; set; }

        public System.Data.Entity.DbSet<CfApproachMiniAssignment.Models.Product> Product { get; set; }

        public System.Data.Entity.DbSet<CfApproachMiniAssignment.Models.Staff> Staff { get; set; }

        public System.Data.Entity.DbSet<CfApproachMiniAssignment.Models.Store> Store { get; set; }

        public System.Data.Entity.DbSet<CfApproachMiniAssignment.Models.Stock> Stock { get; set; }
    }
}