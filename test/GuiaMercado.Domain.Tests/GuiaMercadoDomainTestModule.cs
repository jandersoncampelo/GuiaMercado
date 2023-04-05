using GuiaMercado.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace GuiaMercado;

[DependsOn(
    typeof(GuiaMercadoEntityFrameworkCoreTestModule)
    )]
public class GuiaMercadoDomainTestModule : AbpModule
{

}
