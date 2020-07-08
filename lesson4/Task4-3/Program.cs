using System;
using System.IO;

/**
 * 3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
 */

namespace Task4_3
{
    class Program
    {
        const string FILE_PATH = "./credencials.txt";
        const string SEPARATOR = ";";
        const int RETRYS_COUNT = 3;

        static void Main()
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
            } while (!isLoggedIn && current < RETRYS_COUNT);
        }

        static bool checkLoginAndPassword(string login, string password)
        {
            string[] credencials = GetLoginCredencials();

            bool isValid = (login == credencials[ 0 ] && password == credencials[ 1 ] );

            if (isValid)
            {
                Console.WriteLine($"Hello: { login }!");
            }
            else
            {
                Console.WriteLine("Incrorrect Username or Password!");
            }

            return isValid;
        }

        static string[] GetLoginCredencials()
        {
            StreamReader sr = new StreamReader( FILE_PATH );
            string data = "";
            while ( !sr.EndOfStream )
            {
                data += sr.ReadLine() + SEPARATOR;
            }

            sr.Close();

            return data.Split( SEPARATOR );
        }
    }
}
