using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Tests
{
    internal class Program
    {
        static string _path = "C:\\Users\\MartyCarr\\RiderProjects\\Tests\\Tests\\ItemList.json";
        public static void Main(string[] args)
        {
            // make call to item database
            var itemsFromAPI = API.GetAllItems();
            
            // convert items to models
            var itemModels = JsonConvert.DeserializeObject<DtoCollection>(itemsFromAPI);
            
            // save items locally
            File.WriteAllText(_path, itemsFromAPI);
            

        }
        

        public class DtoCollection
        {
            public List<Item> items = new List<Item>();
        }
    }
}