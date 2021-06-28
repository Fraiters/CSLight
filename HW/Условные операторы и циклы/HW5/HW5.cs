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
            int step = 7;
            int maxNumber = 98;
            int memberSequence = 0;

            while (memberSequence != maxNumber)
            {
                memberSequence += step;
                Console.Write(" " + memberSequence);
            }
            Console.ReadKey();
        }
    }
}
