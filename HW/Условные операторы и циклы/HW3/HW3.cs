using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HW3
    {
        static void Main(string[] args)
        {
            float rub;
            float usd;
            float eur;
            int rubToUsd = 76;
            int rubToEur = 90;
            int usdToRub = 75;
            int eurToRub = 89;
            float usdToEur = 1.2f;
            float eurToUsd = 1.3f;

            float swapMoney;
            int swap;
            bool isWork = true;

            Console.Write("Введите количество рублей - ");
            rub = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите количество долларов - ");
            usd = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите количество евро - ");
            eur = Convert.ToSingle(Console.ReadLine());

            while (isWork)
            {
                Console.WriteLine("Что вам необходимо обменять?");
                Console.WriteLine("1 - рубли на доллары");
                Console.WriteLine("2 - рубли на евро");
                Console.WriteLine("3 - доллары на рубли");
                Console.WriteLine("4 - доллары на евро");
                Console.WriteLine("5 - евро на рубли");
                Console.WriteLine("6 - евро на доллары");
                Console.WriteLine("7 - завершить программу");

                Console.Write("Введите цифру - ");
                swap = Convert.ToInt32(Console.ReadLine());



                switch (swap)
                {
                    case 1:
                        Console.Write("Введите сумму которую хотите обменять - ");
                        swapMoney = Convert.ToSingle(Console.ReadLine());
                        if (rub >= swapMoney)
                        {
                            rub -= swapMoney;
                            usd += swapMoney / rubToUsd;
                        }
                        else
                            Console.WriteLine("Недостаточно средств для обмена");
                        Console.WriteLine("На вашем счете " + rub + " рублей и " + usd + " долларов");
                        break;

                    case 2:
                        Console.Write("Введите сумму которую хотите обменять - ");
                        swapMoney = Convert.ToSingle(Console.ReadLine());
                        if (rub >= swapMoney)
                        {
                            rub -= swapMoney;
                            eur += swapMoney / rubToEur;
                        }
                        else
                            Console.WriteLine("Недостаточно средств для обмена");
                        Console.WriteLine("На вашем счете " + rub + " рублей и " + eur + " евро");
                        break;

                    case 3:
                        Console.Write("Введите сумму которую хотите обменять - ");
                        swapMoney = Convert.ToSingle(Console.ReadLine());
                        if (usd >= swapMoney)
                        {
                            usd -= swapMoney;
                            rub += swapMoney / usdToRub;
                        }
                        else
                            Console.WriteLine("Недостаточно средств для обмена");
                        Console.WriteLine("На вашем счете " + rub + " рублей и " + usd + " долларов");
                        break;

                    case 4:
                        Console.Write("Введите сумму которую хотите обменять - ");
                        swapMoney = Convert.ToSingle(Console.ReadLine());
                        if (usd >= swapMoney)
                        {
                            usd -= swapMoney;
                            eur += swapMoney / usdToEur;
                        }
                        else
                            Console.WriteLine("Недостаточно средств для обмена");
                        Console.WriteLine("На вашем счете " + usd + " долларов и " + eur + " евро");
                        break;

                    case 5:
                        Console.Write("Введите сумму которую хотите обменять - ");
                        swapMoney = Convert.ToSingle(Console.ReadLine());
                        if (eur >= swapMoney)
                        {
                            eur -= swapMoney;
                            rub += swapMoney / eurToRub;
                        }
                        else
                            Console.WriteLine("Недостаточно средств для обмена");
                        Console.WriteLine("На вашем счете " + rub + " рублей и " + eur + " евро");
                        break;

                    case 6:
                        Console.Write("Введите сумму которую хотите обменять - ");
                        swapMoney = Convert.ToSingle(Console.ReadLine());
                        if (eur >= swapMoney)
                        {
                            eur -= swapMoney;
                            usd += swapMoney / eurToUsd;
                        }
                        else
                            Console.WriteLine("Недостаточно средств для обмена");
                        Console.WriteLine("На вашем счете " + usd + " долларов и " + eur + " евро");
                        break;
                    case 7:
                        isWork = false;
                        break;
                    default:
                        Console.WriteLine("Такой клавиши не найдено");
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}
