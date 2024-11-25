using System.Threading.Tasks;

namespace AbpCustomizeLeptonXLite.Data;

public interface IAbpCustomizeLeptonXLiteDbSchemaMigrator
{
    Task MigrateAsync();
}
