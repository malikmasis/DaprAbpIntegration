using Eto;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace DaprExample
{
    public class EventBusHandler : IDistributedEventHandler<StockCountChangedEto>, ITransientDependency
    {
        public Task HandleEventAsync(StockCountChangedEto eventData)
        {
            Console.WriteLine($"Product: {eventData.ProductCode}. Date: {eventData.NewStockCount}");
            return Task.CompletedTask;
        }
    }
}
