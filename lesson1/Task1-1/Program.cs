using System;

/**
 * 1. Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
 *   а) используя склеивание;
 *   б) используя форматированный вывод;
 *   в) *используя вывод со знаком $.
 **/

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse( Console.ReadLine() );
            Console.Write("Enter your height: ");
            int height = int.Parse( Console.ReadLine() );
            Console.Write("Enter your weight: ");

            float weight = float.Parse( Console.ReadLine() );

            Console.WriteLine( "name: " + name + "\tsurname: " + surname + "\tage: " + age + "\theight: " + height + "\tweight: " + weight );
            Console.WriteLine("name: {0}\tsurname: {1}\tage: {2}\theight: {3}\tweight: {4}", name, surname, age, height, weight);

            Console.WriteLine($"name: {name}\tsurname: {surname}\tage: {age}\theight: {height}\tweight: {weight}");

        }
    }
}
