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
            int money;
            int countCrystal;
            int priceCrystal;
            bool enoughMoney;

            Console.Write("Введите количество монет - ");
            money = Convert.ToInt32(Console.ReadLine());

            Console.Write("Цена кристалла - ");
            priceCrystal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько кристаллов хотите купить? - ");
            countCrystal = Convert.ToInt32(Console.ReadLine());

            enoughMoney = money >= countCrystal * priceCrystal;
            countCrystal *= Convert.ToInt32(enoughMoney);
            money -= countCrystal * priceCrystal;

            Console.WriteLine("Сделка завершена!");
            Console.WriteLine("У вас осталось " + money + " монет");
            Console.WriteLine("Вы приобрели " + countCrystal + " кристаллов");
        }
    }
}
