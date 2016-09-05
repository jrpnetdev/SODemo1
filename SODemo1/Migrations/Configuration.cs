using SODemo1.Models;

namespace SODemo1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SODemo1.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<SODemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SODemoContext context)
        {
            context.MyModels.AddOrUpdate(x => x.Id,
                new MyModel() { Id = 1, Text = "One", Description = "Beer" },
                new MyModel() { Id = 2, Text = "Two", Description = "Wine" },
                new MyModel() { Id = 3, Text = "Three", Description = "Spirits" },
                new MyModel() { Id = 4, Text = "Four", Description = "Soft Drinks" }
            );
        }
    }
}
