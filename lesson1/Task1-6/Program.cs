using System;

/**
 * 6. *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause). 
 */

namespace Task6
{
    class Helper
    {
        static void Print(string msg, int x = 0, int y = 0)
        {
            Console.WriteLine("Hello World!");
        }

        static void Pause()
        {
            Console.ReadLine();
        }
    }
}
