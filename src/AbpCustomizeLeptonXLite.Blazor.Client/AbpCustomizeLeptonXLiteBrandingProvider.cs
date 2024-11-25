using Microsoft.Extensions.Localization;
using AbpCustomizeLeptonXLite.Localization;
using Microsoft.Extensions.Localization;
using AbpCustomizeLeptonXLite.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpCustomizeLeptonXLite.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class AbpCustomizeLeptonXLiteBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpCustomizeLeptonXLiteResource> _localizer;

    public AbpCustomizeLeptonXLiteBrandingProvider(IStringLocalizer<AbpCustomizeLeptonXLiteResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
