using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class RarityItemSlot : ItemSlot
    {
        public static bool rarityIventory = true;

        public RarityItemSlot(Item item) : base(item)
        {

        }

        public override void DisplayItem()
        {
            int rarity = _item.Rarity;
            Console.WriteLine(rarity);
        }
    }
}
