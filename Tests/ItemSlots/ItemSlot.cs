using System;

namespace Tests
{
    public abstract class ItemSlot
    {
        protected Item _item;
        
        public ItemSlot(Item item)
        {
            _item = item;
        }

        public abstract void DisplayItem();
    }
}