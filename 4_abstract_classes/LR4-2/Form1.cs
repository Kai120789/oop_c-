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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
    public void button1_Click(object sender, EventArgs e)
        {
            
            if (label6.Text == "Корзина")
            {
                ResultBox.Clear();
            }
            label6.Text = "Просмотр";
            Sklad new_sklad;
            if(comboBox1.Text == "Фрукты")
            {
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Введите наименование");
                }

                if (comboBox2.Text != "")
                {
                    new_sklad = new Fruit(comboBox2.Text, monthCalendar1.SelectionEnd.Date.ToString(), PriceBox.Text, textBox1.Text);
                    ResultBox.Text += new_sklad.ShowInfo();
                }
                else
                {
                    MessageBox.Show("Введите цену");
                }
            }
            else if (comboBox1.Text == "Овощи")
            {
                

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Введите наименование");
                }

                if (comboBox2.Text != "")
                {
                    new_sklad = new Veg(comboBox2.Text, monthCalendar1.SelectionEnd.Date.ToString(), PriceBox.Text, textBox1.Text);
                    ResultBox.Text += new_sklad.ShowInfo();
                }
                else
                {
                    MessageBox.Show("Введите цену");
                }
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Фрукты")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Яблоки");
                comboBox2.Items.Add("Персики");
                comboBox2.Items.Add("Груши");
                comboBox2.Items.Add("Бананы");
                comboBox2.Items.Add("Сливы");
                label4.Text = "Сад(город)";
            }
            else if(comboBox1.Text == "Овощи")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Помидоры");
                comboBox2.Items.Add("Огурцы");
                comboBox2.Items.Add("Картофель");
                comboBox2.Items.Add("Капуста");
                comboBox2.Items.Add("Морковь");
                label4.Text = "Огород(город)";
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Яблоки");
                comboBox2.Items.Add("Персики");
                comboBox2.Items.Add("Груши");
                comboBox2.Items.Add("Бананы");
                comboBox2.Items.Add("Сливы");
                comboBox2.Items.Add("Помидоры");
                comboBox2.Items.Add("Огурцы");
                comboBox2.Items.Add("Картофель");
                comboBox2.Items.Add("Капуста");
                comboBox2.Items.Add("Морковь");
            }
        }
        public List<object> box = new List<object> { "" };
        int sum = 0;
        public void button2_Click(object sender, EventArgs e)
        {
            
            Sklad new_sklad;
            if(comboBox1.Text == "Фрукты")
            {
                new_sklad = new Fruit(comboBox2.Text, monthCalendar1.SelectionEnd.Date.ToString(), PriceBox.Text, textBox1.Text);
            }
            else
            {
                new_sklad = new Veg(comboBox2.Text, monthCalendar1.SelectionEnd.Date.ToString(), PriceBox.Text, textBox1.Text);
            }
            box[0] += new_sklad.ShowInfo();
            MessageBox.Show("Товар добавлен в корзину");
            sum += Convert.ToInt32(PriceBox.Text);
            
        }

        public void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Корзина";
            ResultBox.Clear();
            for (int j = 0; j < 1; j++)
            {
                
                ResultBox.Text += box[j];
            }
            sumBox.Text = Convert.ToString(sum);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Яблоки")
            {
                PriceBox.Clear();
                textBox1.Clear();
                label4.Text = "Сад(город)";
                PriceBox.Text += "60";
                textBox1.Text += "Астрахань";
            }
            else if (comboBox2.Text == "Персики")
            {
                PriceBox.Clear();
                textBox1.Clear();
                label4.Text = "Сад(город)";
                PriceBox.Text += "120";
                textBox1.Text += "Сухум";
            }
            else if (comboBox2.Text == "Груши")
            {
                PriceBox.Clear();
                textBox1.Clear();
                label4.Text = "Сад(город)";
                PriceBox.Text += "90";
                textBox1.Text += "Абиск";
            }
            else if (comboBox2.Text == "Бананы")
            {
                PriceBox.Clear();
                textBox1.Clear();
                label4.Text = "Сад(город)";
                PriceBox.Text += "70";
                textBox1.Text += "Сочи";
            }
            else if (comboBox2.Text == "Сливы")
            {
                PriceBox.Clear();
                textBox1.Clear();
                label4.Text = "Сад(город)";
                PriceBox.Text += "35990";
                textBox1.Text += "Волжск";
            }
            else if (comboBox2.Text == "Помидоры")
            {
                PriceBox.Clear();
                textBox1.Clear();
                label4.Text = "Огород(город)";
                PriceBox.Text += "110";
                textBox1.Text += "Волгоград";
            }
            else if (comboBox2.Text == "Огурцы")
            {
                PriceBox.Clear();
                textBox1.Clear();
                label4.Text = "Огород(город)";
                PriceBox.Text += "90";
                textBox1.Text += "Краснодар";
            }
            else if (comboBox2.Text == "Картофель")
            {
                PriceBox.Clear();
                textBox1.Clear();
                label4.Text = "Огород(город)";
                PriceBox.Text += "50";
                textBox1.Text += "Тула";
            }
            else if (comboBox2.Text == "Морковь")
            {
                PriceBox.Clear();
                textBox1.Clear();
                label4.Text = "Огород(город)";
                PriceBox.Text += "40";
                textBox1.Text += "Краснодар";
            }
            else if (comboBox2.Text == "Капуста")
            {
                PriceBox.Clear();
                textBox1.Clear();
                label4.Text = "Огород(город)";
                PriceBox.Text += "130";
                textBox1.Text += "Астрахань";
            }
        }
    }
}
