using System;

/**
 * *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
 * Регистр можно не учитывать:
    а) с использованием методов C#;
    б) *разработав собственный алгоритм.
    Например:
    badc являются перестановкой abcd.

 */


namespace Task5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSameChars("badc", "abcd"));
            Console.WriteLine(IsSameChars("badcd", "abcd"));
            Console.WriteLine(IsSameChars("bacc", "abcd"));

            Console.WriteLine("============================");

            Console.WriteLine(IsSameCharsByArray("badc", "abcd"));
            Console.WriteLine(IsSameCharsByArray("badcd", "abcd"));
            Console.WriteLine(IsSameCharsByArray("bacc", "abcd"));
        }

        static bool IsSameChars( string a, string b)
        {
            if ( a.Length != b.Length )
            {
                return false;
            }
            foreach( char ch in a)
            {
                int index = b.IndexOf(ch);
                if (index == -1 )
                {
                    return false;
                }
                b = b.Remove(index, 1);
            }
            return true;
        }

        static bool IsSameCharsByArray(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            char[] charsA = a.ToCharArray();
            Array.Sort(charsA);
            char[] charsB = b.ToCharArray();
            Array.Sort( charsB );

            for( int i = 0; i< charsA.Length; i++ )
            {
                if (charsA[i] != charsB[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
