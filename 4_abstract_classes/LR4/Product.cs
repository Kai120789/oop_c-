using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    abstract class Product
    {
        public string Price;
        public string Id;
        public string Name;
        
        public Product(string name, string id, string price)
        {
            Name = name;
            Id = id;
            Price = price;
        }


        public abstract string ShowInfo();
    }
}
