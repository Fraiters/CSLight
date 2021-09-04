using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HW8
    {
        static void Main(string[] args)
        {
            int[,] array = { {1, 4, 7}, {10, 7, 4}, {95, 4, 6} };

            int sumString2 = 0;
            int productColumn1 = 1;

            Console.WriteLine("Исходная матрица:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }             
                productColumn1 *= array[i, 0];
                Console.WriteLine();
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumString2 += array[1, j];
            }

            Console.WriteLine("Сумма 2ой строки: " + sumString2);
            Console.WriteLine("Произведение 1го столбца: " + productColumn1);

            Console.ReadKey();
        }
    }
}
