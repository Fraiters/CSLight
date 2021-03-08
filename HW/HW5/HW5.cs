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
            int hourWaiting;
            int minuteWaiting;

            Console.Write("Введите количество старушек в очереди - ");
            countPeople = Convert.ToInt32(Console.ReadLine());

            timeWaiting = countPeople * timePerson;
            hourWaiting = timeWaiting / 60;
            minuteWaiting = timeWaiting % 60;

            Console.WriteLine("Вам осталось ждать " + hourWaiting + " часа " + minuteWaiting + " минут");
        }
    }
}
