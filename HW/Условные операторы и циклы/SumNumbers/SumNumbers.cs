using System;

namespace Homework
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int limit = 100;
            int number = random.Next(limit);
            int counter = 0;
            int sum = 0;
            int digit3 = 3;
            int digit5 = 5;

            Console.WriteLine($"lim = {number}");

           for (counter = 0; counter <= number; counter++)
            {
                if (counter % digit3 == 0 || counter % digit5 == 0)
                {
                    
                    sum += counter;
                }
                Console.WriteLine($"counter = {counter}");
            }

            Console.WriteLine($"sum = {sum}");
            Console.ReadKey();
        }
    }
}
