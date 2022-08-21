using System;

namespace Homework
{
    class Shear
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int stepShear = 2;
            int currentStep = 0;
            int firstElement = 0;

            Console.WriteLine("Начальный массив:");  
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            }

            while (currentStep < stepShear)
            {
                firstElement = array[0];
                
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                       
                }
                
                currentStep++;
                array[array.Length - 1] = firstElement;
            }

                    
            Console.WriteLine();
            Console.WriteLine($"Конечный массив со сдвигом влево {stepShear} раз:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            }

            Console.ReadKey();
        }
    }
}
