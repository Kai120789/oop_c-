using System;
using System.Linq;

namespace Ocruglenie
{
    class Person
    {
        private static int Count = 0;
        private int id;
        public int GetId
        {
            get { return id; }
            set { id = Count; }
        }
        public string Name;
        private int age;
        public int Age
        {
            get { return age; }
            set { if (value >= 18) age = value; }
        }
        public string Gender;
        public string Login;
        private string password;
        public string GetPassword
        {
            get { return password; }
            set { password = value; }
        }
        public Person(int id, string name, int age, string gender, string login, string password)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Login = login;
            Count++;
            GetId = id;
            GetPassword = password;
        }
        public Person()
        {
            Name = "Default";
            Age = 18;
            Gender = "Не задано";
            Login = "123name";
            password = "123";
            Count++;
            GetId = id;
        }
    }
    class Program
    {
        public static void Information(Person person)
        {
            Console.WriteLine($"имя: {person.Name}");
            Console.WriteLine($"возраст: {person.Age}");
            Console.WriteLine($"пол: {person.Gender}");
            Console.WriteLine($"логин: {person.Login}");
            Console.WriteLine($"Id: {person.GetId}");
            Console.WriteLine($"пароль: {person.GetPassword}");
        }
        static void Main()
        {
            Person test1 = new Person();
            Person test2 = new Person();
            test2.Name = "Жоас";
            test2.Age = 22;
            test2.Gender = "муж";
            test2.Login = "Bushido Zho";
            test2.GetPassword = "12345678";
            Information(test1);
            Console.WriteLine();
            Information(test2);
        }
    }
}


