using AbpCustomizeLeptonXLite.Samples;
using Xunit;

namespace AbpCustomizeLeptonXLite.EntityFrameworkCore.Domains;

[Collection(AbpCustomizeLeptonXLiteTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpCustomizeLeptonXLiteEntityFrameworkCoreTestModule>
{

}
