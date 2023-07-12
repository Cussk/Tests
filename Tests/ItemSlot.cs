using System;

namespace Tests
{
    public class ItemSlot
    {
        Item _item;
        
        public ItemSlot(Item item)
        {
            _item = item;
        }
        
        public void DisplayItem()
        {
            string displayName = _item.DisplayName;
            Console.WriteLine(displayName);
        }
    }
}