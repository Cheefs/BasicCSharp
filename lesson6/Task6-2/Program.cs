using System;
using System.Collections.Generic;
using System.IO;

/**
 * Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
 * а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
 *  Использовать массив (или список) делегатов, в котором хранятся различные функции.
 * б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out). 
 */

namespace Task6_2
{
    class Program
    {
        public delegate double Func(double x);

        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double Sin(double x)
        {
            return x * Math.Sin(x);
        }
        public static double Cos(double x)
        {
            return x * Math.Cos(x);
        }

        public static void SaveFunc(string fileName, double a, double b, double h, Func f )
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write( f(x) );
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min )
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;

            int length = (int)fs.Length / sizeof(double);

            double[] data = new double[length];

            Console.WriteLine($"l { data.Length }");

            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                data[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();

            return data;
        }
        static void Main()
        {
            Func[] functuins = new Func[]{ F, Sin, Cos };

            Console.Write("Enter coordinate 1: ");
            double coordF0 = int.Parse(Console.ReadLine());
            Console.Write("Enter coordinate 2: ");
            double coodrF1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Select a Func");
            Console.WriteLine("1 - x * x - 50 * x + 10; ");
            Console.WriteLine("2 - x * Math.Sin(x) ");
            Console.WriteLine("3 - x * Math.Cos(x) ");
            Console.WriteLine("0 - To exit ");

            while( true )
            {
                int choise;
                bool isNumber = int.TryParse(Console.ReadLine(), out choise);

                if( !isNumber || choise > functuins.Length )
                {
                    Console.WriteLine("Wrong command!");
                    continue;
                }
                if ( choise == 0 )
                {
                    break;
                }

                Func selectedFunc = functuins[choise - 1];

                SaveFunc("data.bin", coordF0, coodrF1, 0.5, selectedFunc );
                double min;
                double[] data = Load("data.bin", out min);

                Console.WriteLine(min);
                Console.WriteLine("==================================");
                foreach (double el in data)
                {
                    Console.WriteLine(el);
                }
            }
        }
    }
}
