using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            USD[] usd = new USD[13];

            usd[0] = new USD("Март", 98.00);
            usd[1] = new USD("Апрель", 80.75);
            usd[2] = new USD("Май", 66.50);
            usd[3] = new USD("Июнь", 57.25);
            usd[4] = new USD("Июль", 57.00);
            usd[5] = new USD("Август", 62.00);
            usd[6] = new USD("Сенятбрь", 59.62);
            usd[7] = new USD("Октябрь", 62.65);
            usd[8] = new USD("Ноябрь", 61.40);
            usd[9] = new USD("Декабрь", 64.65);
            usd[10] = new USD("Январь", 66.00);
            usd[11] = new USD("Февраль", 75.40);

            usd[12] = new USD("", 1);

            if (comboBox1.Text == "Март")
            {
                
                textBox3.Text = Convert.ToString((double)usd[0]);
            }
            else if (comboBox1.Text == "Апрель")
            {
                
                textBox3.Text = Convert.ToString((double)usd[1]);
            }
            else if (comboBox1.Text == "Май")
            {
                
                textBox3.Text = Convert.ToString((double)usd[2]);
            }
            else if (comboBox1.Text == "Июнь")
            {
                
                textBox3.Text = Convert.ToString((double)usd[3]);
            }
            else if (comboBox1.Text == "Июль")
            {
                
                textBox3.Text = Convert.ToString((double)usd[4]);
            }
            else if (comboBox1.Text == "Август")
            {
                
                textBox3.Text = Convert.ToString((double)usd[5]);
            }
            else if (comboBox1.Text == "Сенятбрь")
            {
                
                textBox3.Text = Convert.ToString((double)usd[6]);
            }
            else if (comboBox1.Text == "Октябрь")
            {
                
                textBox3.Text = Convert.ToString((double)usd[7]);
            }
            else if (comboBox1.Text == "Ноябрь")
            {
                
                textBox3.Text = Convert.ToString((double)usd[8]);
            }
            else if (comboBox1.Text == "Декабрь")
            {
                
                textBox3.Text = Convert.ToString((double)usd[9]);
            }
            else if (comboBox1.Text == "Январь")
            {
                
                textBox3.Text = Convert.ToString((double)usd[10]);
            }
            else if (comboBox1.Text == "Февраль")
            {
                
                textBox3.Text = Convert.ToString((double)usd[11]);
            }
            
            
            for (int i = 0; i < 11; i++)
            {
                if (usd[i] > usd[12])
                {
                    usd[12] = usd[i];
                }
            }
            textBox4.Text = Convert.ToString((double)usd[12]);
        }

        public void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Максимальный курс доллара за год - 98 рублей");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text), 3));
                textBox2.Refresh();
            }
            else
            {
                MessageBox.Show("Введите значение");
            }
        }
    }
}
