using System;
namespace InventoryLibrary
{
    public class User:BaseClass
    {
        public String name;

        public User(String name)
        {
            this.name = name;
            Guid guid = Guid.NewGuid();
            this.id = guid.ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }
    }
}