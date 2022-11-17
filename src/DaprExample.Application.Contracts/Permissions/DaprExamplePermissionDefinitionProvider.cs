using DaprExample.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DaprExample.Permissions;

public class DaprExamplePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DaprExamplePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DaprExamplePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DaprExampleResource>(name);
    }
}
