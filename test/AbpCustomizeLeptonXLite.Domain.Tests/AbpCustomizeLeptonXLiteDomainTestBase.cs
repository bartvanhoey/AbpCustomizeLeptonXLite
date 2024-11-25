using Volo.Abp.Modularity;

namespace AbpCustomizeLeptonXLite;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpCustomizeLeptonXLiteDomainTestBase<TStartupModule> : AbpCustomizeLeptonXLiteTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
