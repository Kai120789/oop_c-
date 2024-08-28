using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Veg : Sklad
    {
        public string Ogorod;
        public Veg(string type, string id, string price, string ogorod) : base(type, id, price)
        {
            Ogorod = ogorod;
        }
        public override string ShowInfo()
        {
            string inf;
            base.ShowInfo();
            inf = "Наименование: " + this.Type + "; Дата: " + this.Date + "; Цена: " + this.Price + "; Огород(город): " + this.Ogorod + Environment.NewLine;
            return inf;
        }

    }
}
