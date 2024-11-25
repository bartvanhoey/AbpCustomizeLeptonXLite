using AbpCustomizeLeptonXLite.Localization;
using Volo.Abp.Application.Services;

namespace AbpCustomizeLeptonXLite;

/* Inherit your application services from this class.
 */
public abstract class AbpCustomizeLeptonXLiteAppService : ApplicationService
{
    protected AbpCustomizeLeptonXLiteAppService()
    {
        LocalizationResource = typeof(AbpCustomizeLeptonXLiteResource);
    }
}
