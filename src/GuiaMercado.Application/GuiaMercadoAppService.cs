using System;
using System.Collections.Generic;
using System.Text;
using GuiaMercado.Localization;
using Volo.Abp.Application.Services;

namespace GuiaMercado;

/* Inherit your application services from this class.
 */
public abstract class GuiaMercadoAppService : ApplicationService
{
    protected GuiaMercadoAppService()
    {
        LocalizationResource = typeof(GuiaMercadoResource);
    }
}
