using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HW5
    {
        static void Main(string[] args)
        {
            int countPeople;
            int timePerson = 10;
            int timeWaiting;
            int hour, minute;

            Console.Write("Введите количество старушек в очереди - ");
            countPeople = Convert.ToInt32(Console.ReadLine());

            timeWaiting = countPeople * timePerson;
            hour = timeWaiting / 60;
            minute = timeWaiting % 60;

            Console.WriteLine("Вам осталось ждать " + hour + " часа " + minute + " минут");
        }
    }
}
