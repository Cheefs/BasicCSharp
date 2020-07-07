using System;

/**
 * 6. *Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000.
 *          Хорошим называется число, которое делится на сумму своих цифр.
 *          Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 */

namespace Task2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            GetGoodNumbersSumm();
        }

        static void GetGoodNumbersSumm(int min = 1, int max = 1000000000)
        {
            int goodnumcount = 0;
            DateTime start = DateTime.Now;
            for (int num = min; num <= max; num++)
            {
                goodnumcount = IsGood(num) ? ++goodnumcount : goodnumcount;
            }
            Console.WriteLine($"Good numbers summ: { goodnumcount }");
            Console.WriteLine($"Time Spend: { DateTime.Now - start }");
        }

        static bool IsGood( int number )
        {
            int temp = 0;
            int tempNumber = number;

            while (tempNumber != 0)
            {
                temp += tempNumber % 10;
                tempNumber /= 10;
            }
            return (number % temp == 0);
        }
    }
}
