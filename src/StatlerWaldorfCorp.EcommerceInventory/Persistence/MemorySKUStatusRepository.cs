using System.Collections.Generic;

namespace StatlerWaldorfCorp.EcommerceInventory.Persistence
{
    public class MemorySKUStatusRepository : ISKUStatusRepository
    {
        private Dictionary<int, SKUStatus> statuses;

        public MemorySKUStatusRepository()
        {
            this.statuses = new Dictionary<int, SKUStatus>();
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