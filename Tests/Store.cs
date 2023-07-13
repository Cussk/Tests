using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// This is the store class. We sell items from here.
    /// </summary>
    public class Store
    {

        List<Item> _storeItems;
        List<Item> _playerItems;
        List<Item> _rarityItems;
        List<RarityItemSlot> _rarityItemSlots;
        List<NamePriceItemSlot> _namePriceItemSlots;
        List<NameRarityItemSlot> _nameRarityItemSlots;

        public void InitStoreWithItems(List<Item> items)
        {
            _storeItems = new List<Item>(items);
            _playerItems = new List<Item>(items);
            _rarityItems = new List<Item>(items);

            _rarityItemSlots = null;
            _namePriceItemSlots = null;
            _nameRarityItemSlots = null;

            NamePriceItemSlot namePriceItemSlot = null;
            NameRarityItemSlot nameRarityItemSlot = null;
            RarityItemSlot rarityItemSlot = null;

            if (NameRarityItemSlot.playerInventory == true)
            {
                foreach (Item item in _playerItems)
                {
                    if(item != null)
                    {
                        nameRarityItemSlot = new NameRarityItemSlot(item);
                        _nameRarityItemSlots.Add(nameRarityItemSlot);
                    }
                }
                foreach (NameRarityItemSlot slot in _nameRarityItemSlots)
                {
                    if (slot != null)
                    {
                        slot.DisplayItem();
                    }
                }
            }
            else if (RarityItemSlot.rarityIventory == true)
            {
                foreach (Item item in _rarityItems)
                {
                    if (item != null)
                    {
                        rarityItemSlot = new RarityItemSlot(item);
                        _rarityItemSlots.Add(rarityItemSlot);
                    }
                }
                foreach (RarityItemSlot slot in _rarityItemSlots)
                {
                    slot.DisplayItem();
                }
            }
            else
            {
                foreach (Item item in _storeItems)
                {
                    if (item != null)
                    {
                        namePriceItemSlot = new NamePriceItemSlot(item);
                        _namePriceItemSlots.Add(namePriceItemSlot);
                    }
                }

                foreach (NamePriceItemSlot slot in _namePriceItemSlots)
                {
                    if (slot != null)
                    {
                        slot.DisplayItem();
                    }
                }
            }
            

        }
        
    }
}