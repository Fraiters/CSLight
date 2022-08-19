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
            int oneDivisor = 3;
            int twoDivisor = 5;

            Console.WriteLine($"lim = {number}");

            for (counter = 0; counter <= number; counter++)
            {
                if (counter % oneDivisor == 0 || counter % twoDivisor == 0)
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
