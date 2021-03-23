using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HW1
    {
        static void Main(string[] args)
        {
            string message;
            int numberRepeat;

            Console.Write("Введите сообщение: ");
            message = Console.ReadLine();

            Console.Write("Введите количество повторений: ");
            numberRepeat = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberRepeat; i++)
            {
                Console.WriteLine(message);
            }

        }
    }
}