using System;

namespace Homework
{
    class ChangeValues
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
            Console.WriteLine($" �����: {number} <  {Math.Pow(baseDegree, count)} (����� 2 � ������� {count})");
            Console.ReadKey();
        }
    }
}
