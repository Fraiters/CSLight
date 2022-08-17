using System;

namespace Homework
{
    class ChangeValues
    {
        static void Main(string[] args)
        {
            string name = "Ivanov";
            string surname = "Ivan";
            string store;
            
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Name: {surname}\n");

            store = name;
            name = surname;
            surname = store;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Name: {surname}");


            Console.ReadKey();
        }
    }
}