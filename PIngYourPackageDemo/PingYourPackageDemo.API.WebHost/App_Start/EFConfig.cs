using System.Data.Entity.Migrations;

namespace PingYourPackageDemo.API.WebHost
{
    public class EFConfig
    {
        public static void Initialize()
        {
            RunMigrations();
        }

        private static void RunMigrations()
        {
            var efMigrationSettings = new PingYourPackageDemo.Domain.Migrations.Configuration();
            var efMigrator = new DbMigrator(efMigrationSettings);
            efMigrator.Update();
        }
    }
}
