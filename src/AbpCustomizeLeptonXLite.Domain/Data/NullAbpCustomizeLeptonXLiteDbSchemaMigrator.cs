using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpCustomizeLeptonXLite.Data;

/* This is used if database provider does't define
 * IAbpCustomizeLeptonXLiteDbSchemaMigrator implementation.
 */
public class NullAbpCustomizeLeptonXLiteDbSchemaMigrator : IAbpCustomizeLeptonXLiteDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
