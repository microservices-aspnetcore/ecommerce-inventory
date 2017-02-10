namespace StatlerWaldorfCorp.EcommerceInventory
{
    public class SKUStatus
    {
        public int SKU { get; set; }
        public int QtyOnHand { get; set; }
        public int QtyOnHold { get; set; }
        public int QtyAvail { get; set; }
        public int QtyBackOrdered { get; set; }
    }
}