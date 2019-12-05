using IntexNorthwestLabs.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.DAL
{
    public class NorthWestLabsContext : DbContext
    {
        public NorthWestLabsContext()
            : base("NorthWestLabsContext")
        {

        }

        public DbSet<Assay> Assay { get; set; }
        public DbSet<AssayTest> AssayTest { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderAssay> OrderAssay { get; set; }
        public DbSet<User> User { get; set; }

        public System.Data.Entity.DbSet<IntexNorthwestLabs.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<IntexNorthwestLabs.Models.Assay_Catalog> Assay_Catalog { get; set; }

        public System.Data.Entity.DbSet<IntexNorthwestLabs.Models.Test> Tests { get; set; }
    }
}

