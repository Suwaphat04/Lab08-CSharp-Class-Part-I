 using System;

namespace Lab08_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Rambo";
            p.id = "1987";
            p.income = 2500;

            Console.WriteLine($"Type of p is {p.GetType()}");
            Console.WriteLine($"p.name = {p.name}\ttype = {p.name.GetType()}");
            Console.WriteLine($"p.id = {p.id}\ttype = {p.id.GetType()}");
            Console.WriteLine($"p.income = {p.income}\ttype = {p.income.GetType()}");
        }
    }

    class Person
    {
        public string name;
        public string id;
        public int income;
    }
}

