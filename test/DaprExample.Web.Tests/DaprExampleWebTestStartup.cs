using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace DaprExample;

public class DaprExampleWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<DaprExampleWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
