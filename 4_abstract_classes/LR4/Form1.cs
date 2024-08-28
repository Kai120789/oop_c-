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
            if(label8.Text == "Корзина")
            {
                ResultBox.Clear();
            }
            label8.Text = "Просмотр";
            
            Product new_product;
            if(comboBox1.Text == "Телефон")
            {
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Введите наименование");
                }

                if (IdBox.Text != "")
                {
                    new_product = new Phone(comboBox2.Text, IdBox.Text, PriceBox.Text, textBox1.Text, textBox2.Text);
                    ResultBox.Text += new_product.ShowInfo();
                }
                else
                {
                    MessageBox.Show("Введите цену");
                }
            }
            else if (comboBox1.Text == "Ноутбук")
            {
                

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Введите наименование");
                }

                if (IdBox.Text != "")
                {
                    new_product = new Nout(comboBox2.Text, IdBox.Text, PriceBox.Text, textBox1.Text, textBox2.Text);
                    ResultBox.Text += new_product.ShowInfo();
                }
                else
                {
                    MessageBox.Show("Введите цену");
                }
            }
            
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Телефон")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Iphone 12");
                comboBox2.Items.Add("Samsung Galaxy S20");
                comboBox2.Items.Add("Redmi Note 11");
                comboBox2.Items.Add("POCO X3 Pro");
                comboBox2.Items.Add("Asus ROG 3");
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Камера(мп)";
            }
            else if(comboBox1.Text == "Ноутбук")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Huawei MateBook");
                comboBox2.Items.Add("MacBook");
                comboBox2.Items.Add("Lenovo IdeaPad");
                comboBox2.Items.Add("Honor MagicBook");
                comboBox2.Items.Add("Acer Aspire");
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Процессор";
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Iphone 12");
                comboBox2.Items.Add("Samsung Galaxy S20");
                comboBox2.Items.Add("Redmi Note 11");
                comboBox2.Items.Add("POCO X3 Pro");
                comboBox2.Items.Add("Asus ROG 3");
                comboBox2.Items.Add("Huawei MateBook");
                comboBox2.Items.Add("MacBook");
                comboBox2.Items.Add("Lenovo IdeaPad");
                comboBox2.Items.Add("Honor MagicBook");
                comboBox2.Items.Add("Acer Aspire");
            }
        }
        public List<object> box = new List<object> { "" };
        int sum = 0;
        public void button2_Click(object sender, EventArgs e)
        {
            
            Product new_product;
            if(comboBox1.Text == "Телефон")
            {
                new_product = new Phone(comboBox2.Text, IdBox.Text, PriceBox.Text, textBox1.Text, textBox2.Text);
            }
            else
            {
                new_product = new Nout(comboBox2.Text, IdBox.Text, PriceBox.Text, textBox1.Text, textBox2.Text);
            }
            box[0] += new_product.ShowInfo();
            MessageBox.Show("Товар добавлен в корзину");
            sum += Convert.ToInt32(PriceBox.Text);
            
        }

        public void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "Корзина";
            ResultBox.Clear();
            for (int j = 0; j < 1; j++)
            {
                
                ResultBox.Text += box[j];
            }
            sumBox.Text = Convert.ToString(sum);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Iphone 12")
            {
                IdBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                textBox2.Clear();
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Камера(мп)";
                IdBox.Text += "1";
                PriceBox.Text += "44990";
                textBox1.Text += "6,06";
                textBox2.Text += "12";
            }
            else if (comboBox2.Text == "Samsung Galaxy S20")
            {
                IdBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                textBox2.Clear();
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Камера(мп)";
                IdBox.Text += "2";
                PriceBox.Text += "39990";
                textBox1.Text += "6,2";
                textBox2.Text += "64";
            }
            else if (comboBox2.Text == "Redmi Note 11")
            {
                IdBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                textBox2.Clear();
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Камера(мп)";
                IdBox.Text += "3";
                PriceBox.Text += "15990";
                textBox1.Text += "6,43";
                textBox2.Text += "50";
            }
            else if (comboBox2.Text == "POCO X3 Pro")
            {
                IdBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                textBox2.Clear();
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Камера(мп)";
                IdBox.Text += "4";
                PriceBox.Text += "19990";
                textBox1.Text += "6,67";
                textBox2.Text += "48";
            }
            else if (comboBox2.Text == "Asus ROG 3")
            {
                IdBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                textBox2.Clear();
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Камера(мп)";
                IdBox.Text += "5";
                PriceBox.Text += "39990";
                textBox1.Text += "6,59";
                textBox2.Text += "64";
            }
            else if (comboBox2.Text == "Huawei MateBook")
            {
                IdBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                textBox2.Clear();
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Процессор";
                IdBox.Text += "6";
                PriceBox.Text += "46990";
                textBox1.Text += "15,6";
                textBox2.Text += "Intel Core i5";
            }
            else if (comboBox2.Text == "MacBook")
            {
                IdBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                textBox2.Clear();
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Процессор";
                IdBox.Text += "7";
                PriceBox.Text += "79990";
                textBox1.Text += "13,3";
                textBox2.Text += "Apple M1";
            }
            else if (comboBox2.Text == "Lenovo IdeaPad")
            {
                IdBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                textBox2.Clear();
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Процессор";
                IdBox.Text += "8";
                PriceBox.Text += "59990";
                textBox1.Text += "15,6";
                textBox2.Text += "Intel Core i5";
            }
            else if (comboBox2.Text == "Honor MagicBook")
            {
                IdBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                textBox2.Clear();
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Процессор";
                IdBox.Text += "9";
                PriceBox.Text += "58990";
                textBox1.Text += "16,1";
                textBox2.Text += "AMD Ryzen 5";
            }
            else if (comboBox2.Text == "Acer Aspire")
            {
                IdBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                textBox2.Clear();
                label4.Text = "Диагональ(дюйм)";
                label6.Text = "Процессор";
                IdBox.Text += "10";
                PriceBox.Text += "35990";
                textBox1.Text += "15,6";
                textBox2.Text += "Intel Pentium N5030";
            }
        }

    }
}
