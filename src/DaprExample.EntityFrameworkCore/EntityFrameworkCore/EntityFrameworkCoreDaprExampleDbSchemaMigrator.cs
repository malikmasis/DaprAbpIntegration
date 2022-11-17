using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DaprExample.Data;
using Volo.Abp.DependencyInjection;

namespace DaprExample.EntityFrameworkCore;

public class EntityFrameworkCoreDaprExampleDbSchemaMigrator
    : IDaprExampleDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDaprExampleDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DaprExampleDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DaprExampleDbContext>()
            .Database
            .MigrateAsync();
    }
}
