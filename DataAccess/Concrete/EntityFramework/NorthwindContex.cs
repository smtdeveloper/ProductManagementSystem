using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    // Contex : Db ile class'larımızı bağlamak.
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");

        }

        public DbSet<Product> producks   { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Customer> customers  { get; set; }
    }
}
