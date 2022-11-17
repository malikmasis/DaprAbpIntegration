using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DaprExample.Data;

/* This is used if database provider does't define
 * IDaprExampleDbSchemaMigrator implementation.
 */
public class NullDaprExampleDbSchemaMigrator : IDaprExampleDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
