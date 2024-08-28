using System;
using System.Collections.Generic;
namespace ConsoleApp24
{
    class Storage
    {
        public static List<List<object>> lst = new List<List<object>>();
        public static void Add(Product goods)
        {
            string data1 = goods.name;
            DateTime data2 = goods.date;
            int data3 = goods.cost;
            List<object> t = new List<object>() { data1, data2, data3 };
            lst.Add(t);
        }
        public static void Info()
        {
            for (int i = 0; i < lst.Count;i++)
            {
                Console.WriteLine($"Название: {lst[i][0]}");
                Console.WriteLine($"Дата ввоза: {lst[i][1]}");
                Console.WriteLine($"Стоимость: {lst[i][2]}");
                Console.WriteLine();
            }       
        }
    }
    class Product
    {
        public string name;
        public DateTime date;
        public int cost;
        public Product(string name, DateTime date, int cost)
        {
            this.name = name;
            this.date = date;
            this.cost = cost;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Банан", new DateTime(2023, 2, 13), 200);
            Product product2 = new Product("Персики", new DateTime(2023, 1, 30), 350);
            Product product3 = new Product("Яблоки", new DateTime(1941, 6, 22), 50);
            Storage.Add(product1);
            Storage.Add(product2);
            Storage.Add(product3);
            Storage.Info();
        }
    }
}


