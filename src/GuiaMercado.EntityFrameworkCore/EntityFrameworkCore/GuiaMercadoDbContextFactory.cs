using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace GuiaMercado.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class GuiaMercadoDbContextFactory : IDesignTimeDbContextFactory<GuiaMercadoDbContext>
{
    public GuiaMercadoDbContext CreateDbContext(string[] args)
    {
        GuiaMercadoEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<GuiaMercadoDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new GuiaMercadoDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../GuiaMercado.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
