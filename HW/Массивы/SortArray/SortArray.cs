using System;

namespace Homework
{
    class SortArray
    {
        static void Main(string[] args)
        {
            int [] array = {4, 5, 10, 44, 6, 4, 1, 98, 13, 0};
            int maxNumber = 0;
            int value = 0;

            for (int i = 0; i < array.Length; i++)
            {   
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        value = array[i];  
                        array[i] = array[j];
                        array[j] = value;
                    }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($" {array[i]} ");
            }
                
            Console.ReadKey();
        }
    }
}
