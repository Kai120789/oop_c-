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
        Bitmap image1 = new Bitmap("C:\\Users\\infom\\Downloads\\12.jpg");
        Bitmap image2 = new Bitmap("C:\\Users\\infom\\Downloads\\с20.jpg");
        Bitmap image3 = new Bitmap("C:\\Users\\infom\\Downloads\\редми.jpg");
        Bitmap image4 = new Bitmap("C:\\Users\\infom\\Downloads\\поко.jpg");
        Bitmap image5 = new Bitmap("C:\\Users\\infom\\Downloads\\рог3.png");
        Bitmap image6 = new Bitmap("C:\\Users\\infom\\Downloads\\хуавей.jpg");
        Bitmap image7 = new Bitmap("C:\\Users\\infom\\Downloads\\макбук.jpg");
        Bitmap image8 = new Bitmap("C:\\Users\\infom\\Downloads\\леново.jpg");
        Bitmap image9 = new Bitmap("C:\\Users\\infom\\Downloads\\хонор.jpg");
        Bitmap image10 = new Bitmap("C:\\Users\\infom\\Downloads\\асер.jpg");
        public Form1()
        {
            InitializeComponent();
            
        }
        
    public void button1_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "")
            {
                MessageBox.Show("Выберите товар");
            }
            else
            {
                if (label8.Text == "Корзина")
                {
                    ResultBox.Clear();
                }
                label8.Text = "Просмотр";
                Order new_order = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                ResultBox.Text += new_order.ShowInfo();
            }
        }
        public List<object> box = new List<object> { "" };

        int i = 0;
        Order new_order;
        Order[] a = new Order[10];
        public void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Выберите товар");
            }
            else
            {
                if (i == 0)
                {
                    if (comboBox2.Text == "Iphone 12")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image1;
                        HeightBox.Text += "164";
                        PriceBox.Text += "44990";
                        textBox1.Text += "4499";
                        if (i < 10)
                        {
                            new_order = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                            i++;
                        }
                    }
                    else if (comboBox2.Text == "Samsung Galaxy S20")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image2;
                        HeightBox.Text += "163";
                        PriceBox.Text += "39990";
                        textBox1.Text += "3999";
                        if (i < 10)
                        {
                            new_order = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                            i++;
                        }
                    }
                    else if (comboBox2.Text == "Redmi Note 11")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image3;
                        HeightBox.Text += "179";
                        PriceBox.Text += "15990";
                        textBox1.Text += "1599";
                        if (i < 10)
                        {
                            new_order = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                            i++;
                        }
                    }
                    else if (comboBox2.Text == "POCO X3 Pro")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image4;
                        HeightBox.Text += "215";
                        PriceBox.Text += "19990";
                        textBox1.Text += "1999";
                        if (i < 10)
                        {
                            new_order = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                            i++;
                        }
                    }
                    else if (comboBox2.Text == "Asus ROG 3")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image5;
                        HeightBox.Text += "240";
                        PriceBox.Text += "39990";
                        textBox1.Text += "3999";
                        if (i < 10)
                        {
                            new_order = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                            i++;
                        }
                    }
                    else if (comboBox2.Text == "Huawei MateBook")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image6;
                        HeightBox.Text += "1530";
                        PriceBox.Text += "46990";
                        textBox1.Text += "4699";
                        if (i < 10)
                        {
                            new_order = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                            i++;
                        }
                    }
                    else if (comboBox2.Text == "MacBook")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image7;
                        HeightBox.Text += "2000";
                        PriceBox.Text += "79990";
                        textBox1.Text += "7999";
                        if (i < 10)
                        {
                            new_order = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                            i++;
                        }
                    }
                    else if (comboBox2.Text == "Lenovo IdeaPad")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image8;
                        HeightBox.Text += "2200";
                        PriceBox.Text += "59990";
                        textBox1.Text += "5999";
                        if (i < 10)
                        {
                            new_order = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                            i++;
                        }
                    }
                    else if (comboBox2.Text == "Honor MagicBook")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image9;
                        HeightBox.Text += "1530";
                        PriceBox.Text += "58990";
                        textBox1.Text += "5899";
                        if (i < 10)
                        {
                            new_order = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                            i++;
                        }
                    }
                    else if (comboBox2.Text == "Acer Aspire")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image10;
                        HeightBox.Text += "1710";
                        PriceBox.Text += "35990";
                        textBox1.Text += "3599";
                        if (i < 10)
                        {
                            new_order = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                            i++;
                        }
                    }
                }
                else if (i != 0 && i < 10)
                {
                    if (comboBox2.Text == "Iphone 12")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image1;
                        HeightBox.Text += "164";
                        PriceBox.Text += "44990";
                        textBox1.Text += "4499";
                        a[i] = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                        new_order += a[i];
                        i++;
                    }
                    else if (comboBox2.Text == "Samsung Galaxy S20")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image2;
                        HeightBox.Text += "163";
                        PriceBox.Text += "39990";
                        textBox1.Text += "3999";
                        a[i] = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                        new_order += a[i];
                        i++;
                    }
                    else if (comboBox2.Text == "Redmi Note 11")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image3;
                        HeightBox.Text += "179";
                        PriceBox.Text += "15990";
                        textBox1.Text += "1599";
                        a[i] = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                        new_order += a[i];
                        i++;
                    }
                    else if (comboBox2.Text == "POCO X3 Pro")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image4;
                        HeightBox.Text += "215";
                        PriceBox.Text += "19990";
                        textBox1.Text += "1999";
                        a[i] = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                        new_order += a[i];
                        i++;
                    }
                    else if (comboBox2.Text == "Asus ROG 3")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image5;
                        HeightBox.Text += "240";
                        PriceBox.Text += "39990";
                        textBox1.Text += "3999";
                        a[i] = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                        new_order += a[i];
                        i++;
                    }
                    else if (comboBox2.Text == "Huawei MateBook")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image6;
                        HeightBox.Text += "1530";
                        PriceBox.Text += "46990";
                        textBox1.Text += "4699";
                        a[i] = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                        new_order += a[i];
                        i++;
                    }
                    else if (comboBox2.Text == "MacBook")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image7;
                        HeightBox.Text += "2000";
                        PriceBox.Text += "79990";
                        textBox1.Text += "7999";
                        a[i] = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                        new_order += a[i];
                        i++;
                    }
                    else if (comboBox2.Text == "Lenovo IdeaPad")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image8;
                        HeightBox.Text += "2200";
                        PriceBox.Text += "59990";
                        textBox1.Text += "5999";
                        a[i] = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                        new_order += a[i];
                        i++;
                    }
                    else if (comboBox2.Text == "Honor MagicBook")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image9;
                        HeightBox.Text += "1530";
                        PriceBox.Text += "58990";
                        textBox1.Text += "5899";
                        a[i] = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                        new_order += a[i];
                        i++;
                    }
                    else if (comboBox2.Text == "Acer Aspire")
                    {
                        HeightBox.Clear();
                        PriceBox.Clear();
                        textBox1.Clear();
                        pictureBox1.Image = image10;
                        HeightBox.Text += "1710";
                        PriceBox.Text += "35990";
                        textBox1.Text += "3599";

                        a[i] = new Order(comboBox2.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(HeightBox.Text), Convert.ToDouble(textBox1.Text));
                        new_order += a[i];
                        i++;

                    }

                }
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "Корзина";
            ResultBox.Text = new_order.ShowInfo();
            double summa = (double)new_order;
            sumBox.Text = Convert.ToString(summa);
        }
        
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Iphone 12")
            {
                HeightBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                pictureBox1.Image = image1;
                HeightBox.Text += "164";
                PriceBox.Text += "44990";
                textBox1.Text += "4499";
            }
            else if (comboBox2.Text == "Samsung Galaxy S20")
            {
                HeightBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                pictureBox1.Image = image2;
                HeightBox.Text += "163";
                PriceBox.Text += "39990";
                textBox1.Text += "3999";
            }
            else if (comboBox2.Text == "Redmi Note 11")
            {
                HeightBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                pictureBox1.Image = image3;
                HeightBox.Text += "179";
                PriceBox.Text += "15990";
                textBox1.Text += "1599";
            }
            else if (comboBox2.Text == "POCO X3 Pro")
            {
                HeightBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                pictureBox1.Image = image4;
                HeightBox.Text += "215";
                PriceBox.Text += "19990";
                textBox1.Text += "1999";
            }
            else if (comboBox2.Text == "Asus ROG 3")
            {
                HeightBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                pictureBox1.Image = image5;
                HeightBox.Text += "240";
                PriceBox.Text += "39990";
                textBox1.Text += "3999";
            }
            else if (comboBox2.Text == "Huawei MateBook")
            {
                HeightBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                pictureBox1.Image = image6;
                HeightBox.Text += "1530";
                PriceBox.Text += "46990";
                textBox1.Text += "4699";
            }
            else if (comboBox2.Text == "MacBook")
            {
                HeightBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                pictureBox1.Image = image7;
                HeightBox.Text += "2000";
                PriceBox.Text += "79990";
                textBox1.Text += "7999";
            }
            else if (comboBox2.Text == "Lenovo IdeaPad")
            {
                HeightBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                pictureBox1.Image = image8;
                HeightBox.Text += "2200";
                PriceBox.Text += "59990";
                textBox1.Text += "5999";
            }
            else if (comboBox2.Text == "Honor MagicBook")
            {
                HeightBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                pictureBox1.Image = image9;
                HeightBox.Text += "1530";
                PriceBox.Text += "58990";
                textBox1.Text += "5899";
            }
            else if (comboBox2.Text == "Acer Aspire")
            {
                HeightBox.Clear();
                PriceBox.Clear();
                textBox1.Clear();
                pictureBox1.Image = image10;
                HeightBox.Text += "1710";
                PriceBox.Text += "35990";
                textBox1.Text += "3599";
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Спасибо за заказ! Стоимость заказа составляет {sumBox.Text} рублей");
            i = 0;
            HeightBox.Clear();
            PriceBox.Clear();
            textBox1.Clear();
            ResultBox.Clear();
            sumBox.Clear();
            comboBox2.Text = null;
            pictureBox1.Image = null;
            
        }
    }
}
