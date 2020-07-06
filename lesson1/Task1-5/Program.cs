using System;
/**
 * 5.
 *   а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 *   б) Сделать задание, только вывод организуйте в центре экрана
 *   в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
 */

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Cheef S., ???, old, ???", 40, 10);
            Console.ReadLine();
        }

        static void Print( string msg, int x = 0, int y = 0)
        {
            Console.SetCursorPosition( x,y );

            Console.WriteLine(msg);
        }
    }
}
