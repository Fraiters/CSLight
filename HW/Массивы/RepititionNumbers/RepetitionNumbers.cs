using System;

namespace Homework
{
    class RepititionNumbers
    {
        static void Main(string[] args)
        {
            const int length = 30;
            int[] array = new int [length];
            int count = 1;
            int maxCount = 0;
            int value = 0;

            for (int i = 0; i < length; i++)
            {
                array [i] = 4;
            }

            array [3] = 5;
            array [4] = 5;
            array [5] = 5;
            array [6] = 5;
            array [7] = 5;

            for (int i = 0; i < length - 1; i++)
            {
                if (array [i] == array [i + 1] )
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        value = array [i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write($" {array [i]} ");
            }             

            Console.WriteLine();
            Console.WriteLine($"Число {value} повторяется большее число раз подряд ({maxCount})");
            Console.ReadKey();
        }
    }
}
