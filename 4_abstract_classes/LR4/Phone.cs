using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Phone: Product
    {
        public string Diag;
        public string Cam;
        public Phone(string name, string id, string price, string diag, string cam) : base(name, id, price)
        {
            Diag = diag;
            Cam = cam;
        }
        public override string ShowInfo()
        {
            string inf;
            inf = "Наименование: " + this.Name + "; ID: " + this.Id + "; Цена: " + this.Price + "; Диагональ: " + this.Diag + "; Камера: " + this.Cam + Environment.NewLine + Environment.NewLine;
            return inf;
        }

    }
}
