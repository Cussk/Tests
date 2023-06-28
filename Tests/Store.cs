using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// This is the store class. We sell items from here.
    /// </summary>
    public class Store
    {
        List<Item> _storeItems;
        
        
        public void InitStoreWithItems(List<Item> items)
        {
            _storeItems = new List<Item>(items);
        }
        
    }
}