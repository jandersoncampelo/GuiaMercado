using Volo.Abp.Modularity;

namespace GuiaMercado;

[DependsOn(
    typeof(GuiaMercadoApplicationModule),
    typeof(GuiaMercadoDomainTestModule)
    )]
public class GuiaMercadoApplicationTestModule : AbpModule
{

}
