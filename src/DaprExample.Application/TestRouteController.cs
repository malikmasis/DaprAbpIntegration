using Dapr;
using Eto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.Dapr;

namespace DaprExample
{
    public class TestRouteController : AbpController
    {
        protected IEventBusService DaprEventBus { get; }

        public TestRouteController(IEventBusService daprEventBus)
        {
            DaprEventBus = daprEventBus;
        }

        [HttpPost("/stock-changed")]
        [Topic("test-pubsub", "StockChanged")]
        public async Task<IActionResult> TestRouteAsync([FromBody] StockCountChangedEto model)
        {
            // Validate the App API token!
            HttpContext.ValidateDaprAppApiToken();

            // Do something with the event
            return Ok();
        }

        [HttpPost("/send")]
        public async Task<IActionResult> DoItAsync()
        {
            await DaprEventBus.DoItAsync();
            return Ok();
        }
    }
}
