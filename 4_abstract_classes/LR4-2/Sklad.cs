using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    abstract class Sklad
    {
        public string Price;
        public string Date;
        public string Type;
        
        public Sklad(string type, string date, string price)
        {
            Type = type;
            Date = date;
            Price = price;
        }

        public abstract string ShowInfo();
    }
}
