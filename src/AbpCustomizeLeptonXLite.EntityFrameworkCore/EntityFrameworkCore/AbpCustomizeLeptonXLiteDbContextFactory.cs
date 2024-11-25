using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpCustomizeLeptonXLite.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpCustomizeLeptonXLiteDbContextFactory : IDesignTimeDbContextFactory<AbpCustomizeLeptonXLiteDbContext>
{
    public AbpCustomizeLeptonXLiteDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AbpCustomizeLeptonXLiteEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AbpCustomizeLeptonXLiteDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new AbpCustomizeLeptonXLiteDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpCustomizeLeptonXLite.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
