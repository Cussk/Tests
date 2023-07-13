using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class NamePriceItemSlot : ItemSlot
    {
        public static bool storeInventory = true;

        public NamePriceItemSlot(Item item) : base(item)
        {
            
        }

        public override void DisplayItem()
        {
            string displayName = _item.DisplayName;
            int salePrice = _item.SalePrice;

            Console.WriteLine(displayName);
            Console.WriteLine(salePrice);
        }
    }
}
