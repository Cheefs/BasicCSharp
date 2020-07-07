using System;

/**
 * 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
      б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */

namespace Task2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number b: ");
            int b = int.Parse(Console.ReadLine());

            RecursivePrint(a, b);

            Console.WriteLine($"Sum of a and b is: { RecursiveSum(a, b) }");
        }

        static void RecursivePrint(int min, int max)
        {
            if (min < max)
            {
                RecursivePrint(min, max - 1);
            }
            Console.WriteLine($"is or: { max }");
        }

        static int RecursiveSum( int min, int max )
        {
            int sum = 0;
            if ( min < max )
            {
                sum += RecursiveSum( min, max - 1 );
            }
            return sum + max;
        }
    }
}
