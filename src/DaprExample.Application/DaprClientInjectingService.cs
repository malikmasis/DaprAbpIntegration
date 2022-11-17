using Dapr.Client;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DaprExample
{
    public class DaprClientInjectingService : ITransientDependency
    {
        private readonly DaprClient _daprClient;

        public DaprClientInjectingService(DaprClient daprClient)
        {
            _daprClient = daprClient;
        }

        public async Task DoItAsync()
        {
            await _daprClient.PublishEventAsync("pubsub", "newOrder", new OrderEto { Id = 1, Amount = 100 });
        }
    }
}
