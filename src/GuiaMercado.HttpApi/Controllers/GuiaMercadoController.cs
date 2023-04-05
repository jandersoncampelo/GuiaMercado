using GuiaMercado.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace GuiaMercado.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GuiaMercadoController : AbpControllerBase
{
    protected GuiaMercadoController()
    {
        LocalizationResource = typeof(GuiaMercadoResource);
    }
}
