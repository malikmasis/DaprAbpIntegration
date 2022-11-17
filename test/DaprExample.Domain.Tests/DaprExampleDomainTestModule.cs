using DaprExample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DaprExample;

[DependsOn(
    typeof(DaprExampleEntityFrameworkCoreTestModule)
    )]
public class DaprExampleDomainTestModule : AbpModule
{

}
