using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SODemo1.Models;

namespace SODemo1.Data
{
    public class SODemoContext : DbContext
    {
        public SODemoContext() : base("SODemoConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SODemoContext>());
        }

        public DbSet<MyModel> MyModels { get; set; }
    }
}