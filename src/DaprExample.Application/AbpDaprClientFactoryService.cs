using Dapr.Client;
using System.Net.Http;
using System.Threading.Tasks;
using Volo.Abp.Dapr;
using Volo.Abp.DependencyInjection;

namespace DaprExample
{
    public class AbpDaprClientFactoryService : ITransientDependency
    {
        private readonly IAbpDaprClientFactory _daprClientFactory;

        public AbpDaprClientFactoryService(IAbpDaprClientFactory daprClientFactory)
        {
            _daprClientFactory = daprClientFactory;
        }

        public async Task DoItAsync()
        {
            //TODO Create or CreateAsync ??
            // Create a DaprClient object with default options
            DaprClient daprClient =  _daprClientFactory.Create();
            
            /* Create a DaprClient object with configuring
             * the DaprClientBuilder object */
            DaprClient daprClient2 =  _daprClientFactory
                .Create(builder =>
                {
                    builder.UseDaprApiToken("...");
                });

            // Create an HttpClient object
            HttpClient httpClient =  _daprClientFactory
                .CreateHttpClient("target-app-id");
        }
    }
}
