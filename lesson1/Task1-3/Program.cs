using System;

/**
 * 3.
 *   а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
 *   Вывести результат используя спецификатор формата .2f (с двумя знаками после запятой);
 *   б) *Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;
 **/

namespace Task3
{
    class Program
    {
        struct Point {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Point p1, p2;

            p1.x = 1;
            p1.y = 1;

            p2.x = 2;
            p2.y = 2;

            Console.WriteLine($"{GetDistance(p1, p2):F2}");
        }

        static double GetDistance( Point p1, Point p2  )
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }
    }
}
