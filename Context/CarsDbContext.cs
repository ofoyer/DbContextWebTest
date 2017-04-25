using DbContextWebTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace DbContextWebTest.Context
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext() : base("CarsDbConnectionString") { }
        public DbSet<Cars> Cars { get; set; }
    }
}