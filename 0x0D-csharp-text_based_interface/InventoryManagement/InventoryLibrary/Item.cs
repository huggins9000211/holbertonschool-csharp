using System;
using System.Collections.Generic;
namespace InventoryLibrary
{
    public class Item:BaseClass
    {
        
        public String name{ get; set; }

        public String description{ get; set; }
        public float price{ get; set; }
        public List<String> tags{ get; set; }

        public Item(String name, String description = "No discription", float price = 0.0f, List<String> tags = null)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.tags = tags;
            Guid guid = Guid.NewGuid();
            this.id = guid.ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }
    }
}