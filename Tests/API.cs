using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tests
{
    /// <summary>
    /// This is a fake API. We will make a call to it to get our items
    /// </summary>
    public static class API
    {
        // completely ignore the code in here. Its just faking what would occur when we call
        // for a list of game items from the API
        public static string GetAllItems()
        {

            Program.DtoCollection collection = new Program.DtoCollection();
            
            Item item1 = new Item("Axe", 3, 9);
            var item2 = new Item("Leather Pouch", 1, 6);
            var item3 = new Item("Ruby", 20, 100);
            var item4 = new Item("Deer Hide", 15, 30);
            
            collection.items.Add(item1);
            collection.items.Add(item2);
            collection.items.Add(item3);
            collection.items.Add(item4);

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var stringItemList = JsonConvert.SerializeObject(collection, settings);

            return stringItemList;
        }
    }
}