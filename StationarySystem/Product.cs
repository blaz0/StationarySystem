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
    }

    public static int subtractQuantity(int originalQty, int amount)
    {
        return originalQty - amount;
    }
}
