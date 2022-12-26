using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DMS.SalesManagement2023.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SalesManagement2023DbContextFactory : IDesignTimeDbContextFactory<SalesManagement2023DbContext>
{
    public SalesManagement2023DbContext CreateDbContext(string[] args)
    {
        SalesManagement2023EfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SalesManagement2023DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SalesManagement2023DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DMS.SalesManagement2023.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
