
namespace StatlerWaldorfCorp.EcommerceInventory.Persistence
{
    public interface ISKUStatusRepository
    {
        SKUStatus Get(int sku);    
        SKUStatus Add(SKUStatus status);    
    }
}