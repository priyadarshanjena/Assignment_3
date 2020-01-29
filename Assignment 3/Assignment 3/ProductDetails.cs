using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class ProductDetails
    {
        public String Name;
        public double Price;
        public int Quantity;
        public String type;
        
        public ProductDetails(string Name, double Price, int Quantity, string type)

        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.type = type;
         }
    }
}
