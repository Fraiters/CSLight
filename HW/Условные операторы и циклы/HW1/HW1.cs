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
            string message = "Да прибудет с тобой сила!";
            int n;

            Console.Write("Введите количество повторений: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(message);
            }
            
        }
    }
}