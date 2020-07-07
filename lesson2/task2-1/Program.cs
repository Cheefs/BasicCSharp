using System;

/**
 * 1. Написать метод возвращающий минимальное из трех чисел.
 */

namespace task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());


            Console.WriteLine($"Min value is: { GetMinValue(first, second, third) }");
        }

        static int GetMinValue( int a, int b, int c )
        {
            int minFromFirstNums = Math.Min(a, b);

            return Math.Min( minFromFirstNums, c );
        }
    }
}
