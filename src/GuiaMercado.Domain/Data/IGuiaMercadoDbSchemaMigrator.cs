using System.Threading.Tasks;

namespace GuiaMercado.Data;

public interface IGuiaMercadoDbSchemaMigrator
{
    Task MigrateAsync();
}
