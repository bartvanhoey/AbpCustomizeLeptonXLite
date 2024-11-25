using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpCustomizeLeptonXLite.Data;
using Volo.Abp.DependencyInjection;

namespace AbpCustomizeLeptonXLite.EntityFrameworkCore;

public class EntityFrameworkCoreAbpCustomizeLeptonXLiteDbSchemaMigrator
    : IAbpCustomizeLeptonXLiteDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpCustomizeLeptonXLiteDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpCustomizeLeptonXLiteDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpCustomizeLeptonXLiteDbContext>()
            .Database
            .MigrateAsync();
    }
}
