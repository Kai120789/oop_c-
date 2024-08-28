using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Order
    {
        protected double Price;
        protected double Cost;
        protected string Name;
        protected int Weight;
        public Order(string name, double price, int weight, double cost)
        {
            Price = price;
            Name = name;
            Cost = cost;
            Weight = weight;
        }
        public static Order operator +(Order x, Order y)
        {
            if (x.Cost > y.Cost)
            {
                return new Order(x.Name + ", " + y.Name, x.Price + y.Price, x.Weight + y.Weight, x.Cost);
            }
            else
            {
                return new Order(x.Name + ", " + y.Name, x.Price + y.Price, x.Weight + y.Weight, y.Cost);
            }
        }
        public static bool operator >(Order x, Order y)
        {
            return x.Weight > y.Weight;
        }
        public static bool operator <(Order x, Order y)
        {
            return x.Weight < y.Weight;
        }
        public static implicit operator double(Order x)
        {
            return x.Cost + x.Price;
        }

        public string ShowInfo()
        {
            string inf;
            inf = "Название: " + this.Name + Environment.NewLine + "Цена: " + this.Price + "; Цена доставки: " + this.Cost + "; Вес: " + this.Weight + Environment.NewLine + Environment.NewLine;
            return inf;
        }
    }
}
