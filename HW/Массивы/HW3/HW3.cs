using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HW3
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random random = new Random();

            int[] localMaxArray = new int[0];
            int localMax = 0;

            Console.WriteLine("Исходная матрица:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write(array[i] + " ");
            }

            if (array[0] >= array[1])
            {
                localMax = array[0];

                int[] tempLocalMaxArray = new int[localMaxArray.Length + 1];
                for (int j = 0; j < localMaxArray.Length; j++)
                {

                    tempLocalMaxArray[j] = localMaxArray[j];
                }
                tempLocalMaxArray[tempLocalMaxArray.Length - 1] = localMax;
                localMaxArray = tempLocalMaxArray;
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                if ((array[i] >= array[i - 1]) && (array[i] >= array[i + 1]))
                {
                    localMax = array[i];

                    int[] tempLocalMaxArray = new int[localMaxArray.Length + 1];
                    for (int j = 0; j < localMaxArray.Length; j++)
                    {
                        tempLocalMaxArray[j] = localMaxArray[j];
                    }
                    tempLocalMaxArray[tempLocalMaxArray.Length - 1] = localMax;
                    localMaxArray = tempLocalMaxArray;
                }
            }

            if (array[array.Length - 1] >= array[array.Length - 2])
            {
                localMax = array[array.Length - 1];

                int[] tempLocalMaxArray = new int[localMaxArray.Length + 1];
                for (int j = 0; j < localMaxArray.Length; j++)
                {

                    tempLocalMaxArray[j] = localMaxArray[j];
                }
                tempLocalMaxArray[tempLocalMaxArray.Length - 1] = localMax;
                localMaxArray = tempLocalMaxArray;
            }

            Console.WriteLine();
            Console.WriteLine("Массив локальных максимумов:");
            for (int i = 0; i < localMaxArray.Length; i++)
            {
                Console.Write(localMaxArray[i] + " ");
            }
            Console.ReadKey();
        }
    }
}