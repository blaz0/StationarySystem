using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationarySystem
{
    class Product
    {
        public int productid { get; set; }
        public int supplierid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int stock { get; set; }
        public int price { get; set; }
        public string stockLevel { get; set; }
        
        public Product()
        { }

        public static int SubtractQuantity(int originalQty, int amount)
        {
            // Subtract quantity from the original quantity.
            return originalQty - amount;
        }

        public static int AddQuantity(int originalQty, int amount)
        {
            // Add quantity to the original quantity.
            return originalQty + amount;
        }

        public static bool CheckQuantity(int currentStock, int amount)
        {
            // Check if there is enough stock.
            if (currentStock >= amount)
            {
                return true;
            }
            return false;
        }
    }
}
