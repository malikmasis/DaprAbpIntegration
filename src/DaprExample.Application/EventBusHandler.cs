using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace DaprExample
{
    public class EventBusHandler :
    IDistributedEventHandler<StockCountChangedEto>,
    ITransientDependency
    {
        public async Task HandleEventAsync(StockCountChangedEto eventData)
        {
            var productCode = eventData.ProductCode;
            // ...
        }
    }
}
