using System;

/**
 * 1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double(double,double).
 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
*/

namespace Task6_1
{
    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double Fun(double a, double x);

    class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyPow(double a, double x)
        {
            return a * Math.Pow(x, 2);
        }

        public static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            Console.WriteLine("Таблица функции a*x^2:");
            Table(MyPow, 4, -2, 2);

            Console.WriteLine("Таблица функции a*sin(x):");
            Table(MySin, 4, -2, 2);

            Console.WriteLine("Таблица функции a*x/2:");
            Table(delegate ( double a, double x ) {
                return a * x /2;           
            }, 4, -2, 2);
        }
    }
}