using System;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Volo.Abp.Autofac;
using Volo.Abp.Dapr;
using Volo.Abp.EventBus.Dapr;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace DaprExample.HttpApi.Client.ConsoleTestApp;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DaprExampleHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule),
    typeof(AbpEventBusDaprModule)//TODO don't forget
    )]
public class DaprExampleConsoleApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDaprOptions>(options =>
        {
            options.HttpEndpoint = "http://localhost:8002";
            options.GrpcEndpoint = "http://localhost:8003";
        });

        Configure<AbpDaprEventBusOptions>(options =>
        {
            options.PubSubName = "test-pubsub";
        });
    }
    
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<AbpHttpClientBuilderOptions>(options =>
        {
            options.ProxyClientBuildActions.Add((remoteServiceName, clientBuilder) =>
            {
                clientBuilder.AddTransientHttpErrorPolicy(
                    policyBuilder => policyBuilder.WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(Math.Pow(2, i)))
                );
            });
        });


    }
}
