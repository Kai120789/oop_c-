﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork8
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            label1.Visible = false; label2.Visible = false; label3.Visible = false;

        }


        

        public void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();


            Hashtable books = new Hashtable();

            books.Add("Книга 1", new Book("Мастер и Маргарита", "Классика", "Булгаков Михаил"));
            books.Add("Книга 2", new Book("Вокруг света за 80 дней", "Фантастика", "Верн Жюль"));
            books.Add("Книга 3", new Book("Собачье сердце", "Классика", "Булгаков Михаил"));
            books.Add("Книга 4", new Book("Шерлок Холмс", "Детектив", "Конан Дойл Артур"));
            books.Add("Книга 5", new Book("12 стульев", "Классика", "Ильф Илья"));
            books.Add("Книга 6", new Book("Таинственный остров", "Фантастика", "Верн Жюль"));
            books.Add("Книга 7", new Book("Мёртвые души", "Классика", "Гоголь Николай"));
            books.Add("Книга 8", new Book("Смерть на Ниле", "Детектив", "Кристи Агата"));



            List<string> classicBooks = new List<string>();
            List<string> titles = new List<string>();

            List<string> genres = new List<string>();

            List<string> authors = new List<string>();
            

            int classicCount = 0;

            if(comboBox1.Text == "Классика")
            {

                foreach (DictionaryEntry entry in books)
                {
                    Book book = (Book)entry.Value;
                    if (book.Genre == "Классика")
                    {
                        classicBooks.Add(book.Author + " - " + book.Title);
                        classicCount++;

                    }
                    titles.Add(book.Title);
                    genres.Add(book.Genre);
                    authors.Add(book.Author);
                }

                classicBooks.Sort();

                label1.Text = "Количество книг классического жанра: " + classicCount;
                int otherCount = books.Count - classicCount;
                label2.Text = "Количество книг других жанров: " + otherCount;
                if (classicCount > otherCount)
                {
                    label3.Text = "Книг классического жанра больше, чем книг других жанров";
                }
                else if (classicCount < otherCount)
                {
                    label3.Text = "Книг классического жанра меньше, чем книг других жанров";
                }
                else
                {
                    label3.Text = "Количество книг классического жанра равно количеству книг других жанров";
                }
                label1.Visible = true; label2.Visible = true; label3.Visible = true;

                int columns = 1;
                while (columns != 4)
                {
                    if (columns == 1)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Название");
                        columns++;
                    }
                    if (columns == 2)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Жанр");
                        columns++;
                    }
                    if (columns == 3)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Автор");
                        columns++;
                    }
                }
                dataGridView1.Rows.Add(books.Count);
                for (int k = 0; k < books.Count; k++)
                {
                    dataGridView1[0, k].Value = titles[k];
                }

                for (int m = 1; m < 3; m++)
                {
                    if (m == 1)
                    {
                        for (int l = 0; l < books.Count; l++)
                        {
                            dataGridView1[m, l].Value = genres[l];
                        }
                    }
                    else
                    {
                        for (int l = 0; l < books.Count; l++)
                        {
                            dataGridView1[m, l].Value = authors[l];
                        }
                    }
                }
                dataGridView1.Refresh();

                int i = 0;

                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add(columns.ToString(), "Классические книги");
                dataGridView1.Rows.Add(classicBooks.Count);



                foreach (string title in classicBooks)
                {
                    if (i == 0)
                    {
                        dataGridView1[0, 0].Value = classicBooks[0];

                    }
                    else
                    {
                        dataGridView1[0, i].Value = classicBooks[i];
                    }
                    i++;
                }

            }





            if(comboBox1.Text == "Детектив")
            {

                foreach (DictionaryEntry entry in books)
                {
                    Book book = (Book)entry.Value;
                    if (book.Genre == "Детектив")
                    {
                        classicBooks.Add(book.Author + " - " + book.Title);
                        classicCount++;

                    }
                    titles.Add(book.Title);
                    genres.Add(book.Genre);
                    authors.Add(book.Author);
                }

                classicBooks.Sort();

                label1.Text = "Количество книг детективного жанра: " + classicCount;
                int otherCount = books.Count - classicCount;
                label2.Text = "Количество книг других жанров: " + otherCount;
                if (classicCount > otherCount)
                {
                    label3.Text = "Книг детективного жанра больше, чем книг других жанров";
                }
                else if (classicCount < otherCount)
                {
                    label3.Text = "Книг детективного жанра меньше, чем книг других жанров";
                }
                else
                {
                    label3.Text = "Количество книг детективного жанра равно количеству книг других жанров";
                }
                label1.Visible = true; label2.Visible = true; label3.Visible = true;

                int columns = 1;
                while (columns != 4)
                {
                    if (columns == 1)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Название");
                        columns++;
                    }
                    if (columns == 2)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Жанр");
                        columns++;
                    }
                    if (columns == 3)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Автор");
                        columns++;
                    }
                }
                dataGridView1.Rows.Add(books.Count);
                for (int k = 0; k < books.Count; k++)
                {
                    dataGridView1[0, k].Value = titles[k];
                }

                for (int m = 1; m < 3; m++)
                {
                    if (m == 1)
                    {
                        for (int l = 0; l < books.Count; l++)
                        {
                            dataGridView1[m, l].Value = genres[l];
                        }
                    }
                    else
                    {
                        for (int l = 0; l < books.Count; l++)
                        {
                            dataGridView1[m, l].Value = authors[l];
                        }
                    }
                }
                dataGridView1.Refresh();

                int i = 0;

                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add(columns.ToString(), "Детективные книги");
                dataGridView1.Rows.Add(classicBooks.Count);



                foreach (string title in classicBooks)
                {
                    if (i == 0)
                    {
                        dataGridView1[0, 0].Value = classicBooks[0];

                    }
                    else
                    {
                        dataGridView1[0, i].Value = classicBooks[i];
                    }
                    i++;
                }

            }





            if(comboBox1.Text == "Фантастика")
            {

                foreach (DictionaryEntry entry in books)
                {
                    Book book = (Book)entry.Value;
                    if (book.Genre == "Фантастика")
                    {
                        classicBooks.Add(book.Author + " - " + book.Title);
                        classicCount++;

                    }
                    titles.Add(book.Title);
                    genres.Add(book.Genre);
                    authors.Add(book.Author);
                }

                classicBooks.Sort();

                
                label1.Text = "Количество книг Фантастического жанра: " + classicCount;
                int otherCount = books.Count - classicCount;
                label2.Text = "Количество книг других жанров: " + otherCount;
                if (classicCount > otherCount)
                {
                    label3.Text = "Книг Фантастического жанра больше, чем книг других жанров";
                }
                else if (classicCount < otherCount)
                {
                    label3.Text = "Книг Фантастического жанра меньше, чем книг других жанров";
                }
                else
                {
                    label3.Text = "Количество книг Фантастического жанра равно количеству книг других жанров";
                }
                label1.Visible = true; label2.Visible = true; label3.Visible = true;

                int columns = 1;
                while (columns != 4)
                {
                    if (columns == 1)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Название");
                        columns++;
                    }
                    if (columns == 2)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Жанр");
                        columns++;
                    }
                    if (columns == 3)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Автор");
                        columns++;
                    }
                }
                dataGridView1.Rows.Add(books.Count);
                for (int k = 0; k < books.Count; k++)
                {
                    dataGridView1[0, k].Value = titles[k];
                }

                for (int m = 1; m < 3; m++)
                {
                    if (m == 1)
                    {
                        for (int l = 0; l < books.Count; l++)
                        {
                            dataGridView1[m, l].Value = genres[l];
                        }
                    }
                    else
                    {
                        for (int l = 0; l < books.Count; l++)
                        {
                            dataGridView1[m, l].Value = authors[l];
                        }
                    }
                }
                dataGridView1.Refresh();

                int i = 0;

                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add(columns.ToString(), "Фантастические книги");
                dataGridView1.Rows.Add(classicBooks.Count);



                foreach (string title in classicBooks)
                {
                    if (i == 0)
                    {
                        dataGridView1[0, 0].Value = classicBooks[0];

                    }
                    else
                    {
                        dataGridView1[0, i].Value = classicBooks[i];
                    }
                    i++;
                }
            }







            if (comboBox1.Text == "" || comboBox1.Text == "Все произведения")
            {
                

                foreach (DictionaryEntry entry in books)
                {
                    Book book = (Book)entry.Value;
                    
                    titles.Add(book.Title);
                    genres.Add(book.Genre);
                    authors.Add(book.Author);
                }

                classicBooks.Sort();

                int columns = 1;
                while (columns != 4)
                {
                    if (columns == 1)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Название");
                        columns++;
                    }
                    if (columns == 2)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Жанр");
                        columns++;
                    }
                    if (columns == 3)
                    {
                        dataGridView1.Columns.Add(columns.ToString(), "Автор");
                        columns++;
                    }
                }
                dataGridView1.Rows.Add(books.Count);
                for (int k = 0; k < books.Count; k++)
                {
                    dataGridView1[0, k].Value = titles[k];
                }

                for (int m = 1; m < 3; m++)
                {
                    if (m == 1)
                    {
                        for (int l = 0; l < books.Count; l++)
                        {
                            dataGridView1[m, l].Value = genres[l];
                        }
                    }
                    else
                    {
                        for (int l = 0; l < books.Count; l++)
                        {
                            dataGridView1[m, l].Value = authors[l];
                        }
                    }
                }

                dataGridView1.Refresh();
                
            }
        }

        
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label1.Visible = false; label2.Visible = false; label3.Visible = false;
            if (comboBox1.Text != "" && comboBox1.Text != "Все произведения")
            {
                button1.Text = "Вывести список произведений и отсортировать по жанру";
                button1.Refresh();
            }
        }
    }
}
