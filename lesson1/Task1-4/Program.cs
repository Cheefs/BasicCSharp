using System;

/**
 * 4. Написать программу обмена значениями двух переменных
 *   а) с использованием третьей переменной;
 *   б) *без использования третьей переменной.
 */

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a =  int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before. a: { a }, b: { b }");
            PrintSwapXOR(a, b);
            PrintSwapVar(a, b);
            PrintSwapMath(a, b);
        }

        static void PrintSwapXOR( int a, int b )
        {
            a ^= b;
            b = a ^ b;
            a = b ^ a;

            Console.WriteLine($"After. a: { a }, b: { b }");
        }

        static void PrintSwapVar( int a, int b )
        {
            int c = b;
            b = a;
            a = c;

            Console.WriteLine($"After. a: { a }, b: { b }");
        }

        static void PrintSwapMath(int a, int b)
        {  
            b += a;
            a = b - a;
            b -= a;
            Console.WriteLine($"After. a: { a }, b: { b }");
        }
    }
}
