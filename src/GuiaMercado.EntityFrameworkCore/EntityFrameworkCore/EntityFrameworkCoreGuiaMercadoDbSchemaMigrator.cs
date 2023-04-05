using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GuiaMercado.Data;
using Volo.Abp.DependencyInjection;

namespace GuiaMercado.EntityFrameworkCore;

public class EntityFrameworkCoreGuiaMercadoDbSchemaMigrator
    : IGuiaMercadoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreGuiaMercadoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the GuiaMercadoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<GuiaMercadoDbContext>()
            .Database
            .MigrateAsync();
    }
}
