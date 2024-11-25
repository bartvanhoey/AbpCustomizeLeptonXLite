using Volo.Abp.Modularity;

namespace AbpCustomizeLeptonXLite;

[DependsOn(
    typeof(AbpCustomizeLeptonXLiteDomainModule),
    typeof(AbpCustomizeLeptonXLiteTestBaseModule)
)]
public class AbpCustomizeLeptonXLiteDomainTestModule : AbpModule
{

}
