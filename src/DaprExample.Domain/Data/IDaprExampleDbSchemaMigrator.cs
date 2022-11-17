using System.Threading.Tasks;

namespace DaprExample.Data;

public interface IDaprExampleDbSchemaMigrator
{
    Task MigrateAsync();
}
