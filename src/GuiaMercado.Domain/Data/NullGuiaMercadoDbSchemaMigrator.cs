using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace GuiaMercado.Data;

/* This is used if database provider does't define
 * IGuiaMercadoDbSchemaMigrator implementation.
 */
public class NullGuiaMercadoDbSchemaMigrator : IGuiaMercadoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
