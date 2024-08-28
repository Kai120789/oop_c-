using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Fruit: Sklad
    {
        public string Sad;
        public Fruit(string type, string date, string price, string sad) : base(type, date, price)
        {
            Sad = sad;
        }
        public override string ShowInfo()
        {
            string inf;
            inf = "Наименование: " + this.Type + "; Дата: " + this.Date + "; Цена: " + this.Price + "; Сад(город): " + this.Sad + Environment.NewLine + Environment.NewLine;
            return inf;
        }

    }
}
