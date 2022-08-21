using System;

namespace Homework
{
    class Split
    {
        static void Main(string[] args)
        {
            string phrase = "May the force be with you";
            string[] words = phrase.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine($" <{word}> ");
            }

            Console.ReadKey();
        }
    }
}