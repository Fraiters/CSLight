using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HW4
    {
        static void Main(string[] args)
        {


            string name;
            string password;
            string color;
            string zodiac;
            int age;
            string checkPassword;
            bool isPassword = false;

            int swap;
            bool isWork = true;


            while (isWork)
            {
                Console.WriteLine("Вы можете выбрать одну из следующих команд");
                Console.WriteLine("1 - установить ваше имя");
                Console.WriteLine("2 - установить ваш пароль");
                Console.WriteLine("3 - установить ваш любимый цвет");
                Console.WriteLine("4 - установить ваш знак зодиака");
                Console.WriteLine("5 - установить ваш возраст");
                Console.WriteLine("6 - получить всю информацию о вас (необходимо ввести пароль)");
                Console.WriteLine("7 - выйти из консоли");

                Console.Write("Введите цифру - ");
                swap = Convert.ToInt32(Console.ReadLine());



                switch (swap)
                {
                    case 1:

                        Console.Writeline("Устанавливаем ваше имя");

                        Console.Writeline("Введите ваше имя:");
                        name = Console.ReadLine();
                        Console.WriteLine("Теперь вас зовут - " + name);
                        break;

                    case 2:
                        Console.Writeline("Устанавливаем ваш пароль:");
                        Console.Writeline("Введите ваш новый пароль:");
                        password = Console.ReadLine();
                        isPassword = true;
                        Console.WriteLine("Ваш пароль успешно изменен");
                        break;

                    case 3:
                        Console.Writeline("Устанавливаем ваш любимый цвет:");
                        Console.Writeline("Введите ваш любимый цвет:");
                        color = Console.ReadLine();
                        Console.WriteLine("Ваш любимый цвет установлен");
                        break;

                    case 4:
                        Console.Writeline("Устанавливаем ваш знак зодиака:");
                        Console.Writeline("Введите ваш знак зодиака");
                        zodiac = Console.ReadLine();
                        Console.WriteLine("Ваш знак зодиака установлен");
                        break;

                    case 5:
                        Console.Writeline("Устанавливаем ваш возраст:");
                        Console.Writeline("Введите ваш возраст:");
                        age = Console.ReadLine();
                        Console.WriteLine("Ваш возраст установлен");
                        break;

                    case 6:
                        Console.Writeline("Чтобы получить информацию о вас, необходимо ввести пароль");
                        if (!isPassword)
                        {
                            Console.Writeline("Ваш пароль не установлен! Чтобы получить информацию о вас, необходимо установить пароль");
                            break;
                        }
                        else
                        {
                            Console.Writeline("Введите ваш пароль:");
                            checkPassword = Console.ReadLine();
                            if (checkPassword == password)
                            {
                                Console.WriteLine("Вся информация о вас:");
                                Console.WriteLine("Вас зовут: " + name);
                                Console.WriteLine("Ваш любимый цвет: " + color);
                                Console.WriteLine("Ваш знак зодиака: " + zodiac);
                                Console.WriteLine("Ваш возраст: " + age);
                            }

                        }
                        break;

                    case 7:
                        isWork = false;
                        break;
                    default:
                        Console.WriteLine("Такой команды не найдено");
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}
