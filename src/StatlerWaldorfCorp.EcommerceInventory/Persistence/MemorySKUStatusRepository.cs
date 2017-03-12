using System.Collections.Generic;

namespace StatlerWaldorfCorp.EcommerceInventory.Persistence
{
    public class MemorySKUStatusRepository : ISKUStatusRepository
    {
        private Dictionary<int, SKUStatus> statuses;

        public MemorySKUStatusRepository()
        {
            this.statuses = new Dictionary<int, SKUStatus>();


            statuses[123] = new SKUStatus
            {
                SKU = 123,
                QtyAvail = 5,
                QtyOnHand = 1,
                QtyBackOrdered = 0,
                QtyOnHold = 0
            };
            statuses[456] = new SKUStatus
            {
                SKU = 456,
                QtyAvail = 30,
                QtyOnHand = 20,
                QtyBackOrdered = 10,
                QtyOnHold = 0
            };
        }

        public SKUStatus Get(int sku)
        {
            return this.statuses[sku];
        }

        public SKUStatus Add(SKUStatus status)
        {
            this.statuses.Add(status.SKU, status);
            return status;
        }
    }
}