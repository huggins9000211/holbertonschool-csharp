using System;
namespace InventoryLibrary
{
    public class Inventory:BaseClass
    {
        public String user_id;
        public String item_id;
        public int quantity;

        public Inventory(String user_id, String item_id, int quantity)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            this.quantity = quantity;
        }
    }
}