using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Tests
{
    internal class Program
    {
        static string _path = "C:\\Users\\cussk\\OneDrive\\Documents\\Unity\\Tests\\Tests\\ItemList.json";
        public static void Main(string[] args)
        {
            // make call to item database
            //var itemsFromAPI = API.GetAllItems();

            //call to local items
            var localTestItems = TestItems.TestItemsList();

            // convert items to models
            //var itemModels = JsonConvert.DeserializeObject<DtoCollection>(itemsFromAPI);

            var itemModels = TestItems.TestItemsList();

            // save items locally
            File.WriteAllText(_path, localTestItems);

        }


        public class DtoCollection
        {
            public List<Item> items = new List<Item>();
        }
    }
}