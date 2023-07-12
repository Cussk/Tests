using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// This is the store class. We sell items from here.
    /// </summary>
    public class Store
    {
        List<Item> _storeItems;
        List<ItemSlot> _itemSlots;

        public void InitStoreWithItems(List<Item> items)
        {
            _storeItems = new List<Item>(items);

            _itemSlots = null;

            ItemSlot itemSlot = null;

            foreach (Item item in _storeItems)
            {
                if (item != null)
                {
                    itemSlot = new ItemSlot(item);
                    _itemSlots.Add(itemSlot);
                }
            }

            foreach (ItemSlot slot in _itemSlots)
            {
                if (slot != null)
                {
                    _itemSlots.Add(slot);
                    slot.DisplayItem();
                }
            }

        }
        
    }
}