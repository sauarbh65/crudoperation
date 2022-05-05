using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using crudoperation.context;
using crudoperation.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace crudoperation.context
{
    public class ProductManagementcontext:DbContext
    {
        public ProductManagementcontext() : base("ProductManagementContextDB")
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }

}