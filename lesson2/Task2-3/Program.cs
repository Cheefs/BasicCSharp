using System;

/**
 * С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
 */

namespace Task2_3
{
    class Program
    {
        const int ESCAPE_SYMBOL = 0;
        static void Main(string[] args)
        {
            bool continueLoop = true;
            int numberSum = 0;
            Console.WriteLine($"Enter a numbers, to get sum! \n To get summ enter '{ESCAPE_SYMBOL}'");
 

            while(continueLoop)
            {
                int paresedNumber;
                bool isNumber = int.TryParse(Console.ReadLine(), out paresedNumber);

                if (!isNumber)
                {
                    Console.WriteLine("Is not number");
                    continue;
                }
                continueLoop = (paresedNumber != ESCAPE_SYMBOL);

                numberSum += paresedNumber;
            }

            Console.WriteLine($"Sum is: { numberSum }");
        }
    }
}
