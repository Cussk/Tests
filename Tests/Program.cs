using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Tests
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var itemsFromAPI = API.GetAllItems();
            
            string _pathToJsonFile = "C:\\Users\\MartyCarr\\RiderProjects\\Tests\\Tests\\ItemList.json";


            var itemDtos = JsonConvert.DeserializeObject<DtoCollection>(itemsFromAPI);
            
            
            
            File.WriteAllText(_pathToJsonFile, itemsFromAPI);
            

        }
        

        public class DtoCollection
        {
            public List<Item> items = new List<Item>();
        }
    }
}