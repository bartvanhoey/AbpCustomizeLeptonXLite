using AbpCustomizeLeptonXLite.Samples;
using Xunit;

namespace AbpCustomizeLeptonXLite.EntityFrameworkCore.Applications;

[Collection(AbpCustomizeLeptonXLiteTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpCustomizeLeptonXLiteEntityFrameworkCoreTestModule>
{

}
