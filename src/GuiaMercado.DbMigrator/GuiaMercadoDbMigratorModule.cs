using GuiaMercado.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace GuiaMercado.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GuiaMercadoEntityFrameworkCoreModule),
    typeof(GuiaMercadoApplicationContractsModule)
    )]
public class GuiaMercadoDbMigratorModule : AbpModule
{

}
