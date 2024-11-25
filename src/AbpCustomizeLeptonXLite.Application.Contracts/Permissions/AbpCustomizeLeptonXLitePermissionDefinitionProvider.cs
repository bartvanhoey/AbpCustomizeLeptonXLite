using AbpCustomizeLeptonXLite.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AbpCustomizeLeptonXLite.Permissions;

public class AbpCustomizeLeptonXLitePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpCustomizeLeptonXLitePermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpCustomizeLeptonXLitePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpCustomizeLeptonXLiteResource>(name);
    }
}
