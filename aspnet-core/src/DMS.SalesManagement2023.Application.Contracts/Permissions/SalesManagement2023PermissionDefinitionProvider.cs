using DMS.SalesManagement2023.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DMS.SalesManagement2023.Permissions;

public class SalesManagement2023PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SalesManagement2023Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SalesManagement2023Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SalesManagement2023Resource>(name);
    }
}
