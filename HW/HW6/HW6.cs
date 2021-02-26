using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HW6
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiac;
            string work;

            Console.Write("Как вас зовут ? ");
            name = Console.ReadLine();

            Console.Write("Сколько вам лет? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какой ваш знак зодиака? ");
            zodiac = Console.ReadLine();

            Console.Write("Какая у вас профессия? ");
            work = Console.ReadLine();

            Console.WriteLine("Вас зовут " + name + ", вам " + age + " лет" + ", вы " + zodiac + " и ваша профессия - " + work);
        }
    }
}