using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Tests
{
    internal class TestItems
    {

        public static string TestItemsList() 
        {

            Program.DtoCollection localCollection = new Program.DtoCollection();

            Item item1 = new Item("Test Axe", 3, 9);
            var item2 = new Item("Test Leather Pouch", 1, 6);
            var item3 = new Item("Test Ruby", 20, 100);
            var item4 = new Item("Test Deer Hide", 15, 30);

            localCollection.items.Add(item1);
            localCollection.items.Add(item2);
            localCollection.items.Add(item3);
            localCollection.items.Add(item4);

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var stringLocalItemList = JsonConvert.SerializeObject(localCollection, settings);

            return stringLocalItemList;
        }
    }
}
