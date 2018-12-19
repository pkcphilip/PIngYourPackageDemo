namespace PingYourPackageDemo.Domain.Migrations
{
    using PingYourPackageDemo.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<PingYourPackageDemo.Domain.Entities.Core.EntitiesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PingYourPackageDemo.Domain.Entities.Core.EntitiesContext context)
        {
            context.Roles.AddOrUpdate(role => role.Name,
                new Role { Key = Guid.NewGuid(), Name = "Admin" },
                new Role { Key = Guid.NewGuid(), Name = "Employee" },
                new Role { Key = Guid.NewGuid(), Name = "Affiliate" }
            );
        }
    }
}
