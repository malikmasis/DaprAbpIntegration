using Eto;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace DaprExample.HttpApi.Client.ConsoleTestApp;

public class ClientDemoService : ITransientDependency
{
    private readonly IDistributedEventBus _eventBus;

    public ClientDemoService(IDistributedEventBus eventBus)
    {
        _eventBus = eventBus;
    }

    public async Task RunAsync()
    {
        Console.WriteLine("Publishing events");
        for (var i = 0; i < 10; i++)
        {
            await _eventBus.PublishAsync(
                new StockCountChangedEto
                {
                    ProductCode = $"Product {i}",
                    NewStockCount = i
                }

            );

            Console.WriteLine($"{i} Event publishing complete!");

            await Task.Delay(2500);
        }
    }
}
