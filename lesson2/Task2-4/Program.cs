using System;

/**
 * 4. Реализовать метод проверки логина и пароля.
 * На вход подается логин и пароль.
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password:GeekBrains).
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 */

namespace Task2_4
{
    class Program
    {
        const int RETRYS_COUNT = 3;
        const string VALID_LOGIN = "root";
        const string VALID_PASSWORD = "GeekBrains";

        static void Main(string[] args)
        {
            int current = 0;
            bool isLoggedIn;
            do
            {
                Console.Write("Enter Login: ");
                string login = Console.ReadLine();
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                isLoggedIn = checkLoginAndPassword(login, password);

                current++;
            } while ( !isLoggedIn && current < RETRYS_COUNT );
        }

        static bool checkLoginAndPassword( string login, string password )
        {
            bool isValid = (login == VALID_LOGIN && password == VALID_PASSWORD);

            if (isValid)
            {
                Console.WriteLine($"Hello: { VALID_LOGIN }!");
            } 
            else
            {
                Console.WriteLine("Incrorrect Username or Password!");
            }

            return isValid;
        }
    }
}
