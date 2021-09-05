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
            int[] array = new int[0];
            string inputData;


            while (true)
            {
                Console.WriteLine("������� �����, ������� sum ��� ������� exit :");
                inputData = Console.ReadLine();

                if (inputData == "exit")
                {
                    break;
                }
                else if (inputData == "sum")
                {
                    if (array.Length > 0)
                    {
                        int sum = 0;

                        for (int i = 0; i < array.Length; i++)
                        {
                            sum += array[i];
                        }
                        Console.WriteLine("����� �������� �����:");
                        Console.WriteLine(sum);
                    }
                    else
                        Console.WriteLine("���������� ����� ����� �.�. �� �� ����� �� ������ �����");
                }
                else
                {
                    int[] tempArray = new int[array.Length + 1];
                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    tempArray[tempArray.Length - 1] = Convert.ToInt32(inputData);
                    array = tempArray;
                }
            }

            Console.WriteLine("�� ��������� ���������");
            Console.ReadKey();
        }
    }
}