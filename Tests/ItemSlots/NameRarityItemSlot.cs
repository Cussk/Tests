using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class NameRarityItemSlot : ItemSlot
    {

        public static bool playerInventory = true;
        public NameRarityItemSlot(Item item) : base(item)
        {

        }

        public override void DisplayItem()
        {
            string displayName = _item.DisplayName;
            int rarity = _item.Rarity;

            Console.WriteLine(displayName);
            Console.WriteLine(rarity);
        }
    }
}
