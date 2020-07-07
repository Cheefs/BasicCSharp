using System;

/**
 * 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
 *          Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран; Используя tryParse;
 *    б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. При возникновении ошибки вывести сообщение.
 */

namespace Task3_2
{
    class Program
    {
        const int INTERUPT_SYMBOL = 0;
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter numbers!\n To Stop entering and get result enter '{ INTERUPT_SYMBOL }'");
            bool needStop = false;
            int sum = 0;

            while ( !needStop )
            {
                int number;
                bool isNumber = int.TryParse(Console.ReadLine(), out number);

                if ( !isNumber )
                {
                    Console.WriteLine("Is not A Number!");
                    continue;
                }

                sum += IsPositiveAndOdd(number) ? number : 0;

                needStop = (number == INTERUPT_SYMBOL);
            }

            Console.WriteLine($"Sum of positive and Odd numbers is: { sum }");
        }

        static bool IsPositiveAndOdd(int number )
        {
            return (number > 0 && number % 2 != 0);
        }
    }
}
