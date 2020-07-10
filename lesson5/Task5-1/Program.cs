using System;
using System.Text.RegularExpressions;

/**
 *  Создать программу, которая будет проверять корректность ввода логина.
 *  Корректным логином будет строка от 2-х до 10-ти символов, содержащая только буквы латинского
        алфавита или цифры, при этом цифра не может быть первой:
        а) без использования регулярных выражений;
        б) **с использованием регулярных выражений.
 */

namespace Task5_1
{
    class LoginValidator
    {
        const int MIN_LENGTH = 2;
        const int MAX_LENGTH = 10;

        static bool IsLatinChar( char c )
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');  
        }

        public static bool Validate( string login )
        {
            bool isCorrectLength = (login.Length >= MIN_LENGTH || login.Length <= MAX_LENGTH);

            if ( char.IsNumber( login[0] ) || !isCorrectLength)
            {
                return false;
            }

            foreach ( char el in login )
            {
                bool isValidChar = (IsLatinChar(el) || char.IsNumber(el));
                if ( !isValidChar )
                {
                    return false;
                }
            }
            return true;
        }

        public static bool RegExpValidate( string login )
        {
            Regex regex = new Regex(@"^\D[a-z0-9]+$", RegexOptions.IgnoreCase );
            return regex.IsMatch(login);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Login: ");
            string login = Console.ReadLine();

            Console.WriteLine(LoginValidator.Validate(login));
            Console.WriteLine(LoginValidator.RegExpValidate(login));

            string onlyLatin = "root";
            Console.WriteLine(LoginValidator.Validate(onlyLatin));
            Console.WriteLine(LoginValidator.RegExpValidate(onlyLatin));

            string latinWithNumbers = "root123";
            Console.WriteLine(LoginValidator.Validate(latinWithNumbers));
            Console.WriteLine(LoginValidator.RegExpValidate(latinWithNumbers));

            string firstNumber = "1root";
            Console.WriteLine(LoginValidator.Validate(firstNumber));
            Console.WriteLine(LoginValidator.RegExpValidate(firstNumber));

            string hasKirilic = "roфot";
            Console.WriteLine(LoginValidator.Validate(hasKirilic));
            Console.WriteLine(LoginValidator.RegExpValidate(hasKirilic));

            string hasKirilicAndNUmber = "root12Ф";
            Console.WriteLine(LoginValidator.Validate(hasKirilicAndNUmber));
            Console.WriteLine(LoginValidator.RegExpValidate(hasKirilicAndNUmber));
        }
    }
}
