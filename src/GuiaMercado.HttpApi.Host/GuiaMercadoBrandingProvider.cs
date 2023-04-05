using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace GuiaMercado;

[Dependency(ReplaceServices = true)]
public class GuiaMercadoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GuiaMercado";
}
