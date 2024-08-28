using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Product
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
 
        
        public virtual string ShowInfo()
        {
            string information;
            information = "Наименование: " + this.Name + "; ID: " + this.Id + "; Цена: " + this.Price + Environment.NewLine + Environment.NewLine;
            return information;
        }
    }
}
