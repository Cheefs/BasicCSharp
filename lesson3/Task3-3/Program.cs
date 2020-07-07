using System;

/**
 * 3. Напишите соответствующую функцию
    Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
    Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
 */

namespace Task3_3
{
    class RationalNumber
    {
        int numenator;
        int denumenator;

        public int Numenator {
            get => numenator;
            set => numenator = value;
        }
        public int Denumenator
        {
            get => denumenator;
            set => denumenator = value;
        }

        public RationalNumber( int numenator, int denumenator )
        {
            this.numenator = numenator;
            this.denumenator = denumenator;
        }

        public double Sum( RationalNumber x )
        {
            if ( x.Denumenator == denumenator )
            {
               return x.Numenator + numenator / denumenator;
            }

            double tmNumerator = numenator * x.Denumenator + x.Numenator * denumenator;
            double tmpDenumenator = x.Denumenator * denumenator;

            return tmNumerator / tmpDenumenator;
        }
        public double Multy(RationalNumber x)
        {
            return (double)(numenator * x.Numenator) / (x.Denumenator * denumenator);
        }

        public double Diff(RationalNumber x)
        {
            double tmNumerator;
            double tmpDenumenator;

            if (x.Denumenator == denumenator)
            {
                tmNumerator = x.Numenator - numenator;
                return tmNumerator != 0 ? (tmNumerator / denumenator) : 0;
            }

            tmNumerator = numenator * x.Denumenator - x.Numenator * denumenator;
            tmpDenumenator = x.Denumenator * denumenator;

            return tmNumerator != 0 ? ( tmNumerator / tmpDenumenator ) : 0;
        }
        public double Devide(RationalNumber x)
        {
            double tmNumerator;
            double tmpDenumenator;

            tmNumerator = numenator * x.Denumenator;
            tmpDenumenator = denumenator * x.Numenator;

            return tmNumerator / tmpDenumenator;
        }
    }

    class Program
    {
        static void Main()
        {
            RationalNumber r1 = new RationalNumber(1, 2);
            RationalNumber r2 = new RationalNumber(1, 5);

            Console.WriteLine( r1.Sum(r2) );
            Console.WriteLine( r1.Multy(r2) );
            Console.WriteLine( r1.Diff(r2) );
            Console.WriteLine( r1.Devide(r2) );
        }
    }
}
