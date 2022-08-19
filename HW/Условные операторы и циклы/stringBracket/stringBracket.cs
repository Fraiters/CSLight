using System;

namespace Homework
{
    class StringBracket
    {
        static void Main(string[] args)
        {
            string text = "())(())())";
            int count1 = 0;
            int count2 = 0;
            
            for (int index = 0; index < text.Length; index++)
            {
                if (text[index] == '(' && index != (text.Length))
                    count1++;
                else if (text[index] == ')' && count1 >= count2 && index != (0))
                    count2++;
            }

            Console.WriteLine(text);

            if (count1 != count2)
            {
                Console.WriteLine("Строка некорректна");
            }
            else
                Console.WriteLine($"Строка корректна, максимальная глубина вложенности скобок: {count1 - 1}");
            Console.ReadKey();
        }
    }
}
