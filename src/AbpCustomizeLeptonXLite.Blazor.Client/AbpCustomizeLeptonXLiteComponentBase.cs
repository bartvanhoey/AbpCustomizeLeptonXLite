using AbpCustomizeLeptonXLite.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpCustomizeLeptonXLite.Blazor.Client;

public abstract class AbpCustomizeLeptonXLiteComponentBase : AbpComponentBase
{
    protected AbpCustomizeLeptonXLiteComponentBase()
    {
        LocalizationResource = typeof(AbpCustomizeLeptonXLiteResource);
    }
}
