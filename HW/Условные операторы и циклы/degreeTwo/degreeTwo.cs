using System;

namespace Homework
{
    class DegreeTwo
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int baseDegree = 2;
            int count = 0;
            
            while(Math.Pow(baseDegree, count) <= number) 
            {
                count++;
            }
            Console.WriteLine($" ×èñëî: {number} <  {Math.Pow(baseDegree, count)} (÷èñëî 2 â ñòåïåíè {count})");
            Console.ReadKey();
        }
    }
}
