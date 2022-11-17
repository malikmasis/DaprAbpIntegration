using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace DaprExample
{
    public class EventBusService : ITransientDependency
    {
        private readonly IDistributedEventBus _distributedEventBus;

        public EventBusService(IDistributedEventBus distributedEventBus)
        {
            _distributedEventBus = distributedEventBus;
        }

        public async Task DoItAsync()
        {
            await _distributedEventBus.PublishAsync(new StockCountChangedEto
            {
                ProductCode = "AT837234",
                NewStockCount = 42
            });
        }
    }
}
