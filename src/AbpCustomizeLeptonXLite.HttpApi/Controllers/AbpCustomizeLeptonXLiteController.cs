using AbpCustomizeLeptonXLite.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpCustomizeLeptonXLite.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpCustomizeLeptonXLiteController : AbpControllerBase
{
    protected AbpCustomizeLeptonXLiteController()
    {
        LocalizationResource = typeof(AbpCustomizeLeptonXLiteResource);
    }
}
