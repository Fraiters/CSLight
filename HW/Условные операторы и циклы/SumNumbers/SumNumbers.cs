using System;

namespace Homework
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); 
            int lim = rnd.Next(100);
            int counter = 0;
            int sum = 0;
            
            Console.WriteLine($"lim = {lim}");

            while(counter <= lim)
            {
                if (counter % 3 == 0 || counter % 5 == 0)
                {
                    sum += counter;
                }
                Console.WriteLine($"counter = {counter}");
                counter++;
            }

            Console.WriteLine($"sum = {sum}");
            Console.ReadKey();
        }
    }
}