using Dapr.Client;
using Eto;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DaprExample
{
    public class DaprEventBus : ITransientDependency
    {
        private readonly DaprClient _daprClient;

        public DaprEventBus(DaprClient daprClient)
        {
            _daprClient = daprClient;
        }

        public async Task DoItAsync()
        {
            await _daprClient.PublishEventAsync(
                "pubsub", // pubsub name
                "StockChanged", // topic name 
                new StockCountChangedEto // event data
                {
                    ProductCode = "AT837234",
                    NewStockCount = 42
                }
            );
        }
    }
}
