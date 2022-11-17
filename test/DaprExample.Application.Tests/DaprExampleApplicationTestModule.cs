using Volo.Abp.Modularity;

namespace DaprExample;

[DependsOn(
    typeof(DaprExampleApplicationModule),
    typeof(DaprExampleDomainTestModule)
    )]
public class DaprExampleApplicationTestModule : AbpModule
{

}
