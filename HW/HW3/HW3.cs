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
            int countPicture = 52;
            int pictureRow = 3;
            int fullRows;
            int extraPicture;

            fullRows = countPicture / pictureRow;
            extraPicture = countPicture % pictureRow;
            Console.WriteLine("Количество полностью заполненных рядов - " + fullRows);
            Console.WriteLine("Количество лишних картинок - " + extraPicture);
        }
    }
}
