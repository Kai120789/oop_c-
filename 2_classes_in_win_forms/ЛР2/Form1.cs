using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Sklad new_sklad;
            if (NameBox.Text == "")
            {
                MessageBox.Show("Введите название");
            }

            if (ProfessionBox.Text != "")
            {
                new_sklad = new Sklad(NameBox.Text, Convert.ToInt32(ProfessionBox.Text), monthCalendar1.SelectionEnd.Date);
                ResultBox.Text += new_sklad.GetInformation();
            }
            else
            {
                MessageBox.Show("Введите цену");
            }
        }

    }
}
