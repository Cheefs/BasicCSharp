using System;

/**
 *  а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    в) Добавить диалог с использованием switch демонстрирующий работу класса.
*/

namespace Task3_1
{
    struct Complex
    {
        public double im;
        public double re;
        //  в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im; /// складываем мнимые части
            y.re = re + x.re; /// складываем целые части
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        
        public Complex Diff( Complex x )
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public override string ToString()
        {
            if( re == 0 && im == 0 )
            {
                return "0";
            }

            string symbol = im < 0 ? "-" : "+";

            return re + symbol + Math.Abs(im) + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool appUsing = true;
            Console.WriteLine("Enter 2 complex Numbers. Or Enter 0 to quit");
            Complex complex1;
            Console.Write("RE_1 :");
            complex1.re = int.Parse(Console.ReadLine());
            Console.Write("IM_1 :");
            complex1.im = int.Parse(Console.ReadLine());

            Complex complex2;
            Console.Write("RE_2 :");
            complex2.re = int.Parse(Console.ReadLine());
            Console.Write("IM_2 :");
            complex2.im = int.Parse(Console.ReadLine());

            while( appUsing )
            {
                Console.WriteLine(
                    "What operation do you want to do?" +
                    "\n1 - Plus;" +
                    "\n2 - Multiply;" +
                    "\n3 - Diff"
      
                );
                int choise = int.Parse(Console.ReadLine());
                Complex result;

                switch (choise)
                {
                    case 0:
                    {
                        appUsing = false;
                        break;
                    }
                    case 1:
                    {
                        result = complex1.Plus(complex2);
                        Console.WriteLine(result.ToString());
                        break;
                    }
                    case 2:
                    {
                        result = complex1.Multi(complex2);
                        Console.WriteLine(result.ToString());
                        break;
                    }
                    case 3:
                    {
                        result = complex1.Diff(complex2);
                        Console.WriteLine(result.ToString());
                        break;
                    }
                }
                continue;
            } 
        }
    }
}
