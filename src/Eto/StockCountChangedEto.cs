using Volo.Abp.EventBus;

namespace Eto
{
    [EventName("StockCountChanged")]
    public class StockCountChangedEto
    {
        public string ProductCode { get; set; }

        public int NewStockCount { get; set; }
    }
}