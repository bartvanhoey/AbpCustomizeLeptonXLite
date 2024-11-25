using Volo.Abp.Modularity;

namespace AbpCustomizeLeptonXLite;

[DependsOn(
    typeof(AbpCustomizeLeptonXLiteApplicationModule),
    typeof(AbpCustomizeLeptonXLiteDomainTestModule)
)]
public class AbpCustomizeLeptonXLiteApplicationTestModule : AbpModule
{

}
