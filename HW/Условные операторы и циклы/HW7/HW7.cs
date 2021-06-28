using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HW7
    {
        static void Main(string[] args)
        {
            string truePassword = "0000";
            string password;
            int numberAttempt = 3;
            string secretMessage = "Не ссы против ветра (Дж.Стэтхэм)";

            while (numberAttempt > 0)
            {
                Console.Write("Чтобы получить секретное сообщение введите пароль: ");
                password = Console.ReadLine();

                if (truePassword == password)
                {
                    Console.WriteLine(secretMessage);
                    break;
                }

                else
                {
                    Console.WriteLine("Пароль неверный \n");
                    numberAttempt--;
                }
            }

            if (numberAttempt <= 0)
                Console.WriteLine("У вас не осталось попыток ввести пароль, программа завершается");

            Console.ReadKey();
        }
    }
}