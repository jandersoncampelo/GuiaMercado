using GuiaMercado.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace GuiaMercado.Permissions;

public class GuiaMercadoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GuiaMercadoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GuiaMercadoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GuiaMercadoResource>(name);
    }
}
