namespace Tests
{
    public class Item
    {
        public string DisplayName { get; set; }
        public int Id { get; set; }
        public int CostToProduce { get; set; }
        public int SalePrice { get; set; }

        public Item(string displayName, int costToProduce, int salePrice)
        {
            DisplayName = displayName;
            CostToProduce = costToProduce;
            SalePrice = salePrice;
        }
        
    }
}