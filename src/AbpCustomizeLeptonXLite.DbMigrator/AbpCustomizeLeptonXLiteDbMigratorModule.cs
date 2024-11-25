using AbpCustomizeLeptonXLite.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpCustomizeLeptonXLite.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCustomizeLeptonXLiteEntityFrameworkCoreModule),
    typeof(AbpCustomizeLeptonXLiteApplicationContractsModule)
)]
public class AbpCustomizeLeptonXLiteDbMigratorModule : AbpModule
{
}
