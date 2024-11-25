using Volo.Abp.Settings;

namespace AbpCustomizeLeptonXLite.Settings;

public class AbpCustomizeLeptonXLiteSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpCustomizeLeptonXLiteSettings.MySetting1));
    }
}
