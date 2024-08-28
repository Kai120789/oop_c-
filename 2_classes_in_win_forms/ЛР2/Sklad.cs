using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР2
{
    class Sklad
    {
        
        string name;
        int mass;
        DateTime date;
        public Sklad(string name, int mass, DateTime date)
        {
            this.name = name;
            this.mass = mass;
            this.date = date;
        }
        public Sklad(string name)
        {
            this.name = name;
        }
        public Sklad(string name, int mass)
        {
            this.name = name;
            this.mass = mass;
        }

        public string GetInformation()
        {
            string information;
            information = "Название: " + this.name + "; Дата завоза: " + this.date.ToString() + "; Цена за кг(руб): " + this.mass + Environment.NewLine + Environment.NewLine;
            return information;
        }
    }
}
