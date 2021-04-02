using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
namespace InventoryLibrary
{
    public class JSONStorage
    {
        public Dictionary<String, String> objects;

        public JSONStorage()
        {

        }
        public void Save()
        {
            String tbs = JsonSerializer.Serialize<Dictionary<String, String>>(objects);
            File.WriteAllText("InventoryLibrary/storage/inventory_manager.json", tbs);
            File.WriteAllText("InventoryLibrary/storage/inventory_manager.json", tbs);

        }
        public void New(dynamic obj)
        {
            // Console.WriteLine(obj.GetType().Name);
            // string test = JsonSerializer.Serialize<Item>(obj);
            // Item testing = JsonSerializer.Deserialize<Item>(test);

            // Console.WriteLine($"**{testing.name}****");
            // Console.WriteLine(JsonSerializer.Serialize<Item>(obj));
            objects.Add($"{obj.GetType().Name}.{obj.id}", JsonSerializer.Serialize<dynamic>(obj));
        }
        public void Load()
        {
            string jsonString = File.ReadAllText("InventoryLibrary/storage/inventory_manager.json");
            try
            {
                objects = JsonSerializer.Deserialize<Dictionary<String, String>>(jsonString);
            }
            catch (System.Text.Json.JsonException ex)
            {
                objects = new Dictionary<String, String>();
                Console.WriteLine("It Worked!");
            }
        }
        public Dictionary<String, String> All()
        {
            return objects;
        }






        // static public void Main(String[] args)
        // {
        //     Console.WriteLine("Main Method");
        // }
    }
}