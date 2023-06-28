using System.Collections.Generic;

namespace Tests
{
    public class Player
    {
        List<Item> _playersItems;
        Item _equippedItem;
        
        public void GrantItemsToPlayer(List<Item> items)
        {
            _playersItems = new List<Item>(items);
        }

        public void UseEquippedItem()
        {
            
            
            
        }
    }
}