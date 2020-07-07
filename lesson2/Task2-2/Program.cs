using System;

/**
 * Написать метод подсчета количества цифр числа.
 */

namespace Task2_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write the number: ");
            string number = Console.ReadLine();
            Console.Write($"Your number has:{ GetNumsCountFronNumString(number) }");
        }

        static int GetNumsCountFronNumString( string number )
        {
            return number.Length;
        } 
    }
}
