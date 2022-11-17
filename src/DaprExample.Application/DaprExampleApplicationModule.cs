using Volo.Abp.Account;
using Volo.Abp.AspNetCore.Mvc.Dapr.EventBus;
using Volo.Abp.AutoMapper;
using Volo.Abp.Dapr;
using Volo.Abp.EventBus.Dapr;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace DaprExample;

[DependsOn(
    typeof(DaprExampleDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(DaprExampleApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule),
    typeof(AbpDaprModule),
    typeof(AbpAspNetCoreMvcDaprEventBusModule)
    )]
public class DaprExampleApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<DaprExampleApplicationModule>();
        });

        Configure<AbpDaprEventBusOptions>(options =>
        {
            options.PubSubName = "pubsub";
        });
    }
}
