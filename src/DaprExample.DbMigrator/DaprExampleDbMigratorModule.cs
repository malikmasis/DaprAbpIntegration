using DaprExample.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DaprExample.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DaprExampleEntityFrameworkCoreModule),
    typeof(DaprExampleApplicationContractsModule)
    )]
public class DaprExampleDbMigratorModule : AbpModule
{

}
