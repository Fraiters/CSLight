using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HW6
    {
        static void Main(string[] args)
        {
            string name;
            string symbol;
            int count;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите символ: ");
            symbol = Console.ReadLine();

            for (count = 0; count <= (name.Length + 2); count++) // первая строка
                Console.Write(symbol);

            Console.WriteLine("\n" + symbol + name + symbol); // вторая строка

            for (count = 0; count <= (name.Length + 2); count++) // третья строка
                Console.Write(symbol);

            Console.ReadKey();
        }
    }
}
