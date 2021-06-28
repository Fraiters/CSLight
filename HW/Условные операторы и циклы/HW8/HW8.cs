using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HW8
    {
        static void Main(string[] args)
        {
            int swap;

            int hpBoss = 1000;
            int hpWizard = 500;

            int damageBoss;
            int damageWizard;

            int limitDamageShield = 100;
            bool isShield = false;
            bool isChickenWizard = false;
            bool isChickenBoss = false;

            int countChicken = 0;
            int countFireball = 0;
            int maxCountFireball = 3;

            bool isWizard = true;
            bool isBoss = true;

            Random rnd = new Random();
            int randomEvent;

            Console.WriteLine("Начинается великая битва! Вам суждено сразиться с мега БОССОМ");
            Console.WriteLine("Вы играете за крутого волшебника - Купера Вивальди и в вашем арсенале есть 4 заклинания, которые помогут вам одержать победу");
            Console.WriteLine("Но будьте осторожны, ведь после каждого вашего действия БОСС может отвесить вам таких люлей... Все же стоит попытаться...");

            while (isWizard && isBoss)
            {
                if (hpWizard <= 0 && hpBoss > 0)
                {
                    isWizard = false;
                    Console.WriteLine("БОСС вас изничтожил! Ваши раны кровоточат и вы умираете... \nYOU LOSE!");
                }
                else
                    if (hpBoss <= 0 && hpWizard > 0)
                {
                    isBoss = false;
                    Console.WriteLine("А вы и правда самый крутой маг! БОСС повержен! От столь суровых ударов БОСС погибает\nYOU WIN!");
                }
                else
                    if (hpBoss <= 0 && hpWizard <= 0)
                {
                    isBoss = false;
                    isWizard = false;
                    Console.WriteLine("Вы были достойными противниками, НИКТО не выжил... Вы хорошенько друг друга побили, раны становятся смертельными... \n Вашу битву будут помнить вечно! \nCREATOR WIN!");
                }
                else
                {
                    if (isChickenWizard)
                    {
                        Console.WriteLine("Вы только что отложили яйцо!\n");
                    }
                    else
                        if (isChickenBoss)
                    {
                        Console.WriteLine("БОСС только что отложил яйцо!\n");
                    }

                    Console.WriteLine("Кол-во вашего здоровья: " + hpWizard + " ед.");
                    Console.WriteLine("Кол-во здоровья БОССА: " + hpBoss + " ед.");

                    Console.WriteLine("Вы можете выбрать одно из следующих заклинаний:");
                    Console.WriteLine("1 - Фаербол");
                    Console.WriteLine("2 - Ледяной щит");
                    Console.WriteLine("3 - Курица (будьте осторожными!)");
                    Console.WriteLine("4 - Супер Пупер УДАР (можно использовать один раз после каждых трех бросков фаербола)");
                    Console.WriteLine("5 - сбежать с поля боя с позором!");

                    Console.Write("Введите цифру - ");
                    swap = Convert.ToInt32(Console.ReadLine());



                    switch (swap)
                    {
                        case 1:

                            Console.WriteLine("\nВы запускаете фаербол...");
                            randomEvent = rnd.Next(1, 4);
                            countFireball++;

                            if (randomEvent == 1)
                            {
                                damageWizard = rnd.Next(1, 2) * 100;
                                Console.WriteLine("Ваш фаербол влетел БОССУ прямо в челюсть \nБОСС потерял " + damageWizard + " ед. здоровья");
                                damageBoss = rnd.Next(1, 2) * 50;

                                if (isShield)
                                    damageBoss /= 2;

                                Console.WriteLine("БОСС разозлился и вписал вам по носу \nВы потеряли " + damageBoss + " ед. здоровья");

                                hpWizard -= damageBoss;
                                hpBoss -= damageWizard;
                                break;
                            }
                            else
                                if (randomEvent == 2)
                            {
                                damageBoss = rnd.Next(1, 2) * 50;

                                if (isShield)
                                    damageBoss /= 2;

                                Console.WriteLine("А БОСС уворотливый! \nОн ускользнул от фаербола и успел вмазать вам в живот, вы потеряли " + damageBoss + " ед. здоровья");

                                hpWizard -= damageBoss;
                                break;
                            }
                            else
                                if (randomEvent == 3)
                            {
                                damageWizard = rnd.Next(1, 6) * 50;
                                Console.WriteLine("Ваш фаербол попал БОССУ в солнечное сплетение \nБОСС потерял " + damageWizard + " ед. здоровья");
                                Console.WriteLine("БОСС разозлился и хотел вам ответить, но из-за долгой одышки не успел даже кулачком махнуть!");

                                hpBoss -= damageWizard;
                                break;
                            }

                            break;

                        case 2:
                            Console.WriteLine("\nВы покрываетесь льдом...");
                            Console.WriteLine("На вас действует ледяной щит, теперь вы получаете на 50% меньше урона от БОССА, однако ваш щит могут разрушить...");
                            isShield = true;
                            randomEvent = rnd.Next(1, 3);

                            if (randomEvent == 1)
                            {
                                Console.WriteLine("БОСС полюбовался вашим щитом и сплюнул");
                                break;
                            }
                            else
                                if (randomEvent == 2)
                            {
                                damageBoss = rnd.Next(5, 10) * 10;

                                if (isShield)
                                    damageBoss /= 2;

                                Console.WriteLine("БОССУ не понравился ваш новый щит \nОн в ярости кинул в вас первый попавшийся камень и вы потеряли " + damageBoss + " ед. здоровья");

                                hpWizard -= damageBoss;
                                break;
                            }

                            break;

                        case 3:
                            if (countChicken == 0)
                            {
                                int choice;
                                Console.WriteLine("\nВы отважились использовать древнюю магию ВЕЛИКОГО РАНДОМА...");
                                Console.WriteLine("Пути назад не будет.. Вы точно уверены в своих действиях? \nВведите цифру: 1 - да; 2 - нет");
                                choice = Convert.ToInt32(Console.ReadLine());
                                if (choice == 1)
                                {
                                    Console.WriteLine("\nА вы действительно смельчак! Вы применяете заклинание *Курица*...");
                                    randomEvent = rnd.Next(1, 3);

                                    if (randomEvent == 1)
                                    {
                                        hpBoss = 1;
                                        isChickenBoss = true;
                                        countChicken++;
                                        Console.WriteLine("\nДа вы просто везунчик! Самое случайное заклинание случайным образом попало в мега БОССА");
                                        Console.WriteLine("БОСС превратился в курицу! Глупый неудачник, теперь то вы легко его прикончите!");
                                        Console.WriteLine("Уровень здоровья БОССА равен " + hpBoss + " ед.! \nВ начале каждого хода БОСС откладывает яйцо!");
                                        Console.WriteLine("Добейте гада!");
                                        break;
                                    }
                                    else
                                    if (randomEvent == 2)
                                    {
                                        hpWizard = 1;
                                        isChickenWizard = true;
                                        countChicken++;
                                        Console.WriteLine("\nХА ХА, вы правда думали что у вас получится обуздать и победить ВЕЛИКИЙ РАНДОМ?!");
                                        Console.WriteLine("Ваше тело покрывается перьями... Все вокруг становится больше в размерах... или вам так кажется...");
                                        Console.WriteLine("Не стоило шутить со столь сложной магией, теперь вы КУРИЦА! ");
                                        Console.WriteLine("Ваш уровень здоровья равен " + hpWizard + " ед.! \nА в начале каждого хода вы откладываете яйцо!");
                                        Console.WriteLine("Но вы все еще можете использовать заклинания (все кроме Курицы), так что продолжайте сражение или бегите и живите веселой жизнью магической КУРИЦЫ!");
                                        break;
                                    }
                                }
                                else
                                    if (choice == 2)
                                    break;
                            }
                            else
                            {
                                Console.WriteLine("\nНе стоит хитрить! Вы уже использовали заклинание *Курица*. Вы конечно крутой волшебник, но маны у вас хватит только на одно столь сложное заклинание");
                                break;
                            }
                            break;

                        case 4:
                            if (countFireball >= 3)
                            {
                                countFireball = 0;
                                damageWizard = rnd.Next(3, 4) * 100;
                                Console.WriteLine("Вы наконец-то используете Супер Пупер УДАР");
                                Console.WriteLine("Ваш кулак превращается в настоящую кувалду!");
                                Console.WriteLine("Вы со всей дури бьете БОССУ по морде и он теряет " + damageWizard + " ед. здоровья");
                                damageBoss = rnd.Next(1, 2) * 100;

                                if (isShield)
                                    damageBoss /= 2;

                                Console.WriteLine("БОССУ больно, он плачет, а плакать он не любит...");
                                Console.WriteLine("БОСС достает свой пистолет и стреляет вам в ногу! Вы теряете " + damageBoss + " ед. здоровья");

                                if (damageBoss >= limitDamageShield && isShield)
                                {
                                    isShield = false;
                                    Console.WriteLine("Удар БОССА был слишком сильным... Ваш ледяной щит трескается!");
                                }

                                hpWizard -= damageBoss;
                                hpBoss -= damageWizard;
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Вы еще не накопили достаточной мощи для Супер Пупер УДАРА");
                                Console.WriteLine("Для использования данного заклинания швырните еще " + (maxCountFireball - countFireball) + " фаербол(а)");
                                break;
                            }

                        case 5:
                            isWizard = false;
                            Console.WriteLine("Вы с позором сбегаете от мега БОССА \nКто то скажет, что  вы трус... Зато живой... Хотя ваши панталоны немного испачкались...");
                            break;
                        default:
                            Console.WriteLine("Такой команды не найдено");
                            break;
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
