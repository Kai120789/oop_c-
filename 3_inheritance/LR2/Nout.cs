using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Nout : Product
    {
        public string Diag;
        public string Processor;
        public Nout(string name, string id, string price, string diag, string processor) : base(name, id, price)
        {
            Diag = diag;
            Processor = processor;
        }
        public override string ShowInfo()
        {
            string inf;
            base.ShowInfo();
            inf = "Наименование: " + this.Name + "; ID: " + this.Id + "; Цена: " + this.Price + "; Диагональ: " + this.Diag + "; Процессор: " + this.Processor + Environment.NewLine;
            return inf;
        }

    }
}
