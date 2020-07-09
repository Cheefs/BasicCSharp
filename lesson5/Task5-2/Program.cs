using System;
using System.Text;
using System.Text.RegularExpressions;

/**
 * 2. Разработать методы для решения следующих задач. Дано сообщение:
    а) Вывести только те слова сообщения, которые содержат не более чем n букв.
    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) Найти самое длинное слово сообщения.
    г) Найти все самые длинные слова сообщения.
    Постараться разработать класс MyString.
    Продемонстрируйте работу программы на текстовом файле с вашей программой.
    д) *Используйте при обработке строк StringBuilder.
    ***е) Решите задачу, используя только регулярные выражения. 
 */

namespace Task5_2
{
    class MyString
    {
        public static string DeleteLongWords( string str, int length, bool regExp = true )
        {
            StringBuilder sb = new StringBuilder();
            string[] arrayOfStrings = str.Split(" ");

            if (regExp)
            {
                string noLongWords = Regex.Replace(str, $@"\S{{{length + 1},}}", ""); 

                return Regex.Replace(noLongWords, @"\s{2,}", " ");
            }

            foreach ( string el in arrayOfStrings )
            {
                if ( el.Length > length )
                {
                    continue;
                }
             
                sb.Append($"{ el } ");
            }

            return sb.ToString(); ;
        }

        public static string DeleteWordsWhoAnds(string str, char symbol, bool regExp = true)
        {
            StringBuilder sb = new StringBuilder();
            string[] arrayOfStrings = str.Split(" ");

            if (regExp)
            {
                return Regex.Replace(str, @$"\s?\b\S+{ symbol }\b\s?", " ");
            }

            foreach (string el in arrayOfStrings)
            {
                if ( symbol.Equals( el[ el.Length - 1 ]) ) 
                {
                    continue;
                }

                sb.Append($"{ el } ");
            }

            return sb.ToString(); ;
        }

        public static string LongestWord( string str )
        {
            string[] arrayOfStrings = str.Split(" ");
  
            StringBuilder longestWord = new StringBuilder(arrayOfStrings[0]);

            foreach (string el in arrayOfStrings)
            {
                if (longestWord.Length > el.Length )
                {
                    continue;
                }

                longestWord = new StringBuilder(el);
            }

            return longestWord.ToString();
        }

        public static string GetAllLongestWords(string str)
        {
            string longestWord = LongestWord(str);

            MatchCollection m = Regex.Matches(str, $"{longestWord}", RegexOptions.Multiline);

            string matches = "";

            foreach ( Match el in m )
            {
                matches += $"{ el } ";
            }

            return matches;
        }
    }

    class Program
    {
        const string MESSAGE = "2. Разработать методы для решения следующих задач." +
            " Дано сообщение:" +
            " а) Вывести только те слова сообщения которые содержат не более чем n букв." +
            " б) Удалить из сообщения все слова которые заканчиваются на заданный символ." +
            " в) Найти самое длинное слово сообщения." +
            " г) Найти все самые длинные слова сообщения." +
            " Постараться разработать класс MyString. Продемонстрируйте работу программы на текстовом файле с вашей программой." +
            " д) * Используйте при обработке строк StringBuilder." +
            " ***е) Продемонстрируйте Решите задачу, используя только регулярные выражения.";

        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine( MyString.DeleteLongWords( MESSAGE, 3, false ) );
            Console.WriteLine("=================================================");
            Console.WriteLine(MyString.DeleteLongWords(MESSAGE, 3));

            Console.WriteLine("=================================================");
            Console.WriteLine(MyString.DeleteWordsWhoAnds(MESSAGE, 'я', false));
            Console.WriteLine("=================================================");
            Console.WriteLine(MyString.DeleteWordsWhoAnds(MESSAGE, 'я'));
            Console.WriteLine("=================================================");
            Console.WriteLine(MyString.LongestWord(MESSAGE));
            Console.WriteLine("=================================================");
            Console.WriteLine(MyString.GetAllLongestWords(MESSAGE));
        }
    }
}
