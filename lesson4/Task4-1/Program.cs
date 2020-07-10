using System;

/**
 * 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
 * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
 * В данной задаче под парой подразумевается два подряд идущих элемента массива.
 * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
 */

namespace Task4_1
{
    class Program
    {
        const int ARRAY_LENGTH = 20;
        const int MAX_VALUE = 10000;
        const int MIN_VALUE = -MAX_VALUE;

        static void Main()
        {
            int[] myArray = new int[ ARRAY_LENGTH ];

            //int[] testArray = { 6, 2, 9, -3, 6 };
            myArray = FillArray(myArray);

            Console.WriteLine(
                GetCountOfCoupleItemsDevidedBy(myArray)
            );
        }

        static int[] FillArray( int[] array)
        {
            Random rnd = new Random();
            for( int i = 0; i < array.Length; i++ )
            {
                array[i] = rnd.Next(MIN_VALUE, MAX_VALUE);
            }
            return array;
        }

        static int GetCountOfCoupleItemsDevidedBy( int[] array, int devidedBy = 3 )
        {
            int count = 0;

            for (int i = 1; i < array.Length; i++)
            {
                bool isPrevCorrect = IsDevidedBy( array[ i -  1 ], devidedBy );
                bool conditionComplete = isPrevCorrect || IsDevidedBy(array[i], devidedBy);
                count += conditionComplete ? 1 : 0;
            }
            return count;
        }

        static bool IsDevidedBy( int num, int devidedBy )
        {
            return num % devidedBy == 0;
        }
    }
}
